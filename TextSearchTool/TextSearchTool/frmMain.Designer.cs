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
            this.lbInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lbFolder = new System.Windows.Forms.Label();
            this.txtDirectFolderSave = new System.Windows.Forms.TextBox();
            this.btnOpenFolderSave = new System.Windows.Forms.Button();
            this.grbExtension = new System.Windows.Forms.GroupBox();
            this.grbFileAndFolder = new System.Windows.Forms.GroupBox();
            this.grbMode = new System.Windows.Forms.GroupBox();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.lbPercent = new System.Windows.Forms.Label();
            this.lbProcessing = new System.Windows.Forms.Label();
            this.grbExtension.SuspendLayout();
            this.grbFileAndFolder.SuspendLayout();
            this.grbMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdEffect
            // 
            this.rdEffect.AutoSize = true;
            this.rdEffect.Checked = true;
            this.rdEffect.Location = new System.Drawing.Point(4, 25);
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
            this.rdMaterial.Location = new System.Drawing.Point(123, 25);
            this.rdMaterial.Name = "rdMaterial";
            this.rdMaterial.Size = new System.Drawing.Size(78, 23);
            this.rdMaterial.TabIndex = 5;
            this.rdMaterial.Text = ".material";
            this.rdMaterial.UseVisualStyleBackColor = true;
            // 
            // rdPartical
            // 
            this.rdPartical.AutoSize = true;
            this.rdPartical.Location = new System.Drawing.Point(244, 25);
            this.rdPartical.Name = "rdPartical";
            this.rdPartical.Size = new System.Drawing.Size(75, 23);
            this.rdPartical.TabIndex = 5;
            this.rdPartical.Text = ".partical";
            this.rdPartical.UseVisualStyleBackColor = true;
            // 
            // rdSkill
            // 
            this.rdSkill.AutoSize = true;
            this.rdSkill.Location = new System.Drawing.Point(360, 25);
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
            this.lbChooseFile.Location = new System.Drawing.Point(7, 21);
            this.lbChooseFile.Name = "lbChooseFile";
            this.lbChooseFile.Size = new System.Drawing.Size(206, 19);
            this.lbChooseFile.TabIndex = 1;
            this.lbChooseFile.Text = "Open your folder contains files";
            // 
            // txtDirect
            // 
            this.txtDirect.Location = new System.Drawing.Point(11, 46);
            this.txtDirect.Name = "txtDirect";
            this.txtDirect.Size = new System.Drawing.Size(337, 26);
            this.txtDirect.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(370, 45);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(76, 26);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.Text = "OPEN";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // rdNearly
            // 
            this.rdNearly.AutoSize = true;
            this.rdNearly.Checked = true;
            this.rdNearly.Location = new System.Drawing.Point(84, 25);
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
            this.rdExactly.Location = new System.Drawing.Point(310, 25);
            this.rdExactly.Name = "rdExactly";
            this.rdExactly.Size = new System.Drawing.Size(71, 23);
            this.rdExactly.TabIndex = 5;
            this.rdExactly.Text = "Exactly";
            this.rdExactly.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(211, 445);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 40);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "PROCESS";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbCheckFile
            // 
            this.lbCheckFile.AutoSize = true;
            this.lbCheckFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckFile.Location = new System.Drawing.Point(7, 81);
            this.lbCheckFile.Name = "lbCheckFile";
            this.lbCheckFile.Size = new System.Drawing.Size(145, 19);
            this.lbCheckFile.TabIndex = 1;
            this.lbCheckFile.Text = "Open your Check file";
            // 
            // txtDirectCheckFile
            // 
            this.txtDirectCheckFile.Location = new System.Drawing.Point(11, 106);
            this.txtDirectCheckFile.Name = "txtDirectCheckFile";
            this.txtDirectCheckFile.Size = new System.Drawing.Size(337, 26);
            this.txtDirectCheckFile.TabIndex = 1;
            // 
            // btnOpenCheckFile
            // 
            this.btnOpenCheckFile.Location = new System.Drawing.Point(370, 106);
            this.btnOpenCheckFile.Name = "btnOpenCheckFile";
            this.btnOpenCheckFile.Size = new System.Drawing.Size(76, 26);
            this.btnOpenCheckFile.TabIndex = 5;
            this.btnOpenCheckFile.Text = "OPEN";
            this.btnOpenCheckFile.UseVisualStyleBackColor = true;
            this.btnOpenCheckFile.Click += new System.EventHandler(this.btnOpenCheckFile_Click);
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInput.Location = new System.Drawing.Point(6, 205);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(128, 19);
            this.lbInput.TabIndex = 1;
            this.lbInput.Text = "Type your word (s)";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(11, 232);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(337, 26);
            this.txtInput.TabIndex = 3;
            // 
            // lbFolder
            // 
            this.lbFolder.AutoSize = true;
            this.lbFolder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFolder.Location = new System.Drawing.Point(6, 142);
            this.lbFolder.Name = "lbFolder";
            this.lbFolder.Size = new System.Drawing.Size(135, 19);
            this.lbFolder.TabIndex = 1;
            this.lbFolder.Text = "Open folder to save";
            // 
            // txtDirectFolderSave
            // 
            this.txtDirectFolderSave.Location = new System.Drawing.Point(11, 168);
            this.txtDirectFolderSave.Name = "txtDirectFolderSave";
            this.txtDirectFolderSave.Size = new System.Drawing.Size(337, 26);
            this.txtDirectFolderSave.TabIndex = 2;
            // 
            // btnOpenFolderSave
            // 
            this.btnOpenFolderSave.Location = new System.Drawing.Point(370, 168);
            this.btnOpenFolderSave.Name = "btnOpenFolderSave";
            this.btnOpenFolderSave.Size = new System.Drawing.Size(76, 26);
            this.btnOpenFolderSave.TabIndex = 5;
            this.btnOpenFolderSave.Text = "OPEN";
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
            this.grbExtension.Size = new System.Drawing.Size(467, 59);
            this.grbExtension.TabIndex = 7;
            this.grbExtension.TabStop = false;
            this.grbExtension.Text = "Select extension of your file";
            // 
            // grbFileAndFolder
            // 
            this.grbFileAndFolder.Controls.Add(this.btnOpenFile);
            this.grbFileAndFolder.Controls.Add(this.lbChooseFile);
            this.grbFileAndFolder.Controls.Add(this.txtDirect);
            this.grbFileAndFolder.Controls.Add(this.txtInput);
            this.grbFileAndFolder.Controls.Add(this.btnOpenFolderSave);
            this.grbFileAndFolder.Controls.Add(this.lbInput);
            this.grbFileAndFolder.Controls.Add(this.btnOpenCheckFile);
            this.grbFileAndFolder.Controls.Add(this.lbCheckFile);
            this.grbFileAndFolder.Controls.Add(this.txtDirectFolderSave);
            this.grbFileAndFolder.Controls.Add(this.txtDirectCheckFile);
            this.grbFileAndFolder.Controls.Add(this.lbFolder);
            this.grbFileAndFolder.Location = new System.Drawing.Point(23, 78);
            this.grbFileAndFolder.Name = "grbFileAndFolder";
            this.grbFileAndFolder.Size = new System.Drawing.Size(467, 268);
            this.grbFileAndFolder.TabIndex = 0;
            this.grbFileAndFolder.TabStop = false;
            this.grbFileAndFolder.Text = "File (s) and folder (s)";
            // 
            // grbMode
            // 
            this.grbMode.Controls.Add(this.rdExactly);
            this.grbMode.Controls.Add(this.rdNearly);
            this.grbMode.Location = new System.Drawing.Point(23, 352);
            this.grbMode.Name = "grbMode";
            this.grbMode.Size = new System.Drawing.Size(467, 76);
            this.grbMode.TabIndex = 9;
            this.grbMode.TabStop = false;
            this.grbMode.Text = "Choose mode";
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(23, 505);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(125, 18);
            this.prgBar.TabIndex = 10;
            // 
            // lbPercent
            // 
            this.lbPercent.AutoSize = true;
            this.lbPercent.Location = new System.Drawing.Point(156, 504);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(30, 19);
            this.lbPercent.TabIndex = 11;
            this.lbPercent.Text = "0%";
            // 
            // lbProcessing
            // 
            this.lbProcessing.AutoSize = true;
            this.lbProcessing.Location = new System.Drawing.Point(207, 504);
            this.lbProcessing.Name = "lbProcessing";
            this.lbProcessing.Size = new System.Drawing.Size(101, 19);
            this.lbProcessing.TabIndex = 12;
            this.lbProcessing.Text = "[Loading file...]";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(514, 541);
            this.Controls.Add(this.lbProcessing);
            this.Controls.Add(this.lbPercent);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.grbMode);
            this.Controls.Add(this.grbFileAndFolder);
            this.Controls.Add(this.grbExtension);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbExtension.ResumeLayout(false);
            this.grbExtension.PerformLayout();
            this.grbFileAndFolder.ResumeLayout(false);
            this.grbFileAndFolder.PerformLayout();
            this.grbMode.ResumeLayout(false);
            this.grbMode.PerformLayout();
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
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lbFolder;
        private System.Windows.Forms.TextBox txtDirectFolderSave;
        private System.Windows.Forms.Button btnOpenFolderSave;
        private System.Windows.Forms.GroupBox grbExtension;
        private System.Windows.Forms.GroupBox grbFileAndFolder;
        private System.Windows.Forms.GroupBox grbMode;
        private System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.Label lbProcessing;
    }
}

