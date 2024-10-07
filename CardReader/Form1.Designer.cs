namespace CardReader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comPortComboBox = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.MaskedTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.MaskedTextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridPersonnelInfo = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCOMPort = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSaveClear = new System.Windows.Forms.Button();
            this.rbtnSavetoDesktop = new System.Windows.Forms.RadioButton();
            this.rbtnSelectSaveLocation = new System.Windows.Forms.RadioButton();
            this.rbtnDontSave = new System.Windows.Forms.RadioButton();
            this.rbtnDefaultFileName = new System.Windows.Forms.RadioButton();
            this.rbtnCustomFileName = new System.Windows.Forms.RadioButton();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonnelInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comPortComboBox
            // 
            this.comPortComboBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comPortComboBox.FormattingEnabled = true;
            this.comPortComboBox.Location = new System.Drawing.Point(643, 316);
            this.comPortComboBox.Name = "comPortComboBox";
            this.comPortComboBox.Size = new System.Drawing.Size(83, 25);
            this.comPortComboBox.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.btnConnect.Location = new System.Drawing.Point(643, 339);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(111, 31);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(12, 243);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 27);
            this.txtName.TabIndex = 3;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtSurname.Location = new System.Drawing.Point(161, 243);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(143, 27);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            this.txtSurname.Leave += new System.EventHandler(this.txtSurname_Leave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(9, 224);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(158, 224);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(66, 17);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDepartment.Location = new System.Drawing.Point(12, 199);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(143, 27);
            this.txtDepartment.TabIndex = 7;
            this.txtDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartment_KeyPress);
            this.txtDepartment.Leave += new System.EventHandler(this.txtDepartment_Leave);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(9, 180);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(96, 17);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "Department:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(161, 180);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(70, 17);
            this.lblPosition.TabIndex = 9;
            this.lblPosition.Text = "Position:";
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPosition.Location = new System.Drawing.Point(161, 199);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(143, 27);
            this.txtPosition.TabIndex = 10;
            this.txtPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPosition_KeyPress);
            this.txtPosition.Leave += new System.EventHandler(this.txtPosition_Leave);
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(310, 180);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(105, 17);
            this.lblCardNumber.TabIndex = 11;
            this.lblCardNumber.Text = "Card Number:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCardNumber.Location = new System.Drawing.Point(313, 199);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(142, 27);
            this.txtCardNumber.TabIndex = 12;
            this.txtCardNumber.TextChanged += new System.EventHandler(this.txtCardNumber_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.btnAdd.Location = new System.Drawing.Point(457, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 43);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridPersonnelInfo
            // 
            this.dataGridPersonnelInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonnelInfo.Location = new System.Drawing.Point(12, 12);
            this.dataGridPersonnelInfo.Name = "dataGridPersonnelInfo";
            this.dataGridPersonnelInfo.RowHeadersWidth = 51;
            this.dataGridPersonnelInfo.RowTemplate.Height = 24;
            this.dataGridPersonnelInfo.Size = new System.Drawing.Size(738, 160);
            this.dataGridPersonnelInfo.TabIndex = 14;
            this.dataGridPersonnelInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPersonnelInfo_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(457, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 43);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCOMPort
            // 
            this.lblCOMPort.AutoSize = true;
            this.lblCOMPort.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCOMPort.Location = new System.Drawing.Point(639, 298);
            this.lblCOMPort.Name = "lblCOMPort";
            this.lblCOMPort.Size = new System.Drawing.Size(79, 19);
            this.lblCOMPort.TabIndex = 16;
            this.lblCOMPort.Text = "COM Port:";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessage.Location = new System.Drawing.Point(609, 188);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(142, 85);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(313, 232);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(142, 41);
            this.btnCopy.TabIndex = 19;
            this.btnCopy.Text = "Copy Card Number";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSaveClear
            // 
            this.btnSaveClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.btnSaveClear.Location = new System.Drawing.Point(521, 292);
            this.btnSaveClear.Name = "btnSaveClear";
            this.btnSaveClear.Size = new System.Drawing.Size(100, 77);
            this.btnSaveClear.TabIndex = 20;
            this.btnSaveClear.Text = "Save/  Clear";
            this.btnSaveClear.UseVisualStyleBackColor = true;
            this.btnSaveClear.Click += new System.EventHandler(this.btnSaveClear_Click);
            // 
            // rbtnSavetoDesktop
            // 
            this.rbtnSavetoDesktop.AutoSize = true;
            this.rbtnSavetoDesktop.Checked = true;
            this.rbtnSavetoDesktop.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSavetoDesktop.Location = new System.Drawing.Point(3, 3);
            this.rbtnSavetoDesktop.Name = "rbtnSavetoDesktop";
            this.rbtnSavetoDesktop.Size = new System.Drawing.Size(215, 22);
            this.rbtnSavetoDesktop.TabIndex = 21;
            this.rbtnSavetoDesktop.TabStop = true;
            this.rbtnSavetoDesktop.Text = "Save to Desktop  and Clear Data";
            this.rbtnSavetoDesktop.UseVisualStyleBackColor = true;
            // 
            // rbtnSelectSaveLocation
            // 
            this.rbtnSelectSaveLocation.AutoSize = true;
            this.rbtnSelectSaveLocation.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rbtnSelectSaveLocation.Location = new System.Drawing.Point(3, 26);
            this.rbtnSelectSaveLocation.Name = "rbtnSelectSaveLocation";
            this.rbtnSelectSaveLocation.Size = new System.Drawing.Size(237, 22);
            this.rbtnSelectSaveLocation.TabIndex = 22;
            this.rbtnSelectSaveLocation.Text = "Select Save Location and Clear Data";
            this.rbtnSelectSaveLocation.UseVisualStyleBackColor = true;
            this.rbtnSelectSaveLocation.CheckedChanged += new System.EventHandler(this.rbtnSelectSaveLocation_CheckedChanged);
            // 
            // rbtnDontSave
            // 
            this.rbtnDontSave.AutoSize = true;
            this.rbtnDontSave.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rbtnDontSave.Location = new System.Drawing.Point(3, 50);
            this.rbtnDontSave.Name = "rbtnDontSave";
            this.rbtnDontSave.Size = new System.Drawing.Size(181, 22);
            this.rbtnDontSave.TabIndex = 23;
            this.rbtnDontSave.Text = "Don\'t Save and Clear Data";
            this.rbtnDontSave.UseVisualStyleBackColor = true;
            // 
            // rbtnDefaultFileName
            // 
            this.rbtnDefaultFileName.AutoSize = true;
            this.rbtnDefaultFileName.Checked = true;
            this.rbtnDefaultFileName.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rbtnDefaultFileName.Location = new System.Drawing.Point(3, 3);
            this.rbtnDefaultFileName.Name = "rbtnDefaultFileName";
            this.rbtnDefaultFileName.Size = new System.Drawing.Size(223, 22);
            this.rbtnDefaultFileName.TabIndex = 24;
            this.rbtnDefaultFileName.TabStop = true;
            this.rbtnDefaultFileName.Text = "Default File Name(Personnel Info)";
            this.rbtnDefaultFileName.UseVisualStyleBackColor = true;
            // 
            // rbtnCustomFileName
            // 
            this.rbtnCustomFileName.AutoSize = true;
            this.rbtnCustomFileName.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rbtnCustomFileName.Location = new System.Drawing.Point(3, 26);
            this.rbtnCustomFileName.Name = "rbtnCustomFileName";
            this.rbtnCustomFileName.Size = new System.Drawing.Size(133, 22);
            this.rbtnCustomFileName.TabIndex = 25;
            this.rbtnCustomFileName.Text = "Custon File Name:";
            this.rbtnCustomFileName.UseVisualStyleBackColor = true;
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtFileName.Location = new System.Drawing.Point(290, 340);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(228, 27);
            this.txtFileName.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnSelectSaveLocation);
            this.panel1.Controls.Add(this.rbtnSavetoDesktop);
            this.panel1.Controls.Add(this.rbtnDontSave);
            this.panel1.Location = new System.Drawing.Point(12, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 72);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnDefaultFileName);
            this.panel2.Controls.Add(this.rbtnCustomFileName);
            this.panel2.Location = new System.Drawing.Point(289, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 46);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(12, 279);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 10);
            this.panel3.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(627, 292);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 77);
            this.panel5.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 378);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSaveClear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCOMPort);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridPersonnelInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.comPortComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonnelInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comPortComboBox;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox txtSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.MaskedTextBox txtDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridPersonnelInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCOMPort;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnSaveClear;
        private System.Windows.Forms.RadioButton rbtnSavetoDesktop;
        private System.Windows.Forms.RadioButton rbtnSelectSaveLocation;
        private System.Windows.Forms.RadioButton rbtnDontSave;
        private System.Windows.Forms.RadioButton rbtnDefaultFileName;
        private System.Windows.Forms.RadioButton rbtnCustomFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
    }
}

