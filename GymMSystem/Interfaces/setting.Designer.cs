namespace GymMSystem.Interfaces
{
    partial class setting
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
            this.settings = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Controls.Add(this.metroTabPage1);
            this.settings.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.settings.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.settings.ItemSize = new System.Drawing.Size(200, 70);
            this.settings.Location = new System.Drawing.Point(-10, 114);
            this.settings.Margin = new System.Windows.Forms.Padding(5);
            this.settings.Multiline = true;
            this.settings.Name = "settings";
            this.settings.SelectedIndex = 0;
            this.settings.ShowToolTips = true;
            this.settings.Size = new System.Drawing.Size(1755, 673);
            this.settings.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.settings.Style = MetroFramework.MetroColorStyle.Magenta;
            this.settings.TabIndex = 1;
            this.settings.TabStop = false;
            this.settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settings.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 74);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1747, 595);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "metroTabPage1";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 900);
            this.Controls.Add(this.settings);
            this.Name = "setting";
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.setting_Load);
            this.settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl settings;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
    }
}