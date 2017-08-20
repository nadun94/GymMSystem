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
            this.dateTimePickerMem = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnM_save = new MetroFramework.Controls.MetroTile();
            this.btnM_clear = new MetroFramework.Controls.MetroTile();
            this.cmbM_paymentPlan = new MetroFramework.Controls.MetroComboBox();
            this.cmbM_gender = new MetroFramework.Controls.MetroComboBox();
            this.btn_mem_browse = new MetroFramework.Controls.MetroTile();
            this.picuturebox_member = new System.Windows.Forms.PictureBox();
            this.txtM_weight = new MetroFramework.Controls.MetroTextBox();
            this.txtM_nic = new MetroFramework.Controls.MetroTextBox();
            this.txtM_fat = new MetroFramework.Controls.MetroTextBox();
            this.txtM_height = new MetroFramework.Controls.MetroTextBox();
            this.txtM_phone = new MetroFramework.Controls.MetroTextBox();
            this.txtM_memID = new MetroFramework.Controls.MetroTextBox();
            this.txtM_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.memfee = new MetroFramework.Controls.MetroTabPage();
            this.txtMF_memID = new MetroFramework.Controls.MetroTextBox();
            this.txtMFee_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.openFIleDialog_mem = new System.Windows.Forms.OpenFileDialog();
            this.btnMemHme = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.msmMember)).BeginInit();
            this.mem.SuspendLayout();
            this.memadd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picuturebox_member)).BeginInit();
            this.memfee.SuspendLayout();
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
            this.mem.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.mem.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.mem.ItemSize = new System.Drawing.Size(200, 70);
            this.mem.Location = new System.Drawing.Point(23, 60);
            this.mem.Margin = new System.Windows.Forms.Padding(5);
            this.mem.Multiline = true;
            this.mem.Name = "mem";
            this.mem.SelectedIndex = 1;
            this.mem.ShowToolTips = true;
            this.mem.Size = new System.Drawing.Size(1755, 673);
            this.mem.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mem.Style = MetroFramework.MetroColorStyle.Magenta;
            this.mem.TabIndex = 0;
            this.mem.TabStop = false;
            this.mem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mem.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // memadd
            // 
            this.memadd.BackColor = System.Drawing.Color.White;
            this.memadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.memadd.Controls.Add(this.dateTimePickerMem);
            this.memadd.Controls.Add(this.btnM_save);
            this.memadd.Controls.Add(this.btnM_clear);
            this.memadd.Controls.Add(this.cmbM_paymentPlan);
            this.memadd.Controls.Add(this.cmbM_gender);
            this.memadd.Controls.Add(this.btn_mem_browse);
            this.memadd.Controls.Add(this.picuturebox_member);
            this.memadd.Controls.Add(this.txtM_weight);
            this.memadd.Controls.Add(this.txtM_nic);
            this.memadd.Controls.Add(this.txtM_fat);
            this.memadd.Controls.Add(this.txtM_height);
            this.memadd.Controls.Add(this.txtM_phone);
            this.memadd.Controls.Add(this.txtM_memID);
            this.memadd.Controls.Add(this.txtM_name);
            this.memadd.Controls.Add(this.metroLabel5);
            this.memadd.Controls.Add(this.metroLabel11);
            this.memadd.Controls.Add(this.metroLabel10);
            this.memadd.Controls.Add(this.metroLabel12);
            this.memadd.Controls.Add(this.metroLabel4);
            this.memadd.Controls.Add(this.metroLabel3);
            this.memadd.Controls.Add(this.metroLabel9);
            this.memadd.Controls.Add(this.metroLabel2);
            this.memadd.Controls.Add(this.metroLabel13);
            this.memadd.Controls.Add(this.metroLabel1);
            this.memadd.ForeColor = System.Drawing.Color.White;
            this.memadd.HorizontalScrollbarBarColor = true;
            this.memadd.Location = new System.Drawing.Point(4, 74);
            this.memadd.Name = "memadd";
            this.memadd.Size = new System.Drawing.Size(1747, 595);
            this.memadd.Style = MetroFramework.MetroColorStyle.Teal;
            this.memadd.TabIndex = 0;
            this.memadd.Text = "Add Member";
            this.memadd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.memadd.VerticalScrollbarBarColor = true;
            this.memadd.Click += new System.EventHandler(this.memadd_Click);
            // 
            // dateTimePickerMem
            // 
            this.dateTimePickerMem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerMem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dateTimePickerMem.BorderRadius = 0;
            this.dateTimePickerMem.ForeColor = System.Drawing.Color.White;
            this.dateTimePickerMem.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerMem.FormatCustom = null;
            this.dateTimePickerMem.Location = new System.Drawing.Point(178, 140);
            this.dateTimePickerMem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerMem.Name = "dateTimePickerMem";
            this.dateTimePickerMem.Size = new System.Drawing.Size(358, 32);
            this.dateTimePickerMem.TabIndex = 12;
            this.dateTimePickerMem.Value = new System.DateTime(2017, 8, 20, 23, 58, 37, 205);
            // 
            // btnM_save
            // 
            this.btnM_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnM_save.Location = new System.Drawing.Point(1601, 149);
            this.btnM_save.Name = "btnM_save";
            this.btnM_save.Size = new System.Drawing.Size(106, 33);
            this.btnM_save.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnM_save.TabIndex = 10;
            this.btnM_save.Text = "Save";
            this.btnM_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnM_save.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnM_save.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnM_save.Click += new System.EventHandler(this.btnM_save_Click);
            // 
            // btnM_clear
            // 
            this.btnM_clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnM_clear.Location = new System.Drawing.Point(1468, 149);
            this.btnM_clear.Name = "btnM_clear";
            this.btnM_clear.Size = new System.Drawing.Size(100, 33);
            this.btnM_clear.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnM_clear.TabIndex = 9;
            this.btnM_clear.Text = "Clear";
            this.btnM_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnM_clear.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnM_clear.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnM_clear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnM_clear.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // cmbM_paymentPlan
            // 
            this.cmbM_paymentPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbM_paymentPlan.FormattingEnabled = true;
            this.cmbM_paymentPlan.ItemHeight = 24;
            this.cmbM_paymentPlan.Items.AddRange(new object[] {
            "Monthly",
            "Half Year",
            "Full Year"});
            this.cmbM_paymentPlan.Location = new System.Drawing.Point(860, 411);
            this.cmbM_paymentPlan.Name = "cmbM_paymentPlan";
            this.cmbM_paymentPlan.Size = new System.Drawing.Size(168, 30);
            this.cmbM_paymentPlan.Style = MetroFramework.MetroColorStyle.Teal;
            this.cmbM_paymentPlan.TabIndex = 8;
            this.cmbM_paymentPlan.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbM_paymentPlan.SelectedIndexChanged += new System.EventHandler(this.cmbM_paymentPlan_SelectedIndexChanged);
            // 
            // cmbM_gender
            // 
            this.cmbM_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbM_gender.FormattingEnabled = true;
            this.cmbM_gender.ItemHeight = 24;
            this.cmbM_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbM_gender.Location = new System.Drawing.Point(178, 407);
            this.cmbM_gender.Name = "cmbM_gender";
            this.cmbM_gender.Size = new System.Drawing.Size(174, 30);
            this.cmbM_gender.Style = MetroFramework.MetroColorStyle.Teal;
            this.cmbM_gender.TabIndex = 7;
            this.cmbM_gender.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_mem_browse
            // 
            this.btn_mem_browse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mem_browse.Location = new System.Drawing.Point(1216, 277);
            this.btn_mem_browse.Name = "btn_mem_browse";
            this.btn_mem_browse.Size = new System.Drawing.Size(126, 33);
            this.btn_mem_browse.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_mem_browse.TabIndex = 6;
            this.btn_mem_browse.Text = "Browse";
            this.btn_mem_browse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_mem_browse.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_mem_browse.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_mem_browse.Click += new System.EventHandler(this.btn_mem_browse_Click);
            // 
            // picuturebox_member
            // 
            this.picuturebox_member.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picuturebox_member.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.picuturebox_member.Location = new System.Drawing.Point(1182, 43);
            this.picuturebox_member.Name = "picuturebox_member";
            this.picuturebox_member.Size = new System.Drawing.Size(199, 207);
            this.picuturebox_member.TabIndex = 5;
            this.picuturebox_member.TabStop = false;
            // 
            // txtM_weight
            // 
            this.txtM_weight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtM_weight.BackColor = System.Drawing.Color.White;
            this.txtM_weight.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtM_weight.ForeColor = System.Drawing.Color.White;
            this.txtM_weight.Location = new System.Drawing.Point(855, 141);
            this.txtM_weight.Name = "txtM_weight";
            this.txtM_weight.Size = new System.Drawing.Size(200, 28);
            this.txtM_weight.TabIndex = 3;
            this.txtM_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM_weight.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtM_weight.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtM_nic
            // 
            this.txtM_nic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtM_nic.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtM_nic.Location = new System.Drawing.Point(178, 323);
            this.txtM_nic.Name = "txtM_nic";
            this.txtM_nic.Size = new System.Drawing.Size(261, 28);
            this.txtM_nic.TabIndex = 3;
            this.txtM_nic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM_nic.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtM_nic.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtM_fat
            // 
            this.txtM_fat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtM_fat.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtM_fat.Location = new System.Drawing.Point(855, 322);
            this.txtM_fat.Name = "txtM_fat";
            this.txtM_fat.Size = new System.Drawing.Size(200, 28);
            this.txtM_fat.TabIndex = 3;
            this.txtM_fat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM_fat.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtM_fat.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtM_height
            // 
            this.txtM_height.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtM_height.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtM_height.Location = new System.Drawing.Point(855, 232);
            this.txtM_height.Name = "txtM_height";
            this.txtM_height.Size = new System.Drawing.Size(200, 28);
            this.txtM_height.TabIndex = 3;
            this.txtM_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM_height.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtM_height.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtM_phone
            // 
            this.txtM_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtM_phone.BackColor = System.Drawing.Color.White;
            this.txtM_phone.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtM_phone.ForeColor = System.Drawing.Color.White;
            this.txtM_phone.Location = new System.Drawing.Point(178, 230);
            this.txtM_phone.Name = "txtM_phone";
            this.txtM_phone.Size = new System.Drawing.Size(261, 28);
            this.txtM_phone.TabIndex = 3;
            this.txtM_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM_phone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtM_phone.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtM_memID
            // 
            this.txtM_memID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtM_memID.BackColor = System.Drawing.Color.White;
            this.txtM_memID.CustomForeColor = true;
            this.txtM_memID.Enabled = false;
            this.txtM_memID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtM_memID.ForeColor = System.Drawing.Color.White;
            this.txtM_memID.Location = new System.Drawing.Point(855, 45);
            this.txtM_memID.Name = "txtM_memID";
            this.txtM_memID.Size = new System.Drawing.Size(200, 28);
            this.txtM_memID.TabIndex = 3;
            this.txtM_memID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM_memID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtM_memID.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtM_name
            // 
            this.txtM_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtM_name.BackColor = System.Drawing.Color.White;
            this.txtM_name.CustomForeColor = true;
            this.txtM_name.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtM_name.ForeColor = System.Drawing.Color.White;
            this.txtM_name.Location = new System.Drawing.Point(178, 46);
            this.txtM_name.Name = "txtM_name";
            this.txtM_name.Size = new System.Drawing.Size(358, 28);
            this.txtM_name.TabIndex = 3;
            this.txtM_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM_name.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtM_name.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(639, 144);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Weight";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(639, 411);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(126, 25);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel11.TabIndex = 2;
            this.metroLabel11.Text = "Payment Plan";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(26, 325);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(43, 25);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "NIC";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel12
            // 
            this.metroLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(643, 325);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(84, 25);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel12.TabIndex = 2;
            this.metroLabel12.Text = "Fat Level";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(639, 235);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Height";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(26, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "DOB";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(26, 414);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(74, 25);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Gender";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(26, 232);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Phone";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel13
            // 
            this.metroLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(643, 43);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(106, 25);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel13.TabIndex = 2;
            this.metroLabel13.Text = "Member ID";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(26, 46);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Name";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // memfee
            // 
            this.memfee.Controls.Add(this.txtMF_memID);
            this.memfee.Controls.Add(this.txtMFee_name);
            this.memfee.Controls.Add(this.metroLabel14);
            this.memfee.Controls.Add(this.metroLabel8);
            this.memfee.Controls.Add(this.metroLabel7);
            this.memfee.Controls.Add(this.metroLabel6);
            this.memfee.HorizontalScrollbarBarColor = true;
            this.memfee.Location = new System.Drawing.Point(4, 74);
            this.memfee.Name = "memfee";
            this.memfee.Size = new System.Drawing.Size(1747, 595);
            this.memfee.TabIndex = 1;
            this.memfee.Text = "Member Fee";
            this.memfee.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.memfee.VerticalScrollbarBarColor = true;
            // 
            // txtMF_memID
            // 
            this.txtMF_memID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMF_memID.Location = new System.Drawing.Point(205, 114);
            this.txtMF_memID.Name = "txtMF_memID";
            this.txtMF_memID.Size = new System.Drawing.Size(258, 28);
            this.txtMF_memID.TabIndex = 4;
            this.txtMF_memID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtMFee_name
            // 
            this.txtMFee_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMFee_name.Location = new System.Drawing.Point(205, 51);
            this.txtMFee_name.Name = "txtMFee_name";
            this.txtMFee_name.Size = new System.Drawing.Size(346, 28);
            this.txtMFee_name.TabIndex = 4;
            this.txtMFee_name.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel14
            // 
            this.metroLabel14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(27, 243);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(175, 25);
            this.metroLabel14.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel14.TabIndex = 3;
            this.metroLabel14.Text = "Valid Payment Date";
            this.metroLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(27, 179);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(126, 25);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel8.TabIndex = 3;
            this.metroLabel8.Text = "Payment Plan";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(27, 114);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(113, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "Memberr ID";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(27, 51);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 25);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Name";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // openFIleDialog_mem
            // 
            this.openFIleDialog_mem.FileName = "openFileDialog1";
            // 
            // btnMemHme
            // 
            this.btnMemHme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMemHme.Location = new System.Drawing.Point(1635, 46);
            this.btnMemHme.Name = "btnMemHme";
            this.btnMemHme.Size = new System.Drawing.Size(100, 38);
            this.btnMemHme.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnMemHme.TabIndex = 1;
            this.btnMemHme.Text = "Home";
            this.btnMemHme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMemHme.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnMemHme.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnMemHme.Click += new System.EventHandler(this.btnMemHme_Click);
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1803, 865);
            this.Controls.Add(this.btnMemHme);
            this.Controls.Add(this.mem);
            this.DisplayHeader = false;
            this.Name = "Members";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Members";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Members_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmMember)).EndInit();
            this.mem.ResumeLayout(false);
            this.memadd.ResumeLayout(false);
            this.memadd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picuturebox_member)).EndInit();
            this.memfee.ResumeLayout(false);
            this.memfee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager msmMember;
        private MetroFramework.Controls.MetroTabControl mem;
        private MetroFramework.Controls.MetroTabPage memadd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage memfee;
        private MetroFramework.Controls.MetroTextBox txtM_name;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtM_phone;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtM_weight;
        private MetroFramework.Controls.MetroTextBox txtM_height;
        private System.Windows.Forms.PictureBox picuturebox_member;
        private MetroFramework.Controls.MetroTile btn_mem_browse;
        private System.Windows.Forms.OpenFileDialog openFIleDialog_mem;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTile btnMemHme;
        private MetroFramework.Controls.MetroComboBox cmbM_gender;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtM_nic;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTile btnM_clear;
        private MetroFramework.Controls.MetroComboBox cmbM_paymentPlan;
        private MetroFramework.Controls.MetroTile btnM_save;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimePickerMem;
        private MetroFramework.Controls.MetroTextBox txtM_fat;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtM_memID;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txtMFee_name;
        private MetroFramework.Controls.MetroTextBox txtMF_memID;
        private MetroFramework.Controls.MetroLabel metroLabel14;
    }
}