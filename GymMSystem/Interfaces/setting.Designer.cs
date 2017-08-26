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
            this.tabUserAccounts = new MetroFramework.Controls.MetroTabPage();
            this.btnInvHome = new MetroFramework.Controls.MetroTile();
            this.settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Controls.Add(this.tabUserAccounts);
            this.settings.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.settings.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.settings.ItemSize = new System.Drawing.Size(200, 70);
            this.settings.Location = new System.Drawing.Point(35, 138);
            this.settings.Margin = new System.Windows.Forms.Padding(5);
            this.settings.Multiline = true;
            this.settings.Name = "settings";
            this.settings.SelectedIndex = 0;
            this.settings.ShowToolTips = true;
            this.settings.Size = new System.Drawing.Size(1648, 737);
            this.settings.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.settings.Style = MetroFramework.MetroColorStyle.Magenta;
            this.settings.TabIndex = 1;
            this.settings.TabStop = false;
            this.settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settings.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabUserAccounts
            // 
            this.tabUserAccounts.HorizontalScrollbarBarColor = true;
            this.tabUserAccounts.Location = new System.Drawing.Point(4, 74);
            this.tabUserAccounts.Name = "tabUserAccounts";
            this.tabUserAccounts.Size = new System.Drawing.Size(1640, 659);
            this.tabUserAccounts.TabIndex = 1;
            this.tabUserAccounts.Text = "User Accounts";
            this.tabUserAccounts.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabUserAccounts.VerticalScrollbarBarColor = true;
            // 
            // btnInvHome
            // 
            this.btnInvHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvHome.Location = new System.Drawing.Point(1299, 63);
            this.btnInvHome.Name = "btnInvHome";
            this.btnInvHome.Size = new System.Drawing.Size(134, 44);
            this.btnInvHome.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnInvHome.TabIndex = 45;
            this.btnInvHome.Text = "Home";
            this.btnInvHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInvHome.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnInvHome.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 900);
            this.Controls.Add(this.btnInvHome);
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
        private MetroFramework.Controls.MetroTabPage tabUserAccounts;
        private MetroFramework.Controls.MetroTile btnInvHome;
    }
}