using System;
using System.IO;
using System.Windows.Forms;
using FileEncrypt;

namespace SecureFile
    {
    public partial class Secure_File : Form
        {
        public Secure_File()
            {
            InitializeComponent();
           
            }
        FileInfo info;
        string decrypExtension = null;
        bool deleteFile = false;
        private DataEncryptor dataCryptor = new DataEncryptor();
    private void btnSelectFile_Click(object sender , EventArgs e)
            {
            OpenFileDialog fileDialog = new OpenFileDialog(); 
            fileDialog.RestoreDirectory = true;
            //fileDialog.InitialDirectory = @"C:\";
            fileDialog.Title = "Select File";
            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.FilterIndex = 2;
            fileDialog.DefaultExt = "txt";
            fileDialog.CheckFileExists = false ;
            fileDialog.ValidateNames = false;
            fileDialog.CheckPathExists = true;
            fileDialog.Multiselect = false;
           
            if (fileDialog.ShowDialog() ==DialogResult.OK)
                {
                     info = new FileInfo(fileDialog.FileName); 
                dataCryptor.inPutFilePath(fileDialog.FileName);
                dataCryptor.FileType(info.Extension);
                txtFilePath.Text = info.Name;
                dataCryptor.FileType( info.Name.Substring(0,info.Name.Length-info.Extension.Length),info.Extension);
                label5.Text = info.Extension;
                }
            
            }

        private void btnDecrypt_Click(object sender , EventArgs e)
        {
            try
                {
                //to decrypt the file
                if (string.IsNullOrEmpty(txtFolderName.Text))
                    {
                    throw new Exception("Select output folder");
                    }
                if (string.IsNullOrEmpty(txtFilePath.Text))
                    {
                    throw new Exception("Select File to decrypt");
                    }
                if (string.IsNullOrEmpty(decrypExtension))
                    {
                    throw new Exception("Select file decryption extention");
                    }
                 
                dataCryptor.FileDetails(info.Name.Substring(0 , info.Name.Length - info.Extension.Length) , info.Extension , decrypExtension);
                dataCryptor.isDeletePlainFile(deleteFile);
                dataCryptor.DecryptFile();
                MessageBox.Show("Decryption Successfull","Completed");
                checkDeleteFile.Checked = false;
                txtFilePath.Clear();
                }
            catch(Exception ex)
                {
                MessageBox.Show(ex.Message , "Decryption Error");
                }
            }

        private void btnOutfutFolder_Click(object sender , EventArgs e)
            {
                OpenFileDialog folderBrowser = new OpenFileDialog();
            // Set validate names and check file exists to false otherwise windows will
            // not let you select "Folder Selection."
            folderBrowser.RestoreDirectory = true;
            folderBrowser.ValidateNames = false;
                folderBrowser.CheckFileExists = false;
                folderBrowser.CheckPathExists = true;
                // Always default to Folder Selection.
                folderBrowser.FileName = "Folder Selection.";
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    dataCryptor.outPutFilePath(Path.GetDirectoryName(folderBrowser.FileName));
                    string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                    txtFolderName.Text = folderPath;
                    // ...
                }
            }

        private void btnEncrypt_Click(object sender , EventArgs e)
            {
                try
                {
                if (string.IsNullOrEmpty(txtFolderName.Text))
                    {
                    throw new Exception("Select output folder");
                    }
                if (string.IsNullOrEmpty(txtFilePath.Text))
                    {
                    throw new Exception("Select File to encrypt");
                    }
                    dataCryptor.isDeletePlainFile(deleteFile);
                    dataCryptor.EncryptFile();
                    MessageBox.Show("Encryption Successful","Completed");
                checkDeleteFile.Checked = false;
                txtFilePath.Clear();
                }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message, "Encryption Error");
                }
            }

        private void RadioDoc_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = RadioDoc.Text;
            }

        private void radioTXT_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioTXT.Text;
            }

        private void radioPNG_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioPNG.Text;
            }

        private void radioJPEG_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioJPEG.Text;
            }

        private void radioEXE_CheckedChanged(object sender , EventArgs e)
            {

            }

        private void radioEXE_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioEXE.Text;
            }

        private void checkDeleteFile_Click(object sender , EventArgs e)
            {
            if(checkDeleteFile.Checked==true)
                {
                deleteFile = true;
                }
            else
                {
                deleteFile = false;
                }
            }

        private void radioPPT_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioPPT.Text;
            }

        private void radioCDR_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioCDR.Text;
            }

        private void radioXLS_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioXLS.Text;
            
            }

       
        private void radioOthers_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = true;
            decrypExtension = txtExtension.Text;
            }

        private void radioXLSX_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioXLSX.Text;
            }

        private void radioACCDB_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioACCDB.Text;
            }

        private void radioMP3_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioMP3.Text;
            }

        private void radioMP4_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioMP4.Text;
            }

        private void radioMPG_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioMPG.Text;
            }

        private void radioAVI_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioAVI.Text;
            }

        private void radioFLV_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioFLV.Text;
            }

        private void radioGIF_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioGIF.Text;
            }

        private void radioDLL_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioDLL.Text;
            }

        private void radioMSI_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioMSI.Text;
            }

        private void radioBMP_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioBMP.Text;
            }

        private void radioTIFF_Click(object sender , EventArgs e)
            {
            txtExtension.Visible = false;
            txtExtension.Clear();
            decrypExtension = radioTIFF.Text;
            }

        private void txtExtension_TextChanged(object sender , EventArgs e)
            {
            decrypExtension = txtExtension.Text;
            }
        }
    }
