namespace GymMSystem.Interfaces
{
    partial class Login
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtLogUsename = new MetroFramework.Controls.MetroTextBox();
            this.txtLogPwd = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroTile();
            this.btnLogClear = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(81, 194);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Username";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(81, 259);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 25);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLogUsename
            // 
            this.txtLogUsename.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtLogUsename.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtLogUsename.Location = new System.Drawing.Point(247, 196);
            this.txtLogUsename.Name = "txtLogUsename";
            this.txtLogUsename.PasswordChar = '.';
            this.txtLogUsename.Size = new System.Drawing.Size(198, 30);
            this.txtLogUsename.TabIndex = 1;
            // 
            // txtLogPwd
            // 
            this.txtLogPwd.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtLogPwd.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtLogPwd.Location = new System.Drawing.Point(247, 259);
            this.txtLogPwd.Name = "txtLogPwd";
            this.txtLogPwd.PasswordChar = '.';
            this.txtLogPwd.Size = new System.Drawing.Size(198, 30);
            this.txtLogPwd.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(112, 362);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(139, 48);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.Red;
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnLogin.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // btnLogClear
            // 
            this.btnLogClear.Location = new System.Drawing.Point(294, 362);
            this.btnLogClear.Name = "btnLogClear";
            this.btnLogClear.Size = new System.Drawing.Size(139, 48);
            this.btnLogClear.Style = MetroFramework.MetroColorStyle.Red;
            this.btnLogClear.TabIndex = 4;
            this.btnLogClear.Text = "Clear";
            this.btnLogClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogClear.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnLogClear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 650);
            this.Controls.Add(this.btnLogClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLogPwd);
            this.Controls.Add(this.txtLogUsename);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Login";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtLogUsename;
        private MetroFramework.Controls.MetroTextBox txtLogPwd;
        private MetroFramework.Controls.MetroTile btnLogin;
        private MetroFramework.Controls.MetroTile btnLogClear;
    }
}