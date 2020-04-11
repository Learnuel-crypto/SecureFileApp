namespace SecureFile
    {
    partial class Secure_File
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Secure_File));
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioTXT = new System.Windows.Forms.RadioButton();
            this.radioPNG = new System.Windows.Forms.RadioButton();
            this.radioJPEG = new System.Windows.Forms.RadioButton();
            this.RadioDoc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOutfutFolder = new System.Windows.Forms.Button();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioEXE = new System.Windows.Forms.RadioButton();
            this.radioPPT = new System.Windows.Forms.RadioButton();
            this.radioMP4 = new System.Windows.Forms.RadioButton();
            this.radioMP3 = new System.Windows.Forms.RadioButton();
            this.radioXLS = new System.Windows.Forms.RadioButton();
            this.radioXLSX = new System.Windows.Forms.RadioButton();
            this.radioACCDB = new System.Windows.Forms.RadioButton();
            this.radioCDR = new System.Windows.Forms.RadioButton();
            this.radioMSI = new System.Windows.Forms.RadioButton();
            this.radioDLL = new System.Windows.Forms.RadioButton();
            this.radioAVI = new System.Windows.Forms.RadioButton();
            this.radioFLV = new System.Windows.Forms.RadioButton();
            this.radioGIF = new System.Windows.Forms.RadioButton();
            this.radioMPG = new System.Windows.Forms.RadioButton();
            this.checkDeleteFile = new System.Windows.Forms.CheckBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.radioOthers = new System.Windows.Forms.RadioButton();
            this.radioBMP = new System.Windows.Forms.RadioButton();
            this.radioTIFF = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.FlatAppearance.BorderSize = 0;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.Location = new System.Drawing.Point(619, 84);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(46, 29);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = ". . .";
            this.btnSelectFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(12, 86);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(605, 25);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(516, 119);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(101, 33);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt File";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(12, 359);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(110, 33);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt File";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioTIFF);
            this.groupBox1.Controls.Add(this.radioBMP);
            this.groupBox1.Controls.Add(this.radioOthers);
            this.groupBox1.Controls.Add(this.txtExtension);
            this.groupBox1.Controls.Add(this.radioMSI);
            this.groupBox1.Controls.Add(this.radioDLL);
            this.groupBox1.Controls.Add(this.radioAVI);
            this.groupBox1.Controls.Add(this.radioFLV);
            this.groupBox1.Controls.Add(this.radioGIF);
            this.groupBox1.Controls.Add(this.radioMPG);
            this.groupBox1.Controls.Add(this.radioMP4);
            this.groupBox1.Controls.Add(this.radioMP3);
            this.groupBox1.Controls.Add(this.radioXLS);
            this.groupBox1.Controls.Add(this.radioXLSX);
            this.groupBox1.Controls.Add(this.radioACCDB);
            this.groupBox1.Controls.Add(this.radioCDR);
            this.groupBox1.Controls.Add(this.radioPPT);
            this.groupBox1.Controls.Add(this.radioEXE);
            this.groupBox1.Controls.Add(this.radioTXT);
            this.groupBox1.Controls.Add(this.radioPNG);
            this.groupBox1.Controls.Add(this.radioJPEG);
            this.groupBox1.Controls.Add(this.RadioDoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 169);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select File Extension";
            // 
            // radioTXT
            // 
            this.radioTXT.AutoSize = true;
            this.radioTXT.Location = new System.Drawing.Point(86, 28);
            this.radioTXT.Name = "radioTXT";
            this.radioTXT.Size = new System.Drawing.Size(48, 25);
            this.radioTXT.TabIndex = 10;
            this.radioTXT.TabStop = true;
            this.radioTXT.Text = ".txt";
            this.radioTXT.UseVisualStyleBackColor = true;
            this.radioTXT.Click += new System.EventHandler(this.radioTXT_Click);
            // 
            // radioPNG
            // 
            this.radioPNG.AutoSize = true;
            this.radioPNG.Location = new System.Drawing.Point(161, 28);
            this.radioPNG.Name = "radioPNG";
            this.radioPNG.Size = new System.Drawing.Size(58, 25);
            this.radioPNG.TabIndex = 9;
            this.radioPNG.TabStop = true;
            this.radioPNG.Text = ".png";
            this.radioPNG.UseVisualStyleBackColor = true;
            this.radioPNG.Click += new System.EventHandler(this.radioPNG_Click);
            // 
            // radioJPEG
            // 
            this.radioJPEG.AutoSize = true;
            this.radioJPEG.Location = new System.Drawing.Point(236, 28);
            this.radioJPEG.Name = "radioJPEG";
            this.radioJPEG.Size = new System.Drawing.Size(61, 25);
            this.radioJPEG.TabIndex = 8;
            this.radioJPEG.TabStop = true;
            this.radioJPEG.Text = ".jpeg";
            this.radioJPEG.UseVisualStyleBackColor = true;
            this.radioJPEG.Click += new System.EventHandler(this.radioJPEG_Click);
            // 
            // RadioDoc
            // 
            this.RadioDoc.AutoSize = true;
            this.RadioDoc.Location = new System.Drawing.Point(11, 28);
            this.RadioDoc.Name = "RadioDoc";
            this.RadioDoc.Size = new System.Drawing.Size(56, 25);
            this.RadioDoc.TabIndex = 0;
            this.RadioDoc.TabStop = true;
            this.RadioDoc.Text = ".doc";
            this.RadioDoc.UseVisualStyleBackColor = true;
            this.RadioDoc.Click += new System.EventHandler(this.RadioDoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, -20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "To decryp a file select the extension which the file should be when it is decrypt" +
    "ed";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOutfutFolder
            // 
            this.btnOutfutFolder.FlatAppearance.BorderSize = 0;
            this.btnOutfutFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutfutFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutfutFolder.Location = new System.Drawing.Point(621, 31);
            this.btnOutfutFolder.Name = "btnOutfutFolder";
            this.btnOutfutFolder.Size = new System.Drawing.Size(46, 29);
            this.btnOutfutFolder.TabIndex = 5;
            this.btnOutfutFolder.Text = ". . .";
            this.btnOutfutFolder.UseVisualStyleBackColor = true;
            this.btnOutfutFolder.Click += new System.EventHandler(this.btnOutfutFolder_Click);
            // 
            // txtFolderName
            // 
            this.txtFolderName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderName.Location = new System.Drawing.Point(12, 35);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.ReadOnly = true;
            this.txtFolderName.Size = new System.Drawing.Size(605, 25);
            this.txtFolderName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Output Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(405, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "To decrypt, select the file extension which it will be decrypted to. ";
            // 
            // radioEXE
            // 
            this.radioEXE.AutoSize = true;
            this.radioEXE.Location = new System.Drawing.Point(311, 28);
            this.radioEXE.Name = "radioEXE";
            this.radioEXE.Size = new System.Drawing.Size(54, 25);
            this.radioEXE.TabIndex = 11;
            this.radioEXE.TabStop = true;
            this.radioEXE.Text = ".exe";
            this.radioEXE.UseVisualStyleBackColor = true;
            this.radioEXE.CheckedChanged += new System.EventHandler(this.radioEXE_CheckedChanged);
            this.radioEXE.Click += new System.EventHandler(this.radioEXE_Click);
            // 
            // radioPPT
            // 
            this.radioPPT.AutoSize = true;
            this.radioPPT.Location = new System.Drawing.Point(386, 28);
            this.radioPPT.Name = "radioPPT";
            this.radioPPT.Size = new System.Drawing.Size(54, 25);
            this.radioPPT.TabIndex = 12;
            this.radioPPT.TabStop = true;
            this.radioPPT.Text = ".ppt";
            this.radioPPT.UseVisualStyleBackColor = true;
            this.radioPPT.Click += new System.EventHandler(this.radioPPT_Click);
            // 
            // radioMP4
            // 
            this.radioMP4.AutoSize = true;
            this.radioMP4.Location = new System.Drawing.Point(386, 63);
            this.radioMP4.Name = "radioMP4";
            this.radioMP4.Size = new System.Drawing.Size(63, 25);
            this.radioMP4.TabIndex = 18;
            this.radioMP4.TabStop = true;
            this.radioMP4.Text = ".mp4";
            this.radioMP4.UseVisualStyleBackColor = true;
            this.radioMP4.Click += new System.EventHandler(this.radioMP4_Click);
            // 
            // radioMP3
            // 
            this.radioMP3.AutoSize = true;
            this.radioMP3.Location = new System.Drawing.Point(311, 63);
            this.radioMP3.Name = "radioMP3";
            this.radioMP3.Size = new System.Drawing.Size(63, 25);
            this.radioMP3.TabIndex = 17;
            this.radioMP3.TabStop = true;
            this.radioMP3.Text = ".mp3";
            this.radioMP3.UseVisualStyleBackColor = true;
            this.radioMP3.Click += new System.EventHandler(this.radioMP3_Click);
            // 
            // radioXLS
            // 
            this.radioXLS.AutoSize = true;
            this.radioXLS.Location = new System.Drawing.Point(86, 63);
            this.radioXLS.Name = "radioXLS";
            this.radioXLS.Size = new System.Drawing.Size(49, 25);
            this.radioXLS.TabIndex = 16;
            this.radioXLS.TabStop = true;
            this.radioXLS.Text = ".xls";
            this.radioXLS.UseVisualStyleBackColor = true;
            this.radioXLS.Click += new System.EventHandler(this.radioXLS_Click);
            // 
            // radioXLSX
            // 
            this.radioXLSX.AutoSize = true;
            this.radioXLSX.Location = new System.Drawing.Point(161, 63);
            this.radioXLSX.Name = "radioXLSX";
            this.radioXLSX.Size = new System.Drawing.Size(56, 25);
            this.radioXLSX.TabIndex = 15;
            this.radioXLSX.TabStop = true;
            this.radioXLSX.Text = ".xlsx";
            this.radioXLSX.UseVisualStyleBackColor = true;
            this.radioXLSX.Click += new System.EventHandler(this.radioXLSX_Click);
            // 
            // radioACCDB
            // 
            this.radioACCDB.AutoSize = true;
            this.radioACCDB.Location = new System.Drawing.Point(236, 63);
            this.radioACCDB.Name = "radioACCDB";
            this.radioACCDB.Size = new System.Drawing.Size(71, 25);
            this.radioACCDB.TabIndex = 14;
            this.radioACCDB.TabStop = true;
            this.radioACCDB.Text = ".accdb";
            this.radioACCDB.UseVisualStyleBackColor = true;
            this.radioACCDB.Click += new System.EventHandler(this.radioACCDB_Click);
            // 
            // radioCDR
            // 
            this.radioCDR.AutoSize = true;
            this.radioCDR.Location = new System.Drawing.Point(11, 63);
            this.radioCDR.Name = "radioCDR";
            this.radioCDR.Size = new System.Drawing.Size(53, 25);
            this.radioCDR.TabIndex = 13;
            this.radioCDR.TabStop = true;
            this.radioCDR.Text = ".cdr";
            this.radioCDR.UseVisualStyleBackColor = true;
            this.radioCDR.Click += new System.EventHandler(this.radioCDR_Click);
            // 
            // radioMSI
            // 
            this.radioMSI.AutoSize = true;
            this.radioMSI.Location = new System.Drawing.Point(386, 102);
            this.radioMSI.Name = "radioMSI";
            this.radioMSI.Size = new System.Drawing.Size(56, 25);
            this.radioMSI.TabIndex = 24;
            this.radioMSI.TabStop = true;
            this.radioMSI.Text = ".msi";
            this.radioMSI.UseVisualStyleBackColor = true;
            this.radioMSI.Click += new System.EventHandler(this.radioMSI_Click);
            // 
            // radioDLL
            // 
            this.radioDLL.AutoSize = true;
            this.radioDLL.Location = new System.Drawing.Point(311, 102);
            this.radioDLL.Name = "radioDLL";
            this.radioDLL.Size = new System.Drawing.Size(48, 25);
            this.radioDLL.TabIndex = 23;
            this.radioDLL.TabStop = true;
            this.radioDLL.Text = ".dll";
            this.radioDLL.UseVisualStyleBackColor = true;
            this.radioDLL.Click += new System.EventHandler(this.radioDLL_Click);
            // 
            // radioAVI
            // 
            this.radioAVI.AutoSize = true;
            this.radioAVI.Location = new System.Drawing.Point(86, 102);
            this.radioAVI.Name = "radioAVI";
            this.radioAVI.Size = new System.Drawing.Size(51, 25);
            this.radioAVI.TabIndex = 22;
            this.radioAVI.TabStop = true;
            this.radioAVI.Text = ".avi";
            this.radioAVI.UseVisualStyleBackColor = true;
            this.radioAVI.Click += new System.EventHandler(this.radioAVI_Click);
            // 
            // radioFLV
            // 
            this.radioFLV.AutoSize = true;
            this.radioFLV.Location = new System.Drawing.Point(161, 102);
            this.radioFLV.Name = "radioFLV";
            this.radioFLV.Size = new System.Drawing.Size(48, 25);
            this.radioFLV.TabIndex = 21;
            this.radioFLV.TabStop = true;
            this.radioFLV.Text = ".flv";
            this.radioFLV.UseVisualStyleBackColor = true;
            this.radioFLV.Click += new System.EventHandler(this.radioFLV_Click);
            // 
            // radioGIF
            // 
            this.radioGIF.AutoSize = true;
            this.radioGIF.Location = new System.Drawing.Point(236, 102);
            this.radioGIF.Name = "radioGIF";
            this.radioGIF.Size = new System.Drawing.Size(49, 25);
            this.radioGIF.TabIndex = 20;
            this.radioGIF.TabStop = true;
            this.radioGIF.Text = ".gif";
            this.radioGIF.UseVisualStyleBackColor = true;
            this.radioGIF.Click += new System.EventHandler(this.radioGIF_Click);
            // 
            // radioMPG
            // 
            this.radioMPG.AutoSize = true;
            this.radioMPG.Location = new System.Drawing.Point(11, 102);
            this.radioMPG.Name = "radioMPG";
            this.radioMPG.Size = new System.Drawing.Size(63, 25);
            this.radioMPG.TabIndex = 19;
            this.radioMPG.TabStop = true;
            this.radioMPG.Text = ".mpg";
            this.radioMPG.UseVisualStyleBackColor = true;
            this.radioMPG.Click += new System.EventHandler(this.radioMPG_Click);
            // 
            // checkDeleteFile
            // 
            this.checkDeleteFile.AutoSize = true;
            this.checkDeleteFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDeleteFile.Location = new System.Drawing.Point(13, 117);
            this.checkDeleteFile.Name = "checkDeleteFile";
            this.checkDeleteFile.Size = new System.Drawing.Size(109, 21);
            this.checkDeleteFile.TabIndex = 8;
            this.checkDeleteFile.Text = "Delete this file";
            this.checkDeleteFile.UseVisualStyleBackColor = true;
            this.checkDeleteFile.Click += new System.EventHandler(this.checkDeleteFile_Click);
            // 
            // txtExtension
            // 
            this.txtExtension.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtension.Location = new System.Drawing.Point(239, 133);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(87, 25);
            this.txtExtension.TabIndex = 9;
            this.txtExtension.Visible = false;
            this.txtExtension.TextChanged += new System.EventHandler(this.txtExtension_TextChanged);
            // 
            // radioOthers
            // 
            this.radioOthers.AutoSize = true;
            this.radioOthers.Location = new System.Drawing.Point(161, 133);
            this.radioOthers.Name = "radioOthers";
            this.radioOthers.Size = new System.Drawing.Size(75, 25);
            this.radioOthers.TabIndex = 25;
            this.radioOthers.TabStop = true;
            this.radioOthers.Text = "Others";
            this.radioOthers.UseVisualStyleBackColor = true;
            this.radioOthers.Click += new System.EventHandler(this.radioOthers_Click);
            // 
            // radioBMP
            // 
            this.radioBMP.AutoSize = true;
            this.radioBMP.Location = new System.Drawing.Point(11, 133);
            this.radioBMP.Name = "radioBMP";
            this.radioBMP.Size = new System.Drawing.Size(63, 25);
            this.radioBMP.TabIndex = 26;
            this.radioBMP.TabStop = true;
            this.radioBMP.Text = ".bmp";
            this.radioBMP.UseVisualStyleBackColor = true;
            this.radioBMP.Click += new System.EventHandler(this.radioBMP_Click);
            // 
            // radioTIFF
            // 
            this.radioTIFF.AutoSize = true;
            this.radioTIFF.Location = new System.Drawing.Point(87, 133);
            this.radioTIFF.Name = "radioTIFF";
            this.radioTIFF.Size = new System.Drawing.Size(50, 25);
            this.radioTIFF.TabIndex = 27;
            this.radioTIFF.TabStop = true;
            this.radioTIFF.Text = ".tiff";
            this.radioTIFF.UseVisualStyleBackColor = true;
            this.radioTIFF.Click += new System.EventHandler(this.radioTIFF_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = ".";
            // 
            // Secure_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 422);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkDeleteFile);
            this.Controls.Add(this.btnOutfutFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtFolderName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Secure_File";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure  File";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioDoc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOutfutFolder;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioTXT;
        private System.Windows.Forms.RadioButton radioPNG;
        private System.Windows.Forms.RadioButton radioJPEG;
        private System.Windows.Forms.RadioButton radioMSI;
        private System.Windows.Forms.RadioButton radioDLL;
        private System.Windows.Forms.RadioButton radioAVI;
        private System.Windows.Forms.RadioButton radioFLV;
        private System.Windows.Forms.RadioButton radioGIF;
        private System.Windows.Forms.RadioButton radioMPG;
        private System.Windows.Forms.RadioButton radioMP4;
        private System.Windows.Forms.RadioButton radioMP3;
        private System.Windows.Forms.RadioButton radioXLS;
        private System.Windows.Forms.RadioButton radioXLSX;
        private System.Windows.Forms.RadioButton radioACCDB;
        private System.Windows.Forms.RadioButton radioCDR;
        private System.Windows.Forms.RadioButton radioPPT;
        private System.Windows.Forms.RadioButton radioEXE;
        private System.Windows.Forms.CheckBox checkDeleteFile;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.RadioButton radioOthers;
        private System.Windows.Forms.RadioButton radioBMP;
        private System.Windows.Forms.RadioButton radioTIFF;
        private System.Windows.Forms.Label label5;
        }
    }

