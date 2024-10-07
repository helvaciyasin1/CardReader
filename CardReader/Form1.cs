using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CardReader
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAvailablePorts(); // form yüklendiğinde mevcut COM portlarını yüklüyoruz
            txtCardNumber.ReadOnly = true; // card number ın olduğu texbox ı sadece okunur hale getiriyourz

            // datagridview e otomatik kolon oluşturmayı kapat yoksa sıralama bozulabiliyor
            dataGridPersonnelInfo.AutoGenerateColumns = false;

            // datagridview e verilerin eklendiği blok
            dataGridPersonnelInfo.Columns.Add("Department", "Department");
            dataGridPersonnelInfo.Columns.Add("Position", "Position");
            dataGridPersonnelInfo.Columns.Add("Name", "Name");
            dataGridPersonnelInfo.Columns.Add("Surname", "Surname");
            dataGridPersonnelInfo.Columns.Add("CardNumber", "Card Number");


            // renklendirmenin yapıldığı blok
            this.BackColor = ColorTranslator.FromHtml("#243642");

            dataGridPersonnelInfo.BackgroundColor = ColorTranslator.FromHtml("#243642");
            panel3.BackColor = ColorTranslator.FromHtml("#E2F1E7");
            panel5.BackColor = ColorTranslator.FromHtml("#E2F1E7");

            btnConnect.BackColor = ColorTranslator.FromHtml("#629584");
            btnClear.BackColor = ColorTranslator.FromHtml("#629584");
            btnCopy.BackColor = ColorTranslator.FromHtml("#629584");
            btnAdd.BackColor = ColorTranslator.FromHtml("#629584");
            btnSaveClear.BackColor = ColorTranslator.FromHtml("#629584");

            comPortComboBox.BackColor = ColorTranslator.FromHtml("#387478");
            txtDepartment.BackColor = ColorTranslator.FromHtml("#387478");
            txtPosition.BackColor = ColorTranslator.FromHtml("#387478");
            txtCardNumber.BackColor = ColorTranslator.FromHtml("#387478");
            txtName.BackColor = ColorTranslator.FromHtml("#387478");
            txtSurname.BackColor = ColorTranslator.FromHtml("#387478");
            txtFileName.BackColor = ColorTranslator.FromHtml("#387478");

            lblMessage.ForeColor = ColorTranslator.FromHtml("#E2F1E7");

            comPortComboBox.ForeColor = ColorTranslator.FromHtml("#E2F1E7");
            txtDepartment.ForeColor = ColorTranslator.FromHtml("#E2F1E7");
            txtPosition.ForeColor = ColorTranslator.FromHtml("#E2F1E7");
            txtCardNumber.ForeColor = ColorTranslator.FromHtml("#E2F1E7");
            txtName.ForeColor = ColorTranslator.FromHtml("#E2F1E7");
            txtSurname.ForeColor = ColorTranslator.FromHtml("#E2F1E7");
            txtFileName.ForeColor = ColorTranslator.FromHtml("#E2F1E7");

            lblCOMPort.ForeColor = ColorTranslator.FromHtml("#E2F1E7");
            lblDepartment.ForeColor = ColorTranslator.FromHtml("#E2F1E7");
            lblPosition.ForeColor = ColorTranslator.FromHtml("#E2F1E7");
            lblCardNumber.ForeColor = ColorTranslator.FromHtml("#E2F1E7");
            lblName.ForeColor = ColorTranslator.FromHtml("#E2F1E7");
            lblSurname.ForeColor = ColorTranslator.FromHtml("#E2F1E7");
            rbtnSavetoDesktop.ForeColor = ColorTranslator.FromHtml("#E2F1E7");
            rbtnSelectSaveLocation.ForeColor = ColorTranslator.FromHtml("#E2F1E7");
            rbtnDontSave.ForeColor = ColorTranslator.FromHtml("#E2F1E7");
            rbtnDefaultFileName.ForeColor = ColorTranslator.FromHtml("#E2F1E7");
            rbtnCustomFileName.ForeColor = ColorTranslator.FromHtml("#E2F1E7");

        }

        private void LoadAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comPortComboBox.Items.AddRange(ports); // com portlarını combobox a ekliyoruz
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (comPortComboBox.SelectedItem != null) // port seçildi
            {
                serialPort = new SerialPort(comPortComboBox.SelectedItem.ToString(), 9600);
                serialPort.DataReceived += SerialPort_DataReceived; // veri alındığında tetiklenen mesaj
                try
                {
                    serialPort.Open(); // portu acıyoruz
                    lblMessage.Text = "Connection established successfully."; // bağlantı kuruldu - olumlu mesaj
                    panel3.BackColor = Color.Blue;
                    panel5.BackColor = Color.Blue;
                }
                catch (Exception ex)
                {
                    lblMessage.Text = $"Connection error: {ex.Message}"; // bağlantı hatası - olumsuz mesaj
                    panel3.BackColor = Color.Red;
                    panel5.BackColor = Color.Red;
                }
            }
            else
            {
                lblMessage.Text = "Please select a COM port."; // port seçilmezse verilen mesaj
                panel3.BackColor = Color.Red;
                panel5.BackColor = Color.Red;
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadLine(); // porttan okunan veriyi aldık
                data = data.Trim().Replace("\r", "").Replace("\n", ""); // boşluk ve diğer karakterleri kaldırdık

                Invoke(new Action(() =>
                {
                    txtCardNumber.Text = data; // veriyi textbox a yazdık
                }));
            }
            catch (IOException ex) // veri alınamazsa
            {
                MessageBox.Show("Error reading from serial port: " + ex.Message); // hata mesajı yazılır
            }
            catch (InvalidOperationException)
            {
                // port kapalıysa sessize geç
            }
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen) // program kapatılmak istendiğinde port açıksa
            {
                serialPort.Close(); // portu kapatıyoruz ki uygulama doğru şekilde kapansın
            }
            base.OnFormClosing(e);
        }

        private string ToPascalCase(string text) // ilk harfleri büyük yapan metod
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
                else
                {
                    words[i] = words[i].ToUpper();
                }
            }
            return string.Join(" ", words);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtName.Text = ToPascalCase(txtName.Text); // ismi tanımladık, ilk harfini de büyük yaptık
        }

        private void txtSurname_Leave(object sender, EventArgs e)
        {
            txtSurname.Text = txtSurname.Text.ToUpper(); // soyismi tanımladık, toupper metoduyla tüm harfleri büyük yaptık
        }


        private void dataGridPersonnelInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPosition_Leave(object sender, EventArgs e)
        {
            txtPosition.Text = ToPascalCase(txtPosition.Text); // posizyonu tanımladık, ilk harfini de büyük yaptık
        }

        private void txtDepartment_Leave(object sender, EventArgs e)
        {
            txtDepartment.Text = txtDepartment.Text.ToUpper(); // departmanı tanımladık, toupper metoduyla tüm harfleri büyük yaptık
        }

        private void btnClear_Click(object sender, EventArgs e) // temizleme butonu
        {
            // tüm textboxları temizledik
            txtName.Clear();
            txtSurname.Clear();
            txtDepartment.Clear();
            txtPosition.Clear();
            txtCardNumber.Clear();

            lblMessage.Text = "Fields cleared."; // alanlar temizlendi mesajını verdik
            panel3.BackColor = Color.Red;
            panel5.BackColor = Color.Red;
        }

        private void txtDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            // harf ya da boşluk dışındaki karakterleri engelledik
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // harf olmayan giriş engelleniyor
            }
        }

        private void txtPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            // harf ya da boşluk dışındaki karakterleri engelledik
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // harf olmayan giriş engelleniyor
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // harf ya da boşluk dışındaki karakterleri engelledik
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // harf olmayan giriş engelleniyor
            }
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            // harf ya da boşluk dışındaki karakterleri engelledik
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // harf olmayan giriş engelleniyor
            }
        }

        private void btnCopy_Click(object sender, EventArgs e) // yalnızca kart numarasını kopyaladığımız buton
        {
            // boşluklarını sildik
            string cardNumber = txtCardNumber.Text.Trim();

            if (!string.IsNullOrEmpty(cardNumber)) // eğer kartnumarası boş değilse kopyalıyoruz
            {
                Clipboard.SetText(cardNumber); // panoya kopyalandı
                lblMessage.Text = "Card number copied to clipboard."; // kopyalandığının mesajını verdik
                panel3.BackColor = Color.Blue;
                panel5.BackColor = Color.Blue;
            }
            else  // eğer boş ise kopyalanmadı
            {
                lblMessage.Text = "Card number is empty."; // uyarı mesajı verildi
                panel3.BackColor = Color.Red;
                panel5.BackColor = Color.Red;
            }
        }

        private void rbtnSelectSaveLocation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ExportToExcel(string filePath)  // exel dosyasının oluşturup datagriddeki verilerin aktarıldığı blok
        {
            try
            {
                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                var workbook = excelApp.Workbooks.Add();
                var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];

                // veriler burada aktarılıyor
                for (int i = 0; i < dataGridPersonnelInfo.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridPersonnelInfo.Columns[i].HeaderText; //sütun başlıklarını alıyoruz
                }

                for (int i = 0; i < dataGridPersonnelInfo.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridPersonnelInfo.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridPersonnelInfo.Rows[i].Cells[j].Value; // verileri aktarıyoruz
                    }
                }

                // kaydedip exel i kapatıyoruz
                workbook.SaveAs(filePath);
                workbook.Close();
                excelApp.Quit();

                lblMessage.Text = "Data exported successfully to " + filePath; // başarılı mesaj verildi
                panel3.BackColor = Color.Blue;
                panel5.BackColor = Color.Blue;
            }
            catch (Exception ex) // hata olursa
            {
                lblMessage.Text = $"Error: {ex.Message}"; // hata mesajı verildi
                panel3.BackColor = Color.Red;
                panel5.BackColor = Color.Red;
            }
        }

        private void btnSaveClear_Click(object sender, EventArgs e)  // kaydedilip çıkış yapılan blok
        {
            // datagridview boş mu kontrol ediyourz
            if (dataGridPersonnelInfo.Rows.Count < 2)  // sütun isimlerinin olduğu satır 1 satır olduğu için iki den küçükse boştur
            {
                lblMessage.Text = "No data to save. Please add records first."; // boş olduğunu uyarı mesajıyla bildiriyoruz
                panel3.BackColor = Color.Red;
                panel5.BackColor = Color.Red;
                return; // işlemi durduruyoruz
            }

            else // boş değilse devam ediyoruz
            {
                string fileName = "";
                string filePath = "";

                // dosya adı işlemlerinin yapıldığı blok
                if (rbtnDefaultFileName.Checked)  // varsayılan doysa adı seçiliyse
                {
                    fileName = $"Personal Info ({DateTime.Now:yyyy-MM-dd_HH-mm-ss}).xlsx"; // Varsayılan dosya adı = Personal Info (tarih ve saat)
                }

                else if (rbtnCustomFileName.Checked) // dosya adını kendisi seçmek isterse
                {
                    fileName = txtFileName.Text.Trim(); // textbox tan kullanıcı adını alıyoruz

                    if (string.IsNullOrEmpty(fileName)) // eğer textbox boş ise
                    {
                        lblMessage.Text = "Please provide a file name."; // uyarı mesajı verip
                        panel3.BackColor = Color.Red;
                        panel5.BackColor = Color.Red;
                        return; // işlemi durduruyoruz
                    }

                    else // boş değilse
                    {
                        fileName += ".xlsx"; // textbox taki ismi alıp xlsx uzantısı ekliyoruz
                    }

                }

                // kayıt yerinin seçildiği blok
                if (rbtnDontSave.Checked) // kayıt yapılmadan çıkılmak istendiyse
                {
                    // excel i daha öncesinde oluşturduk ama kayıt yapmıyoruz
                    lblMessage.Text = "Data not saved."; // mesaj veriyoruz
                    panel3.BackColor = Color.Red;
                    panel5.BackColor = Color.Red;
                    dataGridPersonnelInfo.Rows.Clear(); // datagridview i temizliyoruz
                }
                else if (rbtnSavetoDesktop.Checked) // masaüstüne kayıt yapılması istendiyse
                {
                    filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName); // masaüstüne kaydetme işlemi
                    ExportToExcel(filePath); // masaüstüne kayıt yaptık
                    dataGridPersonnelInfo.Rows.Clear(); // datagridview i temizledik
                }
                else if (rbtnSelectSaveLocation.Checked) // kaydetme konumunu kendisi seçmek isterse
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.FileName = fileName; // dosya adını aldık
                        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                        saveFileDialog.Title = "Select Save Location";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            filePath = saveFileDialog.FileName;
                            ExportToExcel(filePath); // kaydettik
                            dataGridPersonnelInfo.Rows.Clear(); // datagridview i temizledik
                        }
                    }
                }
                else
                {
                    // eğer kullanıcı bir kayıt yeri seçmezse
                    lblMessage.Text = "Please select a save option."; // Uyarı mesajı
                    panel3.BackColor = Color.Red;
                    panel5.BackColor = Color.Red;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // formun kapatılma işlemleri
        {
            if (serialPort.IsOpen)
            {
                serialPort.DataReceived -= SerialPort_DataReceived; // veri alımını durduruyoruz
                serialPort.Close(); // portu kapatıyoruz
            }

            if (dataGridPersonnelInfo.Rows.Count > 1) // kullanıcı datagridde veri varken kapatmak istediyse
            {
                // uyarı mesajı veriyoruz
                DialogResult result = MessageBox.Show("There are unsaved changes in the data grid. Do you really want to exit?",
                                                       "Exit Confirmation",
                                                       MessageBoxButtons.YesNo, // messageboxbuttons lar ile çıkmak istediğine emin mi soruyoruz
                                                       MessageBoxIcon.Warning);

                if (result == DialogResult.No) // hayır derse çıkışı iptal ediyoruz
                {
                    e.Cancel = true; // çıkmasını engelledik
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) // datagirdview e veri ekleme butonu
        {
            // textbox taki girdileri alıyoruz (trim metodu ile boşlukları sildik)
            string department = txtDepartment.Text.Trim();
            string position = txtPosition.Text.Trim();
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string cardNumber = txtCardNumber.Text.Trim();

            // isim, soyisim ve kart numarası alanlarının boş olmadığından emin oluyoruz
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(cardNumber)) // eğer boş ise
            {
                lblMessage.Text = "Name and Surname cannot be empty."; // uyarı mesajı verdik
                panel3.BackColor = Color.Red;
                panel5.BackColor = Color.Red;
                return; // işlemi durdurduk
            }

            // daha önce aynı kart numarasıyla kayıt yapılmış mı kontrol ediyoruz
            foreach (DataGridViewRow row in dataGridPersonnelInfo.Rows) // foreach döngüsü ile kontrol edeceğiz
            {
                if (!row.IsNewRow) // yeni boş satır olmadığından emin oluyoruz
                {
                    if (row.Cells[4].Value != null && row.Cells[4].Value.ToString() == cardNumber) // kartnumaralarının (5.) hücresini kontrol ediyoruz bizim yeni kart numaramız ile eşleşiyor mu diye
                    {
                        lblMessage.Text = "This card number is already added."; // uyarı mesajı verdik
                        panel3.BackColor = Color.Red;
                        panel5.BackColor = Color.Red;
                        return; // işlemi durdurduk
                    }
                }
            }

            // aldığımız verileri doğru sıra ile yeni satır olarak ekliyoruz
            dataGridPersonnelInfo.Rows.Add(department, position, name, surname, cardNumber);

            // textbox ları temizliyoruz
            txtName.Clear();
            txtSurname.Clear();
            txtDepartment.Clear();
            txtPosition.Clear();
            txtCardNumber.Clear();

            // bilgilendirme mesajı veriyoruz
            lblMessage.Text = "Record added successfully.";
            panel3.BackColor = Color.Blue;
            panel5.BackColor = Color.Blue;

            // satır renklerini ayarladığımız metodu çağırıyoruz
            SetRowColors();
        }

        private void SetRowColors() // satır renklerini ayarladığımız metodun bloğu
        {
            // seçtiğimiz renklerimiz
            Color firstColor = ColorTranslator.FromHtml("#E2F1E7");
            Color secondColor = ColorTranslator.FromHtml("#629584");

            for (int i = 0; i < dataGridPersonnelInfo.Rows.Count; i++) // for döngüsünü başlatıyoruz ve toplam satır sayısına ulaşana kadar devam ediyor
            {
                if (i % 2 == 0) // eğer çift satır ise
                {
                    dataGridPersonnelInfo.Rows[i].DefaultCellStyle.BackColor = firstColor; // birinci renk
                }
                else // eğer tek satır ise
                {
                    dataGridPersonnelInfo.Rows[i].DefaultCellStyle.BackColor = secondColor; // ikinci renk
                }
            }
        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
