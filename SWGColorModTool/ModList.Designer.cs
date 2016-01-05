namespace SWGColorModTool
{
    partial class ModList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModList));
            this.ModToInstallComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.BeforeComboBox = new System.Windows.Forms.ComboBox();
            this.AfterComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteAllModsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModToInstallComboBox
            // 
            this.ModToInstallComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModToInstallComboBox.FormattingEnabled = true;
            this.ModToInstallComboBox.Items.AddRange(new object[] {
            "Lightsaber Color"});
            this.ModToInstallComboBox.Location = new System.Drawing.Point(78, 37);
            this.ModToInstallComboBox.Name = "ModToInstallComboBox";
            this.ModToInstallComboBox.Size = new System.Drawing.Size(121, 21);
            this.ModToInstallComboBox.TabIndex = 0;
            this.ModToInstallComboBox.SelectedIndexChanged += new System.EventHandler(this.ModToInstallComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the mod you want to install";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(78, 212);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(121, 37);
            this.DoneButton.TabIndex = 2;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // BeforeComboBox
            // 
            this.BeforeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BeforeComboBox.Enabled = false;
            this.BeforeComboBox.FormattingEnabled = true;
            this.BeforeComboBox.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Light Green",
            "Yellow"});
            this.BeforeComboBox.Location = new System.Drawing.Point(12, 97);
            this.BeforeComboBox.Name = "BeforeComboBox";
            this.BeforeComboBox.Size = new System.Drawing.Size(76, 21);
            this.BeforeComboBox.TabIndex = 3;
            // 
            // AfterComboBox
            // 
            this.AfterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AfterComboBox.Enabled = false;
            this.AfterComboBox.FormattingEnabled = true;
            this.AfterComboBox.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Light Green",
            "Yellow"});
            this.AfterComboBox.Location = new System.Drawing.Point(196, 97);
            this.AfterComboBox.Name = "AfterComboBox";
            this.AfterComboBox.Size = new System.Drawing.Size(76, 21);
            this.AfterComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // DeleteAllModsButton
            // 
            this.DeleteAllModsButton.Location = new System.Drawing.Point(95, 172);
            this.DeleteAllModsButton.Name = "DeleteAllModsButton";
            this.DeleteAllModsButton.Size = new System.Drawing.Size(86, 34);
            this.DeleteAllModsButton.TabIndex = 6;
            this.DeleteAllModsButton.Text = "Delete All Mods";
            this.DeleteAllModsButton.UseVisualStyleBackColor = true;
            this.DeleteAllModsButton.Click += new System.EventHandler(this.DeleteAllModsButton_Click);
            // 
            // ModList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DeleteAllModsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AfterComboBox);
            this.Controls.Add(this.BeforeComboBox);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModToInstallComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mods To Install";
            this.Load += new System.EventHandler(this.ModList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ModToInstallComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.ComboBox BeforeComboBox;
        private System.Windows.Forms.ComboBox AfterComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteAllModsButton;
    }
}