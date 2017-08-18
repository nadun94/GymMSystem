namespace GymMSystem.Interfaces
{
    partial class Members
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
            this.msmMember = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mem = new MetroFramework.Controls.MetroTabControl();
            this.memadd = new MetroFramework.Controls.MetroTabPage();
            this.memfee = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtM_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtM_phone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtM_height = new MetroFramework.Controls.MetroTextBox();
            this.txtM_weight = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.msmMember)).BeginInit();
            this.mem.SuspendLayout();
            this.memadd.SuspendLayout();
            this.SuspendLayout();
            // 
            // msmMember
            // 
            this.msmMember.Owner = this;
            this.msmMember.Style = MetroFramework.MetroColorStyle.Lime;
            this.msmMember.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mem
            // 
            this.mem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mem.Controls.Add(this.memadd);
            this.mem.Controls.Add(this.memfee);
            this.mem.Controls.Add(this.metroTabPage3);
            this.mem.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.mem.Location = new System.Drawing.Point(23, 56);
            this.mem.Margin = new System.Windows.Forms.Padding(5);
            this.mem.Multiline = true;
            this.mem.Name = "mem";
            this.mem.SelectedIndex = 0;
            this.mem.Size = new System.Drawing.Size(1277, 653);
            this.mem.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mem.Style = MetroFramework.MetroColorStyle.Magenta;
            this.mem.TabIndex = 0;
            this.mem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mem.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // memadd
            // 
            this.memadd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memadd.Controls.Add(this.dateTimePicker1);
            this.memadd.Controls.Add(this.txtM_weight);
            this.memadd.Controls.Add(this.txtM_height);
            this.memadd.Controls.Add(this.txtM_phone);
            this.memadd.Controls.Add(this.txtM_name);
            this.memadd.Controls.Add(this.metroLabel5);
            this.memadd.Controls.Add(this.metroLabel4);
            this.memadd.Controls.Add(this.metroLabel3);
            this.memadd.Controls.Add(this.metroLabel2);
            this.memadd.Controls.Add(this.metroLabel1);
            this.memadd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.memadd.HorizontalScrollbarBarColor = true;
            this.memadd.Location = new System.Drawing.Point(4, 39);
            this.memadd.Name = "memadd";
            this.memadd.Size = new System.Drawing.Size(1269, 610);
            this.memadd.Style = MetroFramework.MetroColorStyle.Teal;
            this.memadd.TabIndex = 0;
            this.memadd.Text = "Add Member";
            this.memadd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.memadd.VerticalScrollbarBarColor = true;
            // 
            // memfee
            // 
            this.memfee.HorizontalScrollbarBarColor = true;
            this.memfee.Location = new System.Drawing.Point(4, 39);
            this.memfee.Name = "memfee";
            this.memfee.Size = new System.Drawing.Size(914, 396);
            this.memfee.TabIndex = 1;
            this.memfee.Text = "Member Fee";
            this.memfee.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.memfee.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(914, 396);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(19, 46);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Name";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtM_name
            // 
            this.txtM_name.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtM_name.Location = new System.Drawing.Point(114, 48);
            this.txtM_name.Name = "txtM_name";
            this.txtM_name.Size = new System.Drawing.Size(197, 23);
            this.txtM_name.TabIndex = 3;
            this.txtM_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM_name.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtM_name.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(19, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Phone";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtM_phone
            // 
            this.txtM_phone.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtM_phone.Location = new System.Drawing.Point(114, 111);
            this.txtM_phone.Name = "txtM_phone";
            this.txtM_phone.Size = new System.Drawing.Size(197, 23);
            this.txtM_phone.TabIndex = 3;
            this.txtM_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM_phone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtM_phone.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(19, 167);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "DOB";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.GrayText;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(19, 221);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Height";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(19, 267);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Weight";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtM_height
            // 
            this.txtM_height.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtM_height.Location = new System.Drawing.Point(114, 223);
            this.txtM_height.Name = "txtM_height";
            this.txtM_height.Size = new System.Drawing.Size(197, 23);
            this.txtM_height.TabIndex = 3;
            this.txtM_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM_height.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtM_height.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtM_weight
            // 
            this.txtM_weight.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtM_weight.Location = new System.Drawing.Point(114, 269);
            this.txtM_weight.Name = "txtM_weight";
            this.txtM_weight.Size = new System.Drawing.Size(197, 23);
            this.txtM_weight.TabIndex = 3;
            this.txtM_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM_weight.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtM_weight.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1308, 745);
            this.Controls.Add(this.mem);
            this.DisplayHeader = false;
            this.Name = "Members";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Members";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Members_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmMember)).EndInit();
            this.mem.ResumeLayout(false);
            this.memadd.ResumeLayout(false);
            this.memadd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager msmMember;
        private MetroFramework.Controls.MetroTabControl mem;
        private MetroFramework.Controls.MetroTabPage memadd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage memfee;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTextBox txtM_name;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtM_phone;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtM_weight;
        private MetroFramework.Controls.MetroTextBox txtM_height;
    }
}