namespace TextSearchTool
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.rdEffect = new System.Windows.Forms.RadioButton();
            this.rdMaterial = new System.Windows.Forms.RadioButton();
            this.rdPartical = new System.Windows.Forms.RadioButton();
            this.rdSkill = new System.Windows.Forms.RadioButton();
            this.lbChooseFile = new System.Windows.Forms.Label();
            this.txtDirect = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.rdNearly = new System.Windows.Forms.RadioButton();
            this.rdExactly = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbCheckFile = new System.Windows.Forms.Label();
            this.txtDirectCheckFile = new System.Windows.Forms.TextBox();
            this.btnOpenCheckFile = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lbFolder = new System.Windows.Forms.Label();
            this.txtDirectFolderSave = new System.Windows.Forms.TextBox();
            this.btnOpenFolderSave = new System.Windows.Forms.Button();
            this.grbExtension = new System.Windows.Forms.GroupBox();
            this.grbMode = new System.Windows.Forms.GroupBox();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.lbPercent = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tabSelect = new System.Windows.Forms.TabControl();
            this.tabMultiSel = new System.Windows.Forms.TabPage();
            this.tabSelectAll = new System.Windows.Forms.TabPage();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.lbSelectAll = new System.Windows.Forms.Label();
            this.txtSelectAll = new System.Windows.Forms.TextBox();
            this.lbHD = new System.Windows.Forms.Label();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.grbExtension.SuspendLayout();
            this.grbMode.SuspendLayout();
            this.tabSelect.SuspendLayout();
            this.tabMultiSel.SuspendLayout();
            this.tabSelectAll.SuspendLayout();
            this.grbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdEffect
            // 
            this.rdEffect.AutoSize = true;
            this.rdEffect.Checked = true;
            this.rdEffect.Location = new System.Drawing.Point(14, 25);
            this.rdEffect.Name = "rdEffect";
            this.rdEffect.Size = new System.Drawing.Size(64, 23);
            this.rdEffect.TabIndex = 5;
            this.rdEffect.TabStop = true;
            this.rdEffect.Text = ".effect";
            this.rdEffect.UseVisualStyleBackColor = true;
            // 
            // rdMaterial
            // 
            this.rdMaterial.AutoSize = true;
            this.rdMaterial.Location = new System.Drawing.Point(14, 54);
            this.rdMaterial.Name = "rdMaterial";
            this.rdMaterial.Size = new System.Drawing.Size(78, 23);
            this.rdMaterial.TabIndex = 5;
            this.rdMaterial.Text = ".material";
            this.rdMaterial.UseVisualStyleBackColor = true;
            // 
            // rdPartical
            // 
            this.rdPartical.AutoSize = true;
            this.rdPartical.Location = new System.Drawing.Point(14, 83);
            this.rdPartical.Name = "rdPartical";
            this.rdPartical.Size = new System.Drawing.Size(75, 23);
            this.rdPartical.TabIndex = 5;
            this.rdPartical.Text = ".particle";
            this.rdPartical.UseVisualStyleBackColor = true;
            // 
            // rdSkill
            // 
            this.rdSkill.AutoSize = true;
            this.rdSkill.Location = new System.Drawing.Point(14, 112);
            this.rdSkill.Name = "rdSkill";
            this.rdSkill.Size = new System.Drawing.Size(54, 23);
            this.rdSkill.TabIndex = 5;
            this.rdSkill.Text = ".skill";
            this.rdSkill.UseVisualStyleBackColor = true;
            // 
            // lbChooseFile
            // 
            this.lbChooseFile.AutoSize = true;
            this.lbChooseFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChooseFile.Location = new System.Drawing.Point(6, 3);
            this.lbChooseFile.Name = "lbChooseFile";
            this.lbChooseFile.Size = new System.Drawing.Size(210, 19);
            this.lbChooseFile.TabIndex = 1;
            this.lbChooseFile.Text = "Select your folder contains files";
            // 
            // txtDirect
            // 
            this.txtDirect.Location = new System.Drawing.Point(10, 28);
            this.txtDirect.Name = "txtDirect";
            this.txtDirect.Size = new System.Drawing.Size(337, 26);
            this.txtDirect.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(369, 28);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(76, 26);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.Text = "SELECT";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // rdNearly
            // 
            this.rdNearly.AutoSize = true;
            this.rdNearly.Checked = true;
            this.rdNearly.Location = new System.Drawing.Point(24, 25);
            this.rdNearly.Name = "rdNearly";
            this.rdNearly.Size = new System.Drawing.Size(68, 23);
            this.rdNearly.TabIndex = 5;
            this.rdNearly.TabStop = true;
            this.rdNearly.Text = "Nearly";
            this.rdNearly.UseVisualStyleBackColor = true;
            // 
            // rdExactly
            // 
            this.rdExactly.AutoSize = true;
            this.rdExactly.Location = new System.Drawing.Point(24, 47);
            this.rdExactly.Name = "rdExactly";
            this.rdExactly.Size = new System.Drawing.Size(71, 23);
            this.rdExactly.TabIndex = 5;
            this.rdExactly.Text = "Exactly";
            this.rdExactly.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(519, 257);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(166, 52);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "PROCESS";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbCheckFile
            // 
            this.lbCheckFile.AutoSize = true;
            this.lbCheckFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckFile.Location = new System.Drawing.Point(6, 60);
            this.lbCheckFile.Name = "lbCheckFile";
            this.lbCheckFile.Size = new System.Drawing.Size(249, 19);
            this.lbCheckFile.TabIndex = 1;
            this.lbCheckFile.Text = "Select your folder contains Check file";
            // 
            // txtDirectCheckFile
            // 
            this.txtDirectCheckFile.Location = new System.Drawing.Point(10, 85);
            this.txtDirectCheckFile.Name = "txtDirectCheckFile";
            this.txtDirectCheckFile.Size = new System.Drawing.Size(337, 26);
            this.txtDirectCheckFile.TabIndex = 1;
            // 
            // btnOpenCheckFile
            // 
            this.btnOpenCheckFile.Location = new System.Drawing.Point(369, 85);
            this.btnOpenCheckFile.Name = "btnOpenCheckFile";
            this.btnOpenCheckFile.Size = new System.Drawing.Size(76, 26);
            this.btnOpenCheckFile.TabIndex = 5;
            this.btnOpenCheckFile.Text = "SELECT";
            this.btnOpenCheckFile.UseVisualStyleBackColor = true;
            this.btnOpenCheckFile.Click += new System.EventHandler(this.btnOpenCheckFile_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(14, 25);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(436, 26);
            this.txtInput.TabIndex = 3;
            // 
            // lbFolder
            // 
            this.lbFolder.AutoSize = true;
            this.lbFolder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFolder.Location = new System.Drawing.Point(5, 119);
            this.lbFolder.Name = "lbFolder";
            this.lbFolder.Size = new System.Drawing.Size(139, 19);
            this.lbFolder.TabIndex = 1;
            this.lbFolder.Text = "Select folder to save";
            // 
            // txtDirectFolderSave
            // 
            this.txtDirectFolderSave.Location = new System.Drawing.Point(10, 143);
            this.txtDirectFolderSave.Name = "txtDirectFolderSave";
            this.txtDirectFolderSave.Size = new System.Drawing.Size(337, 26);
            this.txtDirectFolderSave.TabIndex = 2;
            // 
            // btnOpenFolderSave
            // 
            this.btnOpenFolderSave.Location = new System.Drawing.Point(369, 143);
            this.btnOpenFolderSave.Name = "btnOpenFolderSave";
            this.btnOpenFolderSave.Size = new System.Drawing.Size(76, 26);
            this.btnOpenFolderSave.TabIndex = 5;
            this.btnOpenFolderSave.Text = "SELECT";
            this.btnOpenFolderSave.UseVisualStyleBackColor = true;
            this.btnOpenFolderSave.Click += new System.EventHandler(this.btnOpenFolderSave_Click);
            // 
            // grbExtension
            // 
            this.grbExtension.Controls.Add(this.rdPartical);
            this.grbExtension.Controls.Add(this.rdEffect);
            this.grbExtension.Controls.Add(this.rdSkill);
            this.grbExtension.Controls.Add(this.rdMaterial);
            this.grbExtension.Location = new System.Drawing.Point(23, 13);
            this.grbExtension.Name = "grbExtension";
            this.grbExtension.Size = new System.Drawing.Size(152, 148);
            this.grbExtension.TabIndex = 7;
            this.grbExtension.TabStop = false;
            this.grbExtension.Text = "Select extension";
            // 
            // grbMode
            // 
            this.grbMode.Controls.Add(this.rdExactly);
            this.grbMode.Controls.Add(this.rdNearly);
            this.grbMode.Location = new System.Drawing.Point(23, 161);
            this.grbMode.Name = "grbMode";
            this.grbMode.Size = new System.Drawing.Size(152, 76);
            this.grbMode.TabIndex = 9;
            this.grbMode.TabStop = false;
            this.grbMode.Text = "Search mode";
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(23, 318);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(626, 10);
            this.prgBar.TabIndex = 10;
            // 
            // lbPercent
            // 
            this.lbPercent.AutoSize = true;
            this.lbPercent.Location = new System.Drawing.Point(655, 312);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(30, 19);
            this.lbPercent.TabIndex = 11;
            this.lbPercent.Text = "0%";
            // 
            // rtbLog
            // 
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLog.Location = new System.Drawing.Point(23, 348);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(662, 161);
            this.rtbLog.TabIndex = 13;
            this.rtbLog.Text = "";
            this.rtbLog.WordWrap = false;
            // 
            // tabSelect
            // 
            this.tabSelect.Controls.Add(this.tabMultiSel);
            this.tabSelect.Controls.Add(this.tabSelectAll);
            this.tabSelect.Location = new System.Drawing.Point(198, 22);
            this.tabSelect.Name = "tabSelect";
            this.tabSelect.SelectedIndex = 0;
            this.tabSelect.Size = new System.Drawing.Size(487, 215);
            this.tabSelect.TabIndex = 14;
            // 
            // tabMultiSel
            // 
            this.tabMultiSel.BackColor = System.Drawing.SystemColors.Control;
            this.tabMultiSel.Controls.Add(this.txtDirectFolderSave);
            this.tabMultiSel.Controls.Add(this.btnOpenFile);
            this.tabMultiSel.Controls.Add(this.lbFolder);
            this.tabMultiSel.Controls.Add(this.txtDirectCheckFile);
            this.tabMultiSel.Controls.Add(this.lbChooseFile);
            this.tabMultiSel.Controls.Add(this.lbCheckFile);
            this.tabMultiSel.Controls.Add(this.btnOpenCheckFile);
            this.tabMultiSel.Controls.Add(this.txtDirect);
            this.tabMultiSel.Controls.Add(this.btnOpenFolderSave);
            this.tabMultiSel.Location = new System.Drawing.Point(4, 28);
            this.tabMultiSel.Name = "tabMultiSel";
            this.tabMultiSel.Padding = new System.Windows.Forms.Padding(3);
            this.tabMultiSel.Size = new System.Drawing.Size(479, 183);
            this.tabMultiSel.TabIndex = 0;
            this.tabMultiSel.Text = "Select 3 folders";
            // 
            // tabSelectAll
            // 
            this.tabSelectAll.BackColor = System.Drawing.SystemColors.Control;
            this.tabSelectAll.Controls.Add(this.btnSelectAll);
            this.tabSelectAll.Controls.Add(this.lbSelectAll);
            this.tabSelectAll.Controls.Add(this.txtSelectAll);
            this.tabSelectAll.Controls.Add(this.lbHD);
            this.tabSelectAll.Location = new System.Drawing.Point(4, 28);
            this.tabSelectAll.Name = "tabSelectAll";
            this.tabSelectAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelectAll.Size = new System.Drawing.Size(463, 181);
            this.tabSelectAll.TabIndex = 1;
            this.tabSelectAll.Text = "Select all";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(366, 94);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(76, 26);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "SELECT";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // lbSelectAll
            // 
            this.lbSelectAll.AutoSize = true;
            this.lbSelectAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectAll.Location = new System.Drawing.Point(6, 63);
            this.lbSelectAll.Name = "lbSelectAll";
            this.lbSelectAll.Size = new System.Drawing.Size(182, 19);
            this.lbSelectAll.TabIndex = 2;
            this.lbSelectAll.Text = "Select your file contains all";
            // 
            // txtSelectAll
            // 
            this.txtSelectAll.Location = new System.Drawing.Point(10, 94);
            this.txtSelectAll.Name = "txtSelectAll";
            this.txtSelectAll.Size = new System.Drawing.Size(337, 26);
            this.txtSelectAll.TabIndex = 1;
            // 
            // lbHD
            // 
            this.lbHD.AutoSize = true;
            this.lbHD.Location = new System.Drawing.Point(6, 12);
            this.lbHD.Name = "lbHD";
            this.lbHD.Size = new System.Drawing.Size(283, 19);
            this.lbHD.TabIndex = 0;
            this.lbHD.Text = "Make sure the folder contains In, Check, Out";
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.txtInput);
            this.grbInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInput.Location = new System.Drawing.Point(23, 248);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(490, 61);
            this.grbInput.TabIndex = 15;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Type your word (s)";
            // 
            // resetBtn
            // 
            this.resetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetBtn.BackgroundImage")));
            this.resetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetBtn.Location = new System.Drawing.Point(647, 12);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(32, 32);
            this.resetBtn.TabIndex = 16;
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(718, 536);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.tabSelect);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.lbPercent);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.grbMode);
            this.Controls.Add(this.grbExtension);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbExtension.ResumeLayout(false);
            this.grbExtension.PerformLayout();
            this.grbMode.ResumeLayout(false);
            this.grbMode.PerformLayout();
            this.tabSelect.ResumeLayout(false);
            this.tabMultiSel.ResumeLayout(false);
            this.tabMultiSel.PerformLayout();
            this.tabSelectAll.ResumeLayout(false);
            this.tabSelectAll.PerformLayout();
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdEffect;
        private System.Windows.Forms.RadioButton rdMaterial;
        private System.Windows.Forms.RadioButton rdPartical;
        private System.Windows.Forms.RadioButton rdSkill;
        private System.Windows.Forms.Label lbChooseFile;
        private System.Windows.Forms.TextBox txtDirect;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.RadioButton rdNearly;
        private System.Windows.Forms.RadioButton rdExactly;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbCheckFile;
        private System.Windows.Forms.TextBox txtDirectCheckFile;
        private System.Windows.Forms.Button btnOpenCheckFile;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lbFolder;
        private System.Windows.Forms.TextBox txtDirectFolderSave;
        private System.Windows.Forms.Button btnOpenFolderSave;
        private System.Windows.Forms.GroupBox grbExtension;
        private System.Windows.Forms.GroupBox grbMode;
        private System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.TabControl tabSelect;
        private System.Windows.Forms.TabPage tabMultiSel;
        private System.Windows.Forms.TabPage tabSelectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Label lbSelectAll;
        private System.Windows.Forms.TextBox txtSelectAll;
        private System.Windows.Forms.Label lbHD;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.Button resetBtn;
    }
}

