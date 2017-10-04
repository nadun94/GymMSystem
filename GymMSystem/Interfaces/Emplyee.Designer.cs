namespace GymMSystem.Interfaces
{
    partial class Emplyee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeeTabCntrl = new MetroFramework.Controls.MetroTabControl();
            this.tabAddEmp = new MetroFramework.Controls.MetroTabPage();
            this.btnEmp1Search = new MetroFramework.Controls.MetroTile();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnEmp1Delete = new MetroFramework.Controls.MetroTile();
            this.btnEmp1Update = new MetroFramework.Controls.MetroTile();
            this.txtEmp1_email = new MetroFramework.Controls.MetroTextBox();
            this.txtEmp_nic = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtEmp1_phone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnEmp1_save = new MetroFramework.Controls.MetroTile();
            this.btnEmp1_clear = new MetroFramework.Controls.MetroTile();
            this.cmbEmp1_post = new MetroFramework.Controls.MetroComboBox();
            this.cmbEmp1_gender = new MetroFramework.Controls.MetroComboBox();
            this.btn_emp1_browse = new MetroFramework.Controls.MetroTile();
            this.picuturebox_emp1 = new System.Windows.Forms.PictureBox();
            this.txtEmp1_resume = new MetroFramework.Controls.MetroTextBox();
            this.txtEmp1_jdate = new MetroFramework.Controls.MetroTextBox();
            this.txtEmp1_address = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtEmp1_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabAddEmployee = new MetroFramework.Controls.MetroTabPage();
            this.btnClearempT2 = new MetroFramework.Controls.MetroTile();
            this.btnSaveT2emp = new MetroFramework.Controls.MetroTile();
            this.txtStartTime = new MetroFramework.Controls.MetroTextBox();
            this.txtEmpIDatte = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.tabSalary = new MetroFramework.Controls.MetroTabPage();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePickeremp = new Bunifu.Framework.UI.BunifuDatepicker();
            this.openFileDialogEmp = new System.Windows.Forms.OpenFileDialog();
            this.employeeTabCntrl.SuspendLayout();
            this.tabAddEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuturebox_emp1)).BeginInit();
            this.tabAddEmployee.SuspendLayout();
            this.tabSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeTabCntrl
            // 
            this.employeeTabCntrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeTabCntrl.Controls.Add(this.tabAddEmp);
            this.employeeTabCntrl.Controls.Add(this.tabAddEmployee);
            this.employeeTabCntrl.Controls.Add(this.tabSalary);
            this.employeeTabCntrl.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.employeeTabCntrl.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.employeeTabCntrl.ItemSize = new System.Drawing.Size(200, 70);
            this.employeeTabCntrl.Location = new System.Drawing.Point(19, 97);
            this.employeeTabCntrl.Margin = new System.Windows.Forms.Padding(4);
            this.employeeTabCntrl.Multiline = true;
            this.employeeTabCntrl.Name = "employeeTabCntrl";
            this.employeeTabCntrl.SelectedIndex = 0;
            this.employeeTabCntrl.ShowToolTips = true;
            this.employeeTabCntrl.Size = new System.Drawing.Size(1247, 613);
            this.employeeTabCntrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.employeeTabCntrl.Style = MetroFramework.MetroColorStyle.Magenta;
            this.employeeTabCntrl.TabIndex = 2;
            this.employeeTabCntrl.TabStop = false;
            this.employeeTabCntrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.employeeTabCntrl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabAddEmp
            // 
            this.tabAddEmp.Controls.Add(this.dateTimePickeremp);
            this.tabAddEmp.Controls.Add(this.btnEmp1Search);
            this.tabAddEmp.Controls.Add(this.bunifuCustomDataGrid1);
            this.tabAddEmp.Controls.Add(this.btnEmp1Delete);
            this.tabAddEmp.Controls.Add(this.btnEmp1Update);
            this.tabAddEmp.Controls.Add(this.txtEmp1_email);
            this.tabAddEmp.Controls.Add(this.txtEmp_nic);
            this.tabAddEmp.Controls.Add(this.metroLabel6);
            this.tabAddEmp.Controls.Add(this.metroLabel5);
            this.tabAddEmp.Controls.Add(this.txtEmp1_phone);
            this.tabAddEmp.Controls.Add(this.metroLabel10);
            this.tabAddEmp.Controls.Add(this.metroLabel4);
            this.tabAddEmp.Controls.Add(this.btnEmp1_save);
            this.tabAddEmp.Controls.Add(this.btnEmp1_clear);
            this.tabAddEmp.Controls.Add(this.cmbEmp1_post);
            this.tabAddEmp.Controls.Add(this.cmbEmp1_gender);
            this.tabAddEmp.Controls.Add(this.btn_emp1_browse);
            this.tabAddEmp.Controls.Add(this.picuturebox_emp1);
            this.tabAddEmp.Controls.Add(this.txtEmp1_resume);
            this.tabAddEmp.Controls.Add(this.txtEmp1_jdate);
            this.tabAddEmp.Controls.Add(this.txtEmp1_address);
            this.tabAddEmp.Controls.Add(this.metroLabel8);
            this.tabAddEmp.Controls.Add(this.metroLabel7);
            this.tabAddEmp.Controls.Add(this.txtEmp1_name);
            this.tabAddEmp.Controls.Add(this.metroLabel2);
            this.tabAddEmp.Controls.Add(this.metroLabel3);
            this.tabAddEmp.Controls.Add(this.metroLabel9);
            this.tabAddEmp.Controls.Add(this.metroLabel1);
            this.tabAddEmp.HorizontalScrollbarBarColor = true;
            this.tabAddEmp.HorizontalScrollbarSize = 8;
            this.tabAddEmp.Location = new System.Drawing.Point(4, 74);
            this.tabAddEmp.Margin = new System.Windows.Forms.Padding(2);
            this.tabAddEmp.Name = "tabAddEmp";
            this.tabAddEmp.Size = new System.Drawing.Size(1239, 535);
            this.tabAddEmp.TabIndex = 1;
            this.tabAddEmp.Text = "Employees";
            this.tabAddEmp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabAddEmp.VerticalScrollbarBarColor = true;
            this.tabAddEmp.VerticalScrollbarSize = 8;
            // 
            // btnEmp1Search
            // 
            this.btnEmp1Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmp1Search.Location = new System.Drawing.Point(1072, 158);
            this.btnEmp1Search.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmp1Search.Name = "btnEmp1Search";
            this.btnEmp1Search.Size = new System.Drawing.Size(80, 27);
            this.btnEmp1Search.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnEmp1Search.TabIndex = 26;
            this.btnEmp1Search.Text = "Search";
            this.btnEmp1Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmp1Search.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnEmp1Search.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(56, 449);
            this.bunifuCustomDataGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(998, 95);
            this.bunifuCustomDataGrid1.TabIndex = 25;
            // 
            // btnEmp1Delete
            // 
            this.btnEmp1Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmp1Delete.Location = new System.Drawing.Point(1072, 336);
            this.btnEmp1Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmp1Delete.Name = "btnEmp1Delete";
            this.btnEmp1Delete.Size = new System.Drawing.Size(80, 27);
            this.btnEmp1Delete.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnEmp1Delete.TabIndex = 24;
            this.btnEmp1Delete.Text = "Delete";
            this.btnEmp1Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmp1Delete.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnEmp1Delete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // btnEmp1Update
            // 
            this.btnEmp1Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmp1Update.Location = new System.Drawing.Point(1072, 278);
            this.btnEmp1Update.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmp1Update.Name = "btnEmp1Update";
            this.btnEmp1Update.Size = new System.Drawing.Size(80, 27);
            this.btnEmp1Update.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnEmp1Update.TabIndex = 23;
            this.btnEmp1Update.Text = "Update";
            this.btnEmp1Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmp1Update.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnEmp1Update.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // txtEmp1_email
            // 
            this.txtEmp1_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmp1_email.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmp1_email.Location = new System.Drawing.Point(638, 240);
            this.txtEmp1_email.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmp1_email.Name = "txtEmp1_email";
            this.txtEmp1_email.Size = new System.Drawing.Size(196, 23);
            this.txtEmp1_email.TabIndex = 21;
            this.txtEmp1_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmp1_email.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtEmp_nic
            // 
            this.txtEmp_nic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmp_nic.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmp_nic.Location = new System.Drawing.Point(638, 85);
            this.txtEmp_nic.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmp_nic.Name = "txtEmp_nic";
            this.txtEmp_nic.Size = new System.Drawing.Size(196, 23);
            this.txtEmp_nic.TabIndex = 21;
            this.txtEmp_nic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmp_nic.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(524, 318);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(46, 25);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "Post";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(524, 240);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "E-mail";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtEmp1_phone
            // 
            this.txtEmp1_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmp1_phone.BackColor = System.Drawing.Color.White;
            this.txtEmp1_phone.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmp1_phone.ForeColor = System.Drawing.Color.White;
            this.txtEmp1_phone.Location = new System.Drawing.Point(638, 163);
            this.txtEmp1_phone.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmp1_phone.Name = "txtEmp1_phone";
            this.txtEmp1_phone.Size = new System.Drawing.Size(196, 23);
            this.txtEmp1_phone.TabIndex = 22;
            this.txtEmp1_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmp1_phone.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(524, 87);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(41, 25);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel10.TabIndex = 19;
            this.metroLabel10.Text = "NIC";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(524, 166);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Phone";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnEmp1_save
            // 
            this.btnEmp1_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmp1_save.Location = new System.Drawing.Point(1072, 98);
            this.btnEmp1_save.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmp1_save.Name = "btnEmp1_save";
            this.btnEmp1_save.Size = new System.Drawing.Size(80, 27);
            this.btnEmp1_save.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnEmp1_save.TabIndex = 18;
            this.btnEmp1_save.Text = "Save";
            this.btnEmp1_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmp1_save.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnEmp1_save.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnEmp1_save.Click += new System.EventHandler(this.btnEmp1_save_Click);
            // 
            // btnEmp1_clear
            // 
            this.btnEmp1_clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmp1_clear.Location = new System.Drawing.Point(1072, 217);
            this.btnEmp1_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmp1_clear.Name = "btnEmp1_clear";
            this.btnEmp1_clear.Size = new System.Drawing.Size(75, 27);
            this.btnEmp1_clear.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnEmp1_clear.TabIndex = 17;
            this.btnEmp1_clear.Text = "Clear";
            this.btnEmp1_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmp1_clear.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmp1_clear.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnEmp1_clear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // cmbEmp1_post
            // 
            this.cmbEmp1_post.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEmp1_post.FormattingEnabled = true;
            this.cmbEmp1_post.ItemHeight = 23;
            this.cmbEmp1_post.Items.AddRange(new object[] {
            "Trainer",
            "Manager",
            "Receptionist"});
            this.cmbEmp1_post.Location = new System.Drawing.Point(638, 318);
            this.cmbEmp1_post.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEmp1_post.Name = "cmbEmp1_post";
            this.cmbEmp1_post.Size = new System.Drawing.Size(132, 29);
            this.cmbEmp1_post.Style = MetroFramework.MetroColorStyle.Teal;
            this.cmbEmp1_post.TabIndex = 16;
            this.cmbEmp1_post.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cmbEmp1_gender
            // 
            this.cmbEmp1_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEmp1_gender.FormattingEnabled = true;
            this.cmbEmp1_gender.ItemHeight = 23;
            this.cmbEmp1_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbEmp1_gender.Location = new System.Drawing.Point(166, 236);
            this.cmbEmp1_gender.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEmp1_gender.Name = "cmbEmp1_gender";
            this.cmbEmp1_gender.Size = new System.Drawing.Size(132, 29);
            this.cmbEmp1_gender.Style = MetroFramework.MetroColorStyle.Teal;
            this.cmbEmp1_gender.TabIndex = 16;
            this.cmbEmp1_gender.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_emp1_browse
            // 
            this.btn_emp1_browse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_emp1_browse.Location = new System.Drawing.Point(883, 304);
            this.btn_emp1_browse.Margin = new System.Windows.Forms.Padding(2);
            this.btn_emp1_browse.Name = "btn_emp1_browse";
            this.btn_emp1_browse.Size = new System.Drawing.Size(94, 27);
            this.btn_emp1_browse.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_emp1_browse.TabIndex = 15;
            this.btn_emp1_browse.Text = "Browse";
            this.btn_emp1_browse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_emp1_browse.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_emp1_browse.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_emp1_browse.Click += new System.EventHandler(this.btn_emp1_browse_Click);
            // 
            // picuturebox_emp1
            // 
            this.picuturebox_emp1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picuturebox_emp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.picuturebox_emp1.Location = new System.Drawing.Point(857, 114);
            this.picuturebox_emp1.Margin = new System.Windows.Forms.Padding(2);
            this.picuturebox_emp1.Name = "picuturebox_emp1";
            this.picuturebox_emp1.Size = new System.Drawing.Size(149, 168);
            this.picuturebox_emp1.TabIndex = 14;
            this.picuturebox_emp1.TabStop = false;
            // 
            // txtEmp1_resume
            // 
            this.txtEmp1_resume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmp1_resume.BackColor = System.Drawing.Color.White;
            this.txtEmp1_resume.CustomForeColor = true;
            this.txtEmp1_resume.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmp1_resume.ForeColor = System.Drawing.Color.White;
            this.txtEmp1_resume.Location = new System.Drawing.Point(638, 391);
            this.txtEmp1_resume.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmp1_resume.Name = "txtEmp1_resume";
            this.txtEmp1_resume.Size = new System.Drawing.Size(215, 23);
            this.txtEmp1_resume.TabIndex = 13;
            this.txtEmp1_resume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmp1_resume.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtEmp1_jdate
            // 
            this.txtEmp1_jdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmp1_jdate.BackColor = System.Drawing.Color.White;
            this.txtEmp1_jdate.CustomForeColor = true;
            this.txtEmp1_jdate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmp1_jdate.ForeColor = System.Drawing.Color.White;
            this.txtEmp1_jdate.Location = new System.Drawing.Point(166, 391);
            this.txtEmp1_jdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmp1_jdate.Name = "txtEmp1_jdate";
            this.txtEmp1_jdate.Size = new System.Drawing.Size(268, 23);
            this.txtEmp1_jdate.TabIndex = 13;
            this.txtEmp1_jdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmp1_jdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtEmp1_address
            // 
            this.txtEmp1_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmp1_address.BackColor = System.Drawing.Color.White;
            this.txtEmp1_address.CustomForeColor = true;
            this.txtEmp1_address.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmp1_address.ForeColor = System.Drawing.Color.White;
            this.txtEmp1_address.Location = new System.Drawing.Point(166, 318);
            this.txtEmp1_address.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmp1_address.Name = "txtEmp1_address";
            this.txtEmp1_address.Size = new System.Drawing.Size(268, 23);
            this.txtEmp1_address.TabIndex = 13;
            this.txtEmp1_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmp1_address.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(524, 391);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(74, 25);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "Résumé";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(56, 391);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(105, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Joined Date";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtEmp1_name
            // 
            this.txtEmp1_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmp1_name.BackColor = System.Drawing.Color.White;
            this.txtEmp1_name.CustomForeColor = true;
            this.txtEmp1_name.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmp1_name.ForeColor = System.Drawing.Color.White;
            this.txtEmp1_name.Location = new System.Drawing.Point(166, 87);
            this.txtEmp1_name.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmp1_name.Name = "txtEmp1_name";
            this.txtEmp1_name.Size = new System.Drawing.Size(268, 23);
            this.txtEmp1_name.TabIndex = 13;
            this.txtEmp1_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmp1_name.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(56, 318);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Address";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(56, 163);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "DOB";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(52, 240);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(69, 25);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel9.TabIndex = 11;
            this.metroLabel9.Text = "Gender";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(56, 87);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Name";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabAddEmployee
            // 
            this.tabAddEmployee.Controls.Add(this.btnClearempT2);
            this.tabAddEmployee.Controls.Add(this.btnSaveT2emp);
            this.tabAddEmployee.Controls.Add(this.txtStartTime);
            this.tabAddEmployee.Controls.Add(this.txtEmpIDatte);
            this.tabAddEmployee.Controls.Add(this.metroLabel13);
            this.tabAddEmployee.Controls.Add(this.metroLabel12);
            this.tabAddEmployee.HorizontalScrollbarBarColor = true;
            this.tabAddEmployee.HorizontalScrollbarSize = 8;
            this.tabAddEmployee.Location = new System.Drawing.Point(4, 74);
            this.tabAddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.tabAddEmployee.Name = "tabAddEmployee";
            this.tabAddEmployee.Size = new System.Drawing.Size(1239, 535);
            this.tabAddEmployee.TabIndex = 2;
            this.tabAddEmployee.Text = "Attendence";
            this.tabAddEmployee.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabAddEmployee.VerticalScrollbarBarColor = true;
            this.tabAddEmployee.VerticalScrollbarSize = 8;
            // 
            // btnClearempT2
            // 
            this.btnClearempT2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearempT2.Location = new System.Drawing.Point(1053, 224);
            this.btnClearempT2.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearempT2.Name = "btnClearempT2";
            this.btnClearempT2.Size = new System.Drawing.Size(94, 27);
            this.btnClearempT2.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnClearempT2.TabIndex = 22;
            this.btnClearempT2.Text = "Save";
            this.btnClearempT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClearempT2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnClearempT2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // btnSaveT2emp
            // 
            this.btnSaveT2emp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveT2emp.Location = new System.Drawing.Point(1053, 155);
            this.btnSaveT2emp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveT2emp.Name = "btnSaveT2emp";
            this.btnSaveT2emp.Size = new System.Drawing.Size(94, 27);
            this.btnSaveT2emp.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnSaveT2emp.TabIndex = 21;
            this.btnSaveT2emp.Text = "Save";
            this.btnSaveT2emp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveT2emp.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSaveT2emp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStartTime.BackColor = System.Drawing.Color.White;
            this.txtStartTime.CustomForeColor = true;
            this.txtStartTime.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtStartTime.ForeColor = System.Drawing.Color.White;
            this.txtStartTime.Location = new System.Drawing.Point(232, 177);
            this.txtStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(268, 23);
            this.txtStartTime.TabIndex = 20;
            this.txtStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtEmpIDatte
            // 
            this.txtEmpIDatte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmpIDatte.BackColor = System.Drawing.Color.White;
            this.txtEmpIDatte.CustomForeColor = true;
            this.txtEmpIDatte.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmpIDatte.ForeColor = System.Drawing.Color.White;
            this.txtEmpIDatte.Location = new System.Drawing.Point(232, 102);
            this.txtEmpIDatte.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpIDatte.Name = "txtEmpIDatte";
            this.txtEmpIDatte.Size = new System.Drawing.Size(268, 23);
            this.txtEmpIDatte.TabIndex = 20;
            this.txtEmpIDatte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmpIDatte.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel13
            // 
            this.metroLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(57, 175);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(91, 25);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel13.TabIndex = 19;
            this.metroLabel13.Text = "Start Time";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel12
            // 
            this.metroLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(57, 100);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(104, 25);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel12.TabIndex = 19;
            this.metroLabel12.Text = "Employe ID";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabSalary
            // 
            this.tabSalary.Controls.Add(this.metroTile1);
            this.tabSalary.Controls.Add(this.metroTextBox1);
            this.tabSalary.Controls.Add(this.metroLabel11);
            this.tabSalary.HorizontalScrollbarBarColor = true;
            this.tabSalary.Location = new System.Drawing.Point(4, 74);
            this.tabSalary.Name = "tabSalary";
            this.tabSalary.Size = new System.Drawing.Size(1239, 535);
            this.tabSalary.TabIndex = 3;
            this.tabSalary.Text = "Salary";
            this.tabSalary.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabSalary.VerticalScrollbarBarColor = true;
            this.tabSalary.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile1.Location = new System.Drawing.Point(986, 362);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(94, 27);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile1.TabIndex = 18;
            this.metroTile1.Text = "Browse";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTextBox1.BackColor = System.Drawing.Color.White;
            this.metroTextBox1.CustomForeColor = true;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.ForeColor = System.Drawing.Color.White;
            this.metroTextBox1.Location = new System.Drawing.Point(269, 145);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(268, 23);
            this.metroTextBox1.TabIndex = 17;
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(65, 105);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(59, 25);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel11.TabIndex = 16;
            this.metroLabel11.Text = "Name";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dateTimePickeremp
            // 
            this.dateTimePickeremp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickeremp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dateTimePickeremp.BorderRadius = 0;
            this.dateTimePickeremp.ForeColor = System.Drawing.Color.White;
            this.dateTimePickeremp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickeremp.FormatCustom = null;
            this.dateTimePickeremp.Location = new System.Drawing.Point(166, 159);
            this.dateTimePickeremp.Name = "dateTimePickeremp";
            this.dateTimePickeremp.Size = new System.Drawing.Size(268, 26);
            this.dateTimePickeremp.TabIndex = 27;
            this.dateTimePickeremp.Value = new System.DateTime(2017, 8, 20, 23, 58, 37, 205);
            // 
            // openFileDialogEmp
            // 
            this.openFileDialogEmp.FileName = "openFileDialog1";
            // 
            // Emplyee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 720);
            this.Controls.Add(this.employeeTabCntrl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Emplyee";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Emplyee_Load);
            this.employeeTabCntrl.ResumeLayout(false);
            this.tabAddEmp.ResumeLayout(false);
            this.tabAddEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuturebox_emp1)).EndInit();
            this.tabAddEmployee.ResumeLayout(false);
            this.tabAddEmployee.PerformLayout();
            this.tabSalary.ResumeLayout(false);
            this.tabSalary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl employeeTabCntrl;
        private MetroFramework.Controls.MetroTabPage tabAddEmp;
        private MetroFramework.Controls.MetroTile btnEmp1_save;
        private MetroFramework.Controls.MetroTile btnEmp1_clear;
        private MetroFramework.Controls.MetroComboBox cmbEmp1_gender;
        private MetroFramework.Controls.MetroTile btn_emp1_browse;
        private System.Windows.Forms.PictureBox picuturebox_emp1;
        private MetroFramework.Controls.MetroTextBox txtEmp1_name;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtEmp1_address;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtEmp1_email;
        private MetroFramework.Controls.MetroTextBox txtEmp_nic;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtEmp1_phone;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbEmp1_post;
        private MetroFramework.Controls.MetroTextBox txtEmp1_resume;
        private MetroFramework.Controls.MetroTextBox txtEmp1_jdate;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTile btnEmp1Search;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private MetroFramework.Controls.MetroTile btnEmp1Delete;
        private MetroFramework.Controls.MetroTile btnEmp1Update;
        private MetroFramework.Controls.MetroTabPage tabAddEmployee;
        private MetroFramework.Controls.MetroTabPage tabSalary;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTile btnClearempT2;
        private MetroFramework.Controls.MetroTile btnSaveT2emp;
        private MetroFramework.Controls.MetroTextBox txtStartTime;
        private MetroFramework.Controls.MetroTextBox txtEmpIDatte;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimePickeremp;
        private System.Windows.Forms.OpenFileDialog openFileDialogEmp;
    }
}