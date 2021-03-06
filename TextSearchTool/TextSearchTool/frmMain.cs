﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private int currLine = 0;
        private string fileExtension = "";
        private List<int> wordsFoundButExist = new List<int>();
        private List<int> wordsNotFound = new List<int>();
        private List<int> wordsFound = new List<int>();
        private List<string> result = new List<string>();
        private List<string> logFile = new List<string>();
        private List<string> outFileContainStruct = new List<string>();
        private List<string> allStructFromInput = new List<string>();

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
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txtDirectCheckFile.Text = folderBrowserDialog.SelectedPath;
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
            rtbLog.Focus();
            wordsFound.Clear();
            wordsFoundButExist.Clear();
            wordsNotFound.Clear();
            result.Clear();
            logFile.Clear();
            outFileContainStruct.Clear();
            allStructFromInput.Clear();
            string[] words = txtInput.Text.Split('|');
            updateProcInfo(5, "[Loading text input...]");
            rtbLog.Text = "[Loading text input...]";
            currLine = 1;
            string directOfInput = "", directOfCheck = "", directOfOut = "";
            if (tabSelect.SelectedTab == tabMultiSel)
            {
                directOfInput = txtDirect.Text;
                directOfCheck = txtDirectCheckFile.Text;
                directOfOut = txtDirectFolderSave.Text;
            }
            else
            {
                directOfInput = txtSelectAll.Text + @"\In";
                directOfCheck = txtSelectAll.Text + @"\Check";
                directOfOut = txtSelectAll.Text + @"\Out";
            }
            bool existFolderInput = Directory.Exists(directOfInput);
            bool exitsFolderCheck = Directory.Exists(directOfCheck);
            if (existFolderInput)
            {
                if (exitsFolderCheck)
                {
                    if (!string.IsNullOrWhiteSpace(txtInput.Text))
                    {
                        fileExtension = "";
                        if (rdEffect.Checked) fileExtension = "effect";
                        if (rdMaterial.Checked) fileExtension = "material";
                        if (rdPartical.Checked) fileExtension = "particle";
                        if (rdSkill.Checked) fileExtension = "skill";
                        List<StreamReader> fileInputs = new List<StreamReader>();
                        List<StreamReader> fileChecks = new List<StreamReader>();
                        
                        StreamWriter fileOut = null;
                        if (File.Exists(directOfOut + @"\out." + fileExtension))
                            fileOut = new StreamWriter(directOfOut + @"\out." + fileExtension);
                        else
                            fileOut = File.CreateText(directOfOut + @"\out." + fileExtension);
                        StreamWriter fileLog = null;
                        if (File.Exists(directOfOut + @"\log." + fileExtension))
                            fileLog = new StreamWriter(directOfOut + @"\log." + fileExtension);
                        else
                            fileLog = File.CreateText(directOfOut + @"\log." + fileExtension);
                        StreamWriter fileNewIn = null;
                        if (File.Exists(directOfOut + @"\newIn." + fileExtension))
                            fileNewIn = new StreamWriter(directOfOut + @"\newIn." + fileExtension);
                        else
                            fileNewIn = File.CreateText(directOfOut + @"\newIn." + fileExtension);
                        string[] nameFilesInput = Directory.GetFiles(directOfInput);
                        string[] nameFilesCheck = Directory.GetFiles(directOfCheck);
                        for (int i = 0; i < nameFilesInput.Length; i++)
                        {
                            if (getExtension(nameFilesInput[i]) == fileExtension)
                            {
                                fileInputs.Add(new StreamReader(nameFilesInput[i], Encoding.GetEncoding(936)));
                            }
                        }
                        string textOnAllFileChecks = "";
                        for (int i = 0; i < nameFilesCheck.Length; i++)
                        {
                            if (getExtension(nameFilesCheck[i]) == fileExtension)
                            {
                                fileChecks.Add(new StreamReader(nameFilesCheck[i], Encoding.GetEncoding(936)));
                                textOnAllFileChecks += (readFromFile(fileChecks[fileChecks.Count - 1], fileExtension, true) + "|");
                            }
                        }
                        textOnAllFileChecks = textOnAllFileChecks.Remove(textOnAllFileChecks.Length - 1);
                        for (int i = 0; i < fileInputs.Count; i++)
                        {
                            processToFile(fileInputs[i], i, textOnAllFileChecks, words);
                        }
                        makeColorWords();
                        if (result.Count > 0 || logFile.Count > 0)
                        {
                            exportToFile(fileOut, fileLog, fileNewIn);
                            DialogResult dlr = MessageBox.Show("Do you want to open file out?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dlr == DialogResult.Yes)
                            {
                                ProcessStartInfo process = new ProcessStartInfo(directOfOut);
                                Process.Start(process);
                            }
                        }
                        else updateProcInfo(100, "\n[Done]");
                        fileOut.Close();
                        fileLog.Close();
                        fileNewIn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Word (s) is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The Check file doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File need to search doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void processToFile(StreamReader fileInput, int fileIndex , string textOnAllFileCheck, string[] wordInput)
        {
            string[] textFromFileInput = readFromFile(fileInput, fileExtension, false).Split('|');
            string[] textFromFileCheck = textOnAllFileCheck.Split('|');
            // check in file need check
            rtbLog.Text += "\n[Loading file input...] index = [" + fileIndex.ToString() + "]";
            currLine++;
            rtbLog.Text += "\nFound:";
            currLine++;
            for (int i = 0; i < wordInput.Length; i++)
            {
                rtbLog.Text += "\n\t[" + wordInput[i] + "]";
                currLine++;
                int currFound = result.Count;
                for (int j = 0; j < textFromFileInput.Length; j++)
                {
                    if (rdNearly.Checked)
                    {
                        if (textFromFileInput[j].Contains(wordInput[i]))
                        {
                            outFileContainStruct.Add(allStructFromInput[j]);
                            result.Add(textFromFileInput[j]);
                            rtbLog.Text += ("\n\t\t" + textFromFileInput[j]);
                            currLine++;
                            wordsFound.Add(currLine);
                        }
                    }
                    if (rdExactly.Checked)
                    {
                        if (textFromFileInput[j] == wordInput[i])
                        {
                            outFileContainStruct.Add(allStructFromInput[j]);
                            result.Add(textFromFileInput[j]);
                            rtbLog.Text += ("\n\t\t" + textFromFileInput[j]);
                            currLine++;
                            wordsFound.Add(currLine);
                        }
                    }
                }
                if (result.Count == currFound) wordsNotFound.Add(currLine);
            }
            updateProcInfo(50, "\n[Loading Check file...]");
            // check in file check
            for (int i = 0; i < textFromFileCheck.Length; i++)
            {
                for (int j = 0; j < result.Count; j++)
                {
                    if (result[j] == textFromFileCheck[i])
                    {
                        outFileContainStruct.RemoveAt(j);
                        logFile.Add(result[j]);
                        result.RemoveAt(j);
                        wordsFoundButExist.Add(wordsFound[j]);
                        wordsFound.RemoveAt(j);
                        j--;
                    }
                }
            }
            fileInput.Close();
        }

        private string readFromFile(StreamReader streamReader, string extension, bool isFileCheck)
        {
            string textOnFile = "";
            string curr = "";
            while ((curr = streamReader.ReadLine()) != null)
            {
                if (curr.StartsWith(extension))
                {
                    int indexOfDoubleDot = curr.IndexOf(':');
                    while (indexOfDoubleDot > 0 && curr[indexOfDoubleDot - 1] == ' ')
                        indexOfDoubleDot--;
                    int start = extension.Length + 1;
                    while (curr[start] == ' ')
                        start++;
                    if (indexOfDoubleDot > 0)
                    {
                        textOnFile += (curr.Substring(start, indexOfDoubleDot - start) + "|");
                    }
                    else
                        textOnFile += (curr.Substring(extension.Length + 1) + "|");
                    if (!isFileCheck) allStructFromInput.Add(curr + "\n");
                }
                else if (extension == "particle")
                {
                    if ((!curr.StartsWith("{")) && (!curr.StartsWith("}")) && (!curr.StartsWith("\t")) && (curr != ""))
                    {
                        textOnFile += (curr + "|");
                        if (!isFileCheck) allStructFromInput.Add(curr + "\n");
                    }
                    else
                    {
                        if (!isFileCheck && allStructFromInput.Count > 0)
                            allStructFromInput[allStructFromInput.Count - 1] += (curr + "\n");
                    }
                }
                else
                {
                    if (!isFileCheck && allStructFromInput.Count > 0)
                    allStructFromInput[allStructFromInput.Count - 1] += (curr + "\n");
                }
            }
            return textOnFile.Remove(textOnFile.Length - 1);
        }

        private void exportToFile(StreamWriter fileOut, StreamWriter fileLog, StreamWriter fileNewIn)
        {
            // export to file out
            updateProcInfo(80, "\n[Exporting file out...]");
            for (int i = 0; i < outFileContainStruct.Count; i++)
            {
                fileOut.WriteLine(outFileContainStruct[i]);
            }
            // export to file log
            updateProcInfo(90, "\n[Exporting file log...]");
            for (int i = 0; i < logFile.Count; i++)
            {
                fileLog.WriteLine(logFile[i]);
            }
            // export to file newIn
            for (int i = 0; i < allStructFromInput.Count; i++)
            {
                bool flag = true;
                for (int j = 0; j < outFileContainStruct.Count; j++)
                {
                    if (allStructFromInput[i] == outFileContainStruct[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) fileNewIn.WriteLine(allStructFromInput[i]);
            }
            updateProcInfo(100, "\n[Done]");
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

        private void updateProcInfo(int value, string processing)
        {
            prgBar.Value = value;
            lbPercent.Text = value.ToString() + "%";
            rtbLog.AppendText(processing);
            currLine++;
        }

        private void makeColorWords()
        {
            for (int i = 0; i < wordsNotFound.Count; i++)
            {
                int begin = rtbLog.GetFirstCharIndexFromLine(wordsNotFound[i] - 1);
                string line = rtbLog.Lines[wordsNotFound[i] - 1];
                rtbLog.Select(begin, line.Length);
                rtbLog.SelectionColor = Color.Red;
            }
            for (int i = 0; i < wordsFoundButExist.Count; i++)
            {
                int begin = rtbLog.GetFirstCharIndexFromLine(wordsFoundButExist[i] - 1);
                string line = rtbLog.Lines[wordsFoundButExist[i] - 1];
                rtbLog.Select(begin, line.Length);
                rtbLog.SelectionColor = Color.Orange;
            }
            for (int i = 0; i < wordsFound.Count; i++)
            {
                int begin = rtbLog.GetFirstCharIndexFromLine(wordsFound[i] - 1);
                string line = rtbLog.Lines[wordsFound[i] - 1];
                rtbLog.Select(begin, line.Length);
                rtbLog.SelectionColor = Color.Green;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txtSelectAll.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            currLine = 0;
            fileExtension = "";
            wordsFoundButExist.Clear();
            wordsNotFound.Clear();
            wordsFound.Clear();
            result.Clear();
            logFile.Clear();
            outFileContainStruct.Clear();
            allStructFromInput.Clear();

            txtDirect.Text = "";
            txtDirectCheckFile.Text = "";
            txtDirectFolderSave.Text = "";
            txtSelectAll.Text = "";
            txtInput.Text = "";

            prgBar.Value = 0;
            lbPercent.Text = "0%";

            rtbLog.Text = "";
        }
    }
}
