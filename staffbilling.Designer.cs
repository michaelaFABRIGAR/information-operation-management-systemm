namespace FinalGUI
{
    partial class staffbilling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataBilling = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPANY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PART = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GROSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WTAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMOUNTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VOUCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtVdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtcompanyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbsNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtParticulars = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtwithTax = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtGross = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtamountDue = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtVat = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtdrNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTinNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNet = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBilling)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 62);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(546, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "BILLING";
            // 
            // dataBilling
            // 
            this.dataBilling.AllowUserToAddRows = false;
            this.dataBilling.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataBilling.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataBilling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBilling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataBilling.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBilling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataBilling.ColumnHeadersHeight = 50;
            this.dataBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataBilling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.bs,
            this.date,
            this.COMPANY,
            this.TIN,
            this.PART,
            this.GROSS,
            this.VAT,
            this.NET,
            this.WTAX,
            this.AMOUNTD,
            this.DR,
            this.VOUCH});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataBilling.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataBilling.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataBilling.Location = new System.Drawing.Point(38, 140);
            this.dataBilling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataBilling.Name = "dataBilling";
            this.dataBilling.ReadOnly = true;
            this.dataBilling.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataBilling.RowHeadersVisible = false;
            this.dataBilling.RowHeadersWidth = 49;
            this.dataBilling.RowTemplate.Height = 24;
            this.dataBilling.Size = new System.Drawing.Size(1173, 258);
            this.dataBilling.TabIndex = 39;
            this.dataBilling.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataBilling.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataBilling.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataBilling.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataBilling.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataBilling.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataBilling.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataBilling.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataBilling.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataBilling.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBilling.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataBilling.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataBilling.ThemeStyle.HeaderStyle.Height = 50;
            this.dataBilling.ThemeStyle.ReadOnly = true;
            this.dataBilling.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataBilling.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataBilling.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBilling.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataBilling.ThemeStyle.RowsStyle.Height = 24;
            this.dataBilling.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataBilling.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataBilling.SelectionChanged += new System.EventHandler(this.dataBilling_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // bs
            // 
            this.bs.HeaderText = "BS Number";
            this.bs.MinimumWidth = 6;
            this.bs.Name = "bs";
            this.bs.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "DATE";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // COMPANY
            // 
            this.COMPANY.HeaderText = "COMPANY NAME";
            this.COMPANY.MinimumWidth = 6;
            this.COMPANY.Name = "COMPANY";
            this.COMPANY.ReadOnly = true;
            // 
            // TIN
            // 
            this.TIN.HeaderText = "TIN NUMBER";
            this.TIN.MinimumWidth = 6;
            this.TIN.Name = "TIN";
            this.TIN.ReadOnly = true;
            // 
            // PART
            // 
            this.PART.HeaderText = "PARTICULARS";
            this.PART.MinimumWidth = 6;
            this.PART.Name = "PART";
            this.PART.ReadOnly = true;
            // 
            // GROSS
            // 
            this.GROSS.HeaderText = "GROSS";
            this.GROSS.MinimumWidth = 6;
            this.GROSS.Name = "GROSS";
            this.GROSS.ReadOnly = true;
            // 
            // VAT
            // 
            this.VAT.HeaderText = "VAT";
            this.VAT.MinimumWidth = 6;
            this.VAT.Name = "VAT";
            this.VAT.ReadOnly = true;
            // 
            // NET
            // 
            this.NET.HeaderText = "NET";
            this.NET.MinimumWidth = 6;
            this.NET.Name = "NET";
            this.NET.ReadOnly = true;
            // 
            // WTAX
            // 
            this.WTAX.HeaderText = "W/TAX";
            this.WTAX.MinimumWidth = 6;
            this.WTAX.Name = "WTAX";
            this.WTAX.ReadOnly = true;
            // 
            // AMOUNTD
            // 
            this.AMOUNTD.HeaderText = "AMOUNT DUE";
            this.AMOUNTD.MinimumWidth = 6;
            this.AMOUNTD.Name = "AMOUNTD";
            this.AMOUNTD.ReadOnly = true;
            // 
            // DR
            // 
            this.DR.HeaderText = "DR NUMBER";
            this.DR.MinimumWidth = 6;
            this.DR.Name = "DR";
            this.DR.ReadOnly = true;
            // 
            // VOUCH
            // 
            this.VOUCH.HeaderText = "VOUCHER DATE";
            this.VOUCH.MinimumWidth = 6;
            this.VOUCH.Name = "VOUCH";
            this.VOUCH.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(948, 108);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(189, 27);
            this.txtSearch.TabIndex = 146;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnSearch.Font = new System.Drawing.Font("Arial", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1142, 108);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedColor = System.Drawing.Color.DimGray;
            this.btnSearch.Size = new System.Drawing.Size(70, 27);
            this.btnSearch.TabIndex = 153;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDate
            // 
            this.txtDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDate.Checked = true;
            this.txtDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtDate.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtDate.Location = new System.Drawing.Point(333, 30);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(201, 37);
            this.txtDate.TabIndex = 177;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.Value = new System.DateTime(2024, 4, 6, 19, 24, 7, 153);
            // 
            // txtVdate
            // 
            this.txtVdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtVdate.Checked = true;
            this.txtVdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtVdate.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVdate.ForeColor = System.Drawing.Color.White;
            this.txtVdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtVdate.Location = new System.Drawing.Point(875, 174);
            this.txtVdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtVdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtVdate.Name = "txtVdate";
            this.txtVdate.Size = new System.Drawing.Size(187, 34);
            this.txtVdate.TabIndex = 176;
            this.txtVdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVdate.Value = new System.DateTime(2024, 4, 6, 19, 24, 7, 153);
            // 
            // txtcompanyName
            // 
            this.txtcompanyName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtcompanyName.BorderColor = System.Drawing.Color.Black;
            this.txtcompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcompanyName.DefaultText = "";
            this.txtcompanyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcompanyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcompanyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcompanyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcompanyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcompanyName.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompanyName.ForeColor = System.Drawing.Color.Black;
            this.txtcompanyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcompanyName.Location = new System.Drawing.Point(613, 32);
            this.txtcompanyName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtcompanyName.Name = "txtcompanyName";
            this.txtcompanyName.PasswordChar = '\0';
            this.txtcompanyName.PlaceholderText = "";
            this.txtcompanyName.SelectedText = "";
            this.txtcompanyName.Size = new System.Drawing.Size(187, 35);
            this.txtcompanyName.TabIndex = 159;
            // 
            // txtbsNum
            // 
            this.txtbsNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtbsNum.BorderColor = System.Drawing.Color.Black;
            this.txtbsNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbsNum.DefaultText = "";
            this.txtbsNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbsNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbsNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbsNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbsNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbsNum.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbsNum.ForeColor = System.Drawing.Color.Black;
            this.txtbsNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbsNum.Location = new System.Drawing.Point(59, 30);
            this.txtbsNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtbsNum.Name = "txtbsNum";
            this.txtbsNum.PasswordChar = '\0';
            this.txtbsNum.PlaceholderText = "";
            this.txtbsNum.SelectedText = "";
            this.txtbsNum.Size = new System.Drawing.Size(186, 37);
            this.txtbsNum.TabIndex = 154;
            // 
            // txtParticulars
            // 
            this.txtParticulars.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtParticulars.BorderColor = System.Drawing.Color.Black;
            this.txtParticulars.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtParticulars.DefaultText = "";
            this.txtParticulars.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtParticulars.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtParticulars.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtParticulars.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtParticulars.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtParticulars.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticulars.ForeColor = System.Drawing.Color.Black;
            this.txtParticulars.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtParticulars.Location = new System.Drawing.Point(59, 103);
            this.txtParticulars.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtParticulars.Name = "txtParticulars";
            this.txtParticulars.PasswordChar = '\0';
            this.txtParticulars.PlaceholderText = "";
            this.txtParticulars.SelectedText = "";
            this.txtParticulars.Size = new System.Drawing.Size(186, 37);
            this.txtParticulars.TabIndex = 155;
            // 
            // txtwithTax
            // 
            this.txtwithTax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtwithTax.BorderColor = System.Drawing.Color.Black;
            this.txtwithTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtwithTax.DefaultText = "";
            this.txtwithTax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtwithTax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtwithTax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtwithTax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtwithTax.Enabled = false;
            this.txtwithTax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtwithTax.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwithTax.ForeColor = System.Drawing.Color.Black;
            this.txtwithTax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtwithTax.Location = new System.Drawing.Point(59, 171);
            this.txtwithTax.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtwithTax.Name = "txtwithTax";
            this.txtwithTax.PasswordChar = '\0';
            this.txtwithTax.PlaceholderText = "";
            this.txtwithTax.SelectedText = "";
            this.txtwithTax.Size = new System.Drawing.Size(186, 37);
            this.txtwithTax.TabIndex = 156;
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(931, 148);
            this.guna2HtmlLabel12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(98, 24);
            this.guna2HtmlLabel12.TabIndex = 175;
            this.guna2HtmlLabel12.Text = "Voucher Date";
            // 
            // txtGross
            // 
            this.txtGross.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtGross.BorderColor = System.Drawing.Color.Black;
            this.txtGross.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGross.DefaultText = "";
            this.txtGross.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGross.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGross.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGross.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGross.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGross.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGross.ForeColor = System.Drawing.Color.Black;
            this.txtGross.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGross.Location = new System.Drawing.Point(335, 103);
            this.txtGross.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGross.Name = "txtGross";
            this.txtGross.PasswordChar = '\0';
            this.txtGross.PlaceholderText = "";
            this.txtGross.SelectedText = "";
            this.txtGross.Size = new System.Drawing.Size(199, 37);
            this.txtGross.TabIndex = 157;
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(955, 75);
            this.guna2HtmlLabel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(33, 24);
            this.guna2HtmlLabel11.TabIndex = 174;
            this.guna2HtmlLabel11.Text = "NET";
            // 
            // txtamountDue
            // 
            this.txtamountDue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtamountDue.BorderColor = System.Drawing.Color.Black;
            this.txtamountDue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtamountDue.DefaultText = "";
            this.txtamountDue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtamountDue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtamountDue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtamountDue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtamountDue.Enabled = false;
            this.txtamountDue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtamountDue.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamountDue.ForeColor = System.Drawing.Color.Black;
            this.txtamountDue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtamountDue.Location = new System.Drawing.Point(335, 171);
            this.txtamountDue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtamountDue.Name = "txtamountDue";
            this.txtamountDue.PasswordChar = '\0';
            this.txtamountDue.PlaceholderText = "";
            this.txtamountDue.SelectedText = "";
            this.txtamountDue.Size = new System.Drawing.Size(199, 37);
            this.txtamountDue.TabIndex = 158;
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(951, 2);
            this.guna2HtmlLabel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(37, 24);
            this.guna2HtmlLabel10.TabIndex = 173;
            this.guna2HtmlLabel10.Text = "Tin #";
            // 
            // txtVat
            // 
            this.txtVat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtVat.BorderColor = System.Drawing.Color.Black;
            this.txtVat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVat.DefaultText = "";
            this.txtVat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVat.Enabled = false;
            this.txtVat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVat.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.ForeColor = System.Drawing.Color.Black;
            this.txtVat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVat.Location = new System.Drawing.Point(613, 105);
            this.txtVat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVat.Name = "txtVat";
            this.txtVat.PasswordChar = '\0';
            this.txtVat.PlaceholderText = "";
            this.txtVat.SelectedText = "";
            this.txtVat.Size = new System.Drawing.Size(187, 35);
            this.txtVat.TabIndex = 160;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(687, 149);
            this.guna2HtmlLabel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(37, 24);
            this.guna2HtmlLabel9.TabIndex = 172;
            this.guna2HtmlLabel9.Text = "DR #";
            // 
            // txtdrNum
            // 
            this.txtdrNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtdrNum.BorderColor = System.Drawing.Color.Black;
            this.txtdrNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdrNum.DefaultText = "";
            this.txtdrNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdrNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdrNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdrNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdrNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdrNum.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdrNum.ForeColor = System.Drawing.Color.Black;
            this.txtdrNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdrNum.Location = new System.Drawing.Point(613, 174);
            this.txtdrNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtdrNum.Name = "txtdrNum";
            this.txtdrNum.PasswordChar = '\0';
            this.txtdrNum.PlaceholderText = "";
            this.txtdrNum.SelectedText = "";
            this.txtdrNum.Size = new System.Drawing.Size(187, 34);
            this.txtdrNum.TabIndex = 161;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(687, 78);
            this.guna2HtmlLabel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(33, 24);
            this.guna2HtmlLabel8.TabIndex = 171;
            this.guna2HtmlLabel8.Text = "VAT";
            // 
            // txtTinNum
            // 
            this.txtTinNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTinNum.BorderColor = System.Drawing.Color.Black;
            this.txtTinNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTinNum.DefaultText = "";
            this.txtTinNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTinNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTinNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTinNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTinNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTinNum.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinNum.ForeColor = System.Drawing.Color.Black;
            this.txtTinNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTinNum.Location = new System.Drawing.Point(875, 30);
            this.txtTinNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTinNum.Name = "txtTinNum";
            this.txtTinNum.PasswordChar = '\0';
            this.txtTinNum.PlaceholderText = "";
            this.txtTinNum.SelectedText = "";
            this.txtTinNum.Size = new System.Drawing.Size(187, 37);
            this.txtTinNum.TabIndex = 162;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(652, 3);
            this.guna2HtmlLabel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(112, 24);
            this.guna2HtmlLabel7.TabIndex = 170;
            this.guna2HtmlLabel7.Text = "Company Name";
            // 
            // txtNet
            // 
            this.txtNet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNet.BorderColor = System.Drawing.Color.Black;
            this.txtNet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNet.DefaultText = "";
            this.txtNet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNet.Enabled = false;
            this.txtNet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNet.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNet.ForeColor = System.Drawing.Color.Black;
            this.txtNet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNet.Location = new System.Drawing.Point(875, 103);
            this.txtNet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNet.Name = "txtNet";
            this.txtNet.PasswordChar = '\0';
            this.txtNet.PlaceholderText = "";
            this.txtNet.SelectedText = "";
            this.txtNet.Size = new System.Drawing.Size(187, 37);
            this.txtNet.TabIndex = 163;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(391, 145);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(90, 24);
            this.guna2HtmlLabel6.TabIndex = 169;
            this.guna2HtmlLabel6.Text = "Amount Due";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(410, 75);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(45, 24);
            this.guna2HtmlLabel5.TabIndex = 168;
            this.guna2HtmlLabel5.Text = "Gross";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(125, 2);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(36, 24);
            this.guna2HtmlLabel1.TabIndex = 164;
            this.guna2HtmlLabel1.Text = "BS #";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(391, 1);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(35, 24);
            this.guna2HtmlLabel4.TabIndex = 167;
            this.guna2HtmlLabel4.Text = "Date";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(105, 75);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(79, 24);
            this.guna2HtmlLabel2.TabIndex = 165;
            this.guna2HtmlLabel2.Text = "Particulars";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(115, 144);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(44, 24);
            this.guna2HtmlLabel3.TabIndex = 166;
            this.guna2HtmlLabel3.Text = "W/Tax";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(734, 708);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedColor = System.Drawing.Color.DimGray;
            this.btnDelete.Size = new System.Drawing.Size(135, 37);
            this.btnDelete.TabIndex = 180;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(596, 708);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedColor = System.Drawing.Color.DimGray;
            this.btnUpdate.Size = new System.Drawing.Size(135, 37);
            this.btnUpdate.TabIndex = 179;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(457, 708);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.DimGray;
            this.btnAdd.Size = new System.Drawing.Size(135, 37);
            this.btnAdd.TabIndex = 178;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtID
            // 
            this.txtID.BorderColor = System.Drawing.Color.Black;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.Enabled = false;
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(38, 108);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(67, 27);
            this.txtID.TabIndex = 181;
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(38, 80);
            this.guna2HtmlLabel13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(18, 24);
            this.guna2HtmlLabel13.TabIndex = 182;
            this.guna2HtmlLabel13.Text = "ID";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.BorderRadius = 10;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(258, 708);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.PressedColor = System.Drawing.Color.DimGray;
            this.btnClear.Size = new System.Drawing.Size(135, 37);
            this.btnClear.TabIndex = 183;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Controls.Add(this.txtVdate);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtDate);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtNet);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtcompanyName);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtTinNum);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtbsNum);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtParticulars);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtdrNum);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtwithTax);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel9);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel12);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtVat);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtGross);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel10);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel11);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtamountDue);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(38, 441);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1173, 220);
            this.guna2CustomGradientPanel1.TabIndex = 184;
            // 
            // billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 765);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.guna2HtmlLabel13);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataBilling);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "billing";
            this.Text = "billing";
            this.Load += new System.EventHandler(this.billing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBilling)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dataBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPANY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PART;
        private System.Windows.Forms.DataGridViewTextBoxColumn GROSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NET;
        private System.Windows.Forms.DataGridViewTextBoxColumn WTAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DR;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOUCH;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtVdate;
        private Guna.UI2.WinForms.Guna2TextBox txtcompanyName;
        private Guna.UI2.WinForms.Guna2TextBox txtbsNum;
        private Guna.UI2.WinForms.Guna2TextBox txtParticulars;
        private Guna.UI2.WinForms.Guna2TextBox txtwithTax;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2TextBox txtGross;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2TextBox txtamountDue;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2TextBox txtVat;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2TextBox txtdrNum;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2TextBox txtTinNum;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txtNet;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
    }
}