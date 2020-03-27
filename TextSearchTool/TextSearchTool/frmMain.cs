using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextSearchTool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            rdEffect.Checked = true;
            rdNearly.Checked = true;
            prgBar.Minimum = 0;
            prgBar.Maximum = 100;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txtDirect.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnOpenCheckFile_Click(object sender, EventArgs e)
        {
            string fileExtension = "";
            if (rdEffect.Checked) fileExtension = "*.effect";
            if (rdMaterial.Checked) fileExtension = "*.material";
            if (rdPartical.Checked) fileExtension = "*.partical";
            if (rdSkill.Checked) fileExtension = "*.skill";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|" + fileExtension;
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txtDirectCheckFile.Text = openFileDialog.FileName;
            }
        }

        private void btnOpenFolderSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txtDirectFolderSave.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] words = txtInput.Text.Split('|');
            updateProcInfo(5, "5%", "[Loading text input...]");
            bool existFolderInput = Directory.Exists(txtDirect.Text);
            bool exitsFileCheck = File.Exists(txtDirectCheckFile.Text);
            if (existFolderInput)
            {
                if (exitsFileCheck)
                {
                    if (!string.IsNullOrWhiteSpace(txtInput.Text))
                    {
                        string fileExtension = "";
                        if (rdEffect.Checked) fileExtension = "effect";
                        if (rdMaterial.Checked) fileExtension = "material";
                        if (rdPartical.Checked) fileExtension = "partical";
                        if (rdSkill.Checked) fileExtension = "skill";
                        List<StreamReader> fileInputs = new List<StreamReader>();
                        
                        StreamWriter fileOut = null;
                        if (File.Exists(txtDirectFolderSave.Text + @"\out." + fileExtension))
                            fileOut = new StreamWriter(txtDirectFolderSave.Text + @"\out." + fileExtension);
                        else
                            fileOut = File.CreateText(txtDirectFolderSave.Text + @"\out." + fileExtension);
                        StreamWriter fileLog = null;
                        if (File.Exists(txtDirectFolderSave.Text + @"\log." + fileExtension))
                            fileLog = new StreamWriter(txtDirectFolderSave.Text + @"\log." + fileExtension);
                        else
                            fileLog = File.CreateText(txtDirectFolderSave.Text + @"\log." + fileExtension);
                        string[] nameFiles = Directory.GetFiles(txtDirect.Text);
                        for (int i = 0; i < nameFiles.Length; i++)
                        {
                            if (getExtension(nameFiles[i]) == fileExtension)
                            {
                                fileInputs.Add(new StreamReader(nameFiles[i]));
                            }
                        }
                        for (int i = 0; i < fileInputs.Count; i++)
                        {
                            StreamReader fileCheck = new StreamReader(txtDirectCheckFile.Text);
                            processToFile(fileInputs[i], fileOut, fileCheck, fileLog, words);
                        }
                        fileOut.Close();
                        fileLog.Close();
                    }
                    else
                    {
                        MessageBox.Show("Word (s) is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lbProcessing.Text = "[Fail]";
                    }
                }
                else
                {
                    MessageBox.Show("The Check file doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbProcessing.Text = "[Fail]";
                }
            }
            else
            {
                MessageBox.Show("File need to search doesn't exit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbProcessing.Text = "[Fail]";
            }
        }

        private void processToFile(StreamReader fileInput, StreamWriter fileOutput, StreamReader fileCheck, StreamWriter fileLog, string[] wordInput)
        {
            char[] div = { ' ', '\n' };
            string[] textFromFileInput = fileInput.ReadToEnd().Split(div);
            string[] textFromFileCheck = fileCheck.ReadToEnd().Split(div);
            // check in file need check
            lbProcessing.Text = "[Loading file input...]";
            List<string> result = new List<string>();
            for (int i = 0; i < textFromFileInput.Length; i++)
            {
                for (int j = 0; j < wordInput.Length; j++)
                {
                    if (rdNearly.Checked)
                    {
                        if (textFromFileInput[i].Contains(wordInput[j]))
                        {
                            result.Add(textFromFileInput[i]);
                        }
                    }
                    if (rdExactly.Checked)
                    {
                        if (textFromFileInput[i] == wordInput[j])
                        {
                            result.Add(textFromFileInput[i]);
                        }
                    }
                }
            }
            updateProcInfo(50, "10%", "[Loading Check file...]");
            // check in file check
            List<string> logFile = new List<string>();
            for (int i = 0; i < textFromFileCheck.Length; i++)
            {
                for (int j = 0; j < result.Count; j++)
                {
                    if (result[j] == textFromFileCheck[i])
                    {
                        logFile.Add(result[j]);
                        result.RemoveAt(j);
                        j--;
                    }
                }
            }
            // export to file out
            updateProcInfo(80, "80%", "[Exporting file out...]");
            for (int i = 0; i < result.Count; i++)
            {
                fileOutput.WriteLine(result[i]);
            }
            // export to file log
            updateProcInfo(90, "90%", "[Exporting file log...]");
            for (int i = 0; i < logFile.Count; i++)
            {
                fileLog.WriteLine(logFile[i]);
            }
            updateProcInfo(100, "100%", "[Done]");
            fileCheck.Close();
            fileInput.Close();
        }

        private string getExtension(string fileName)
        {
            int i = fileName.Length - 1;
            string extension = "";
            while (i >= 0 && fileName[i] != '.')
            {
                extension = fileName[i] + extension;
                i--;
            }
            return extension;
        }

        private void updateProcInfo(int value, string percent, string processing)
        {
            prgBar.Value = value;
            lbPercent.Text = percent;
            lbProcessing.Text = processing;
        }
    }
}
