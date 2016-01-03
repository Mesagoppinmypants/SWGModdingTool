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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartButton = new System.Windows.Forms.Button();
            this.RebornDirTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EditDirectoriesButton = new System.Windows.Forms.Button();
            this.CloseProgramsCheckBox = new System.Windows.Forms.CheckBox();
            this.InstallModsButton = new System.Windows.Forms.Button();
            this.DisableMusicCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(100, 143);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(84, 45);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Install";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RebornDirTextBox
            // 
            this.RebornDirTextBox.Location = new System.Drawing.Point(12, 117);
            this.RebornDirTextBox.Name = "RebornDirTextBox";
            this.RebornDirTextBox.ReadOnly = true;
            this.RebornDirTextBox.Size = new System.Drawing.Size(260, 20);
            this.RebornDirTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SWG Reborn Directory";
            // 
            // EditDirectoriesButton
            // 
            this.EditDirectoriesButton.Location = new System.Drawing.Point(188, 194);
            this.EditDirectoriesButton.Name = "EditDirectoriesButton";
            this.EditDirectoriesButton.Size = new System.Drawing.Size(84, 45);
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
            this.InstallModsButton.Location = new System.Drawing.Point(12, 194);
            this.InstallModsButton.Name = "InstallModsButton";
            this.InstallModsButton.Size = new System.Drawing.Size(84, 45);
            this.InstallModsButton.TabIndex = 7;
            this.InstallModsButton.Text = "Mod Install List";
            this.InstallModsButton.UseVisualStyleBackColor = true;
            this.InstallModsButton.Click += new System.EventHandler(this.InstallModsButton_Click);
            // 
            // DisableMusicCheckBox
            // 
            this.DisableMusicCheckBox.AutoSize = true;
            this.DisableMusicCheckBox.Location = new System.Drawing.Point(180, 12);
            this.DisableMusicCheckBox.Name = "DisableMusicCheckBox";
            this.DisableMusicCheckBox.Size = new System.Drawing.Size(92, 17);
            this.DisableMusicCheckBox.TabIndex = 8;
            this.DisableMusicCheckBox.Text = "Disable Music";
            this.DisableMusicCheckBox.UseVisualStyleBackColor = true;
            this.DisableMusicCheckBox.CheckedChanged += new System.EventHandler(this.DisableMusicCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DisableMusicCheckBox);
            this.Controls.Add(this.InstallModsButton);
            this.Controls.Add(this.CloseProgramsCheckBox);
            this.Controls.Add(this.EditDirectoriesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RebornDirTextBox);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox RebornDirTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EditDirectoriesButton;
        private System.Windows.Forms.CheckBox CloseProgramsCheckBox;
        private System.Windows.Forms.Button InstallModsButton;
        private System.Windows.Forms.CheckBox DisableMusicCheckBox;
    }
}

