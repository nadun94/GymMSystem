namespace GymMSystem.Interfaces
{
    partial class OtherServices
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
            this.otherServieces = new MetroFramework.Controls.MetroTabControl();
            this.danceTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.otherServieces.SuspendLayout();
            this.SuspendLayout();
            // 
            // otherServieces
            // 
            this.otherServieces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otherServieces.Controls.Add(this.danceTabPage);
            this.otherServieces.Controls.Add(this.metroTabPage2);
            this.otherServieces.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.otherServieces.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.otherServieces.ItemSize = new System.Drawing.Size(200, 70);
            this.otherServieces.Location = new System.Drawing.Point(19, 87);
            this.otherServieces.Margin = new System.Windows.Forms.Padding(4);
            this.otherServieces.Multiline = true;
            this.otherServieces.Name = "otherServieces";
            this.otherServieces.SelectedIndex = 0;
            this.otherServieces.ShowToolTips = true;
            this.otherServieces.Size = new System.Drawing.Size(862, 416);
            this.otherServieces.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.otherServieces.Style = MetroFramework.MetroColorStyle.Magenta;
            this.otherServieces.TabIndex = 1;
            this.otherServieces.TabStop = false;
            this.otherServieces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.otherServieces.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // danceTabPage
            // 
            this.danceTabPage.HorizontalScrollbarBarColor = true;
            this.danceTabPage.Location = new System.Drawing.Point(4, 74);
            this.danceTabPage.Name = "danceTabPage";
            this.danceTabPage.Size = new System.Drawing.Size(854, 338);
            this.danceTabPage.TabIndex = 0;
            this.danceTabPage.Text = "Dancing";
            this.danceTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.danceTabPage.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 74);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(854, 338);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // OtherServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 523);
            this.Controls.Add(this.otherServieces);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OtherServices";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Other Services";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.OtherServices_Load);
            this.otherServieces.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl otherServieces;
        private MetroFramework.Controls.MetroTabPage danceTabPage;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
    }
}