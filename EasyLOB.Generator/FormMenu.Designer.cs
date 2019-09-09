namespace EasyLOB.Generator
{
    partial class FormMenu
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
            this.lblName = new System.Windows.Forms.Label();
            this.lbllnkEasyLOB = new System.Windows.Forms.LinkLabel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lsbLog = new System.Windows.Forms.ListBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApplicationName = new System.Windows.Forms.TextBox();
            this.btnSolutionDirectory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSolutionDirectory = new System.Windows.Forms.TextBox();
            this.btnTemplateDirectory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemplateDirectory = new System.Windows.Forms.TextBox();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(16, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "?";
            // 
            // lbllnkEasyLOB
            // 
            this.lbllnkEasyLOB.AutoSize = true;
            this.lbllnkEasyLOB.Location = new System.Drawing.Point(12, 30);
            this.lbllnkEasyLOB.Name = "lbllnkEasyLOB";
            this.lbllnkEasyLOB.Size = new System.Drawing.Size(67, 17);
            this.lbllnkEasyLOB.TabIndex = 1;
            this.lbllnkEasyLOB.TabStop = true;
            this.lbllnkEasyLOB.Text = "EasyLOB";
            this.lbllnkEasyLOB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllnkEasyLOB_LinkClicked);
            // 
            // lsbLog
            // 
            this.lsbLog.FormattingEnabled = true;
            this.lsbLog.HorizontalScrollbar = true;
            this.lsbLog.ItemHeight = 16;
            this.lsbLog.Location = new System.Drawing.Point(506, 60);
            this.lsbLog.Name = "lsbLog";
            this.lsbLog.ScrollAlwaysVisible = true;
            this.lsbLog.Size = new System.Drawing.Size(600, 244);
            this.lsbLog.TabIndex = 12;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenu.Controls.Add(this.btnOK);
            this.pnlMenu.Controls.Add(this.label4);
            this.pnlMenu.Controls.Add(this.txtApplicationName);
            this.pnlMenu.Controls.Add(this.btnSolutionDirectory);
            this.pnlMenu.Controls.Add(this.label3);
            this.pnlMenu.Controls.Add(this.txtSolutionDirectory);
            this.pnlMenu.Controls.Add(this.btnTemplateDirectory);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.txtTemplateDirectory);
            this.pnlMenu.Location = new System.Drawing.Point(12, 60);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(477, 244);
            this.pnlMenu.TabIndex = 14;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(20, 203);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Application Name";
            // 
            // txtApplicationName
            // 
            this.txtApplicationName.Location = new System.Drawing.Point(20, 163);
            this.txtApplicationName.Name = "txtApplicationName";
            this.txtApplicationName.Size = new System.Drawing.Size(398, 22);
            this.txtApplicationName.TabIndex = 23;
            this.txtApplicationName.Leave += new System.EventHandler(this.txtApplicationName_Leave);
            // 
            // btnSolutionDirectory
            // 
            this.btnSolutionDirectory.Location = new System.Drawing.Point(424, 99);
            this.btnSolutionDirectory.Name = "btnSolutionDirectory";
            this.btnSolutionDirectory.Size = new System.Drawing.Size(37, 23);
            this.btnSolutionDirectory.TabIndex = 19;
            this.btnSolutionDirectory.Text = "...";
            this.btnSolutionDirectory.UseVisualStyleBackColor = true;
            this.btnSolutionDirectory.Click += new System.EventHandler(this.btnSolutionDirectory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Solution PARENT Directory";
            // 
            // txtSolutionDirectory
            // 
            this.txtSolutionDirectory.Location = new System.Drawing.Point(20, 99);
            this.txtSolutionDirectory.Name = "txtSolutionDirectory";
            this.txtSolutionDirectory.ReadOnly = true;
            this.txtSolutionDirectory.Size = new System.Drawing.Size(398, 22);
            this.txtSolutionDirectory.TabIndex = 18;
            this.txtSolutionDirectory.Text = "C:\\Git\\EasyLOB-3";
            // 
            // btnTemplateDirectory
            // 
            this.btnTemplateDirectory.Location = new System.Drawing.Point(424, 38);
            this.btnTemplateDirectory.Name = "btnTemplateDirectory";
            this.btnTemplateDirectory.Size = new System.Drawing.Size(37, 23);
            this.btnTemplateDirectory.TabIndex = 16;
            this.btnTemplateDirectory.Text = "...";
            this.btnTemplateDirectory.UseVisualStyleBackColor = true;
            this.btnTemplateDirectory.Click += new System.EventHandler(this.btnTemplateDirectory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Template Directory";
            // 
            // txtTemplateDirectory
            // 
            this.txtTemplateDirectory.Location = new System.Drawing.Point(20, 38);
            this.txtTemplateDirectory.Name = "txtTemplateDirectory";
            this.txtTemplateDirectory.ReadOnly = true;
            this.txtTemplateDirectory.Size = new System.Drawing.Size(398, 22);
            this.txtTemplateDirectory.TabIndex = 15;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 317);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lsbLog);
            this.Controls.Add(this.lbllnkEasyLOB);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMenu";
            this.Text = "?";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.LinkLabel lbllnkEasyLOB;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ListBox lsbLog;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApplicationName;
        private System.Windows.Forms.Button btnSolutionDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSolutionDirectory;
        private System.Windows.Forms.Button btnTemplateDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemplateDirectory;
    }
}

