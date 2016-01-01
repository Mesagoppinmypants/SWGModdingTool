namespace SWGColorModTool
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
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.FirstRowTimer = new System.Windows.Forms.Timer(this.components);
            this.RebornDirTextBox = new System.Windows.Forms.TextBox();
            this.TREDirTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditDirectoriesButton = new System.Windows.Forms.Button();
            this.CloseProgramsCheckBox = new System.Windows.Forms.CheckBox();
            this.InstallModsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(103, 226);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Install";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // FirstRowTimer
            // 
            this.FirstRowTimer.Interval = 1000;
            this.FirstRowTimer.Tick += new System.EventHandler(this.FirstRowTimer_Tick);
            // 
            // RebornDirTextBox
            // 
            this.RebornDirTextBox.Location = new System.Drawing.Point(12, 178);
            this.RebornDirTextBox.Name = "RebornDirTextBox";
            this.RebornDirTextBox.ReadOnly = true;
            this.RebornDirTextBox.Size = new System.Drawing.Size(260, 20);
            this.RebornDirTextBox.TabIndex = 1;
            // 
            // TREDirTextBox
            // 
            this.TREDirTextBox.Location = new System.Drawing.Point(12, 117);
            this.TREDirTextBox.Name = "TREDirTextBox";
            this.TREDirTextBox.ReadOnly = true;
            this.TREDirTextBox.Size = new System.Drawing.Size(260, 20);
            this.TREDirTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TRE Explorer Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SWG Reborn Directory";
            // 
            // EditDirectoriesButton
            // 
            this.EditDirectoriesButton.Location = new System.Drawing.Point(197, 223);
            this.EditDirectoriesButton.Name = "EditDirectoriesButton";
            this.EditDirectoriesButton.Size = new System.Drawing.Size(75, 34);
            this.EditDirectoriesButton.TabIndex = 5;
            this.EditDirectoriesButton.Text = "Edit Current Directories";
            this.EditDirectoriesButton.UseVisualStyleBackColor = true;
            this.EditDirectoriesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CloseProgramsCheckBox
            // 
            this.CloseProgramsCheckBox.AutoSize = true;
            this.CloseProgramsCheckBox.Location = new System.Drawing.Point(12, 12);
            this.CloseProgramsCheckBox.Name = "CloseProgramsCheckBox";
            this.CloseProgramsCheckBox.Size = new System.Drawing.Size(166, 17);
            this.CloseProgramsCheckBox.TabIndex = 6;
            this.CloseProgramsCheckBox.Text = "Close Programs When Closed";
            this.CloseProgramsCheckBox.UseVisualStyleBackColor = true;
            // 
            // InstallModsButton
            // 
            this.InstallModsButton.Location = new System.Drawing.Point(12, 217);
            this.InstallModsButton.Name = "InstallModsButton";
            this.InstallModsButton.Size = new System.Drawing.Size(75, 40);
            this.InstallModsButton.TabIndex = 7;
            this.InstallModsButton.Text = "Mod Install List";
            this.InstallModsButton.UseVisualStyleBackColor = true;
            this.InstallModsButton.Click += new System.EventHandler(this.InstallModsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.InstallModsButton);
            this.Controls.Add(this.CloseProgramsCheckBox);
            this.Controls.Add(this.EditDirectoriesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TREDirTextBox);
            this.Controls.Add(this.RebornDirTextBox);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SWG Color Mod Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer FirstRowTimer;
        private System.Windows.Forms.TextBox RebornDirTextBox;
        private System.Windows.Forms.TextBox TREDirTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EditDirectoriesButton;
        private System.Windows.Forms.CheckBox CloseProgramsCheckBox;
        private System.Windows.Forms.Button InstallModsButton;
    }
}

