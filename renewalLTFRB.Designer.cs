namespace FinalGUI
{
    partial class renewalLTFRB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataLTFRB = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DECISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXPIRY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtExpiryDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtDecisionDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtUpdate = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbEx = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbPlate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbDec = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbcase = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPlateNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCaseNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLTFRB)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 62);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(446, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "LTFRB TRUCKS RENEWALS";
            // 
            // dataLTFRB
            // 
            this.dataLTFRB.AllowUserToAddRows = false;
            this.dataLTFRB.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataLTFRB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataLTFRB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLTFRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataLTFRB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLTFRB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataLTFRB.ColumnHeadersHeight = 30;
            this.dataLTFRB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataLTFRB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CASE,
            this.DECISION,
            this.PLATE,
            this.EXPIRY,
            this.Update_});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataLTFRB.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataLTFRB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataLTFRB.Location = new System.Drawing.Point(14, 130);
            this.dataLTFRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataLTFRB.Name = "dataLTFRB";
            this.dataLTFRB.ReadOnly = true;
            this.dataLTFRB.RowHeadersVisible = false;
            this.dataLTFRB.RowHeadersWidth = 49;
            this.dataLTFRB.RowTemplate.Height = 24;
            this.dataLTFRB.Size = new System.Drawing.Size(1234, 397);
            this.dataLTFRB.TabIndex = 6;
            this.dataLTFRB.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataLTFRB.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataLTFRB.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataLTFRB.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataLTFRB.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataLTFRB.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataLTFRB.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataLTFRB.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataLTFRB.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataLTFRB.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLTFRB.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataLTFRB.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataLTFRB.ThemeStyle.HeaderStyle.Height = 30;
            this.dataLTFRB.ThemeStyle.ReadOnly = true;
            this.dataLTFRB.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataLTFRB.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataLTFRB.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLTFRB.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataLTFRB.ThemeStyle.RowsStyle.Height = 24;
            this.dataLTFRB.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataLTFRB.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataLTFRB.SelectionChanged += new System.EventHandler(this.dataLTFRB_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CASE
            // 
            this.CASE.HeaderText = "CASE NUMBER";
            this.CASE.MinimumWidth = 6;
            this.CASE.Name = "CASE";
            this.CASE.ReadOnly = true;
            // 
            // DECISION
            // 
            this.DECISION.HeaderText = "DECISION DATE";
            this.DECISION.MinimumWidth = 6;
            this.DECISION.Name = "DECISION";
            this.DECISION.ReadOnly = true;
            // 
            // PLATE
            // 
            this.PLATE.HeaderText = "PLATE NUMBER";
            this.PLATE.MinimumWidth = 6;
            this.PLATE.Name = "PLATE";
            this.PLATE.ReadOnly = true;
            // 
            // EXPIRY
            // 
            this.EXPIRY.HeaderText = "EXPIRY DATE";
            this.EXPIRY.MinimumWidth = 6;
            this.EXPIRY.Name = "EXPIRY";
            this.EXPIRY.ReadOnly = true;
            // 
            // Update_
            // 
            this.Update_.HeaderText = "Update";
            this.Update_.MinimumWidth = 6;
            this.Update_.Name = "Update_";
            this.Update_.ReadOnly = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 10;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(405, 733);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.PressedColor = System.Drawing.Color.DimGray;
            this.btnClear.Size = new System.Drawing.Size(70, 37);
            this.btnClear.TabIndex = 160;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(479, 733);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedColor = System.Drawing.Color.DimGray;
            this.btnRefresh.Size = new System.Drawing.Size(82, 37);
            this.btnRefresh.TabIndex = 159;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(760, 733);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedColor = System.Drawing.Color.DimGray;
            this.btnDelete.Size = new System.Drawing.Size(93, 37);
            this.btnDelete.TabIndex = 158;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(662, 733);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedColor = System.Drawing.Color.DimGray;
            this.btnUpdate.Size = new System.Drawing.Size(93, 37);
            this.btnUpdate.TabIndex = 157;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(565, 733);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.DimGray;
            this.btnAdd.Size = new System.Drawing.Size(93, 37);
            this.btnAdd.TabIndex = 156;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.txtSearch.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(984, 98);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(189, 27);
            this.txtSearch.TabIndex = 161;
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
            this.btnSearch.Location = new System.Drawing.Point(1178, 99);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedColor = System.Drawing.Color.DimGray;
            this.btnSearch.Size = new System.Drawing.Size(70, 27);
            this.btnSearch.TabIndex = 162;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtExpiryDate.BorderThickness = 2;
            this.txtExpiryDate.Checked = true;
            this.txtExpiryDate.CustomFormat = "yyyy-MM-dd";
            this.txtExpiryDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtExpiryDate.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpiryDate.ForeColor = System.Drawing.Color.White;
            this.txtExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtExpiryDate.Location = new System.Drawing.Point(799, 111);
            this.txtExpiryDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExpiryDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtExpiryDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(221, 25);
            this.txtExpiryDate.TabIndex = 172;
            this.txtExpiryDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExpiryDate.Value = new System.DateTime(2024, 4, 1, 0, 0, 0, 0);
            // 
            // txtDecisionDate
            // 
            this.txtDecisionDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDecisionDate.BorderThickness = 2;
            this.txtDecisionDate.Checked = true;
            this.txtDecisionDate.CustomFormat = "yyyy-MM-dd";
            this.txtDecisionDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtDecisionDate.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecisionDate.ForeColor = System.Drawing.Color.White;
            this.txtDecisionDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtDecisionDate.Location = new System.Drawing.Point(322, 109);
            this.txtDecisionDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDecisionDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDecisionDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDecisionDate.Name = "txtDecisionDate";
            this.txtDecisionDate.Size = new System.Drawing.Size(221, 28);
            this.txtDecisionDate.TabIndex = 171;
            this.txtDecisionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDecisionDate.Value = new System.DateTime(2024, 4, 1, 0, 0, 0, 0);
            // 
            // txtUpdate
            // 
            this.txtUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUpdate.BorderColor = System.Drawing.Color.Black;
            this.txtUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdate.DefaultText = "";
            this.txtUpdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdate.Enabled = false;
            this.txtUpdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdate.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdate.ForeColor = System.Drawing.Color.Black;
            this.txtUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdate.Location = new System.Drawing.Point(1069, 109);
            this.txtUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.PasswordChar = '\0';
            this.txtUpdate.PlaceholderText = "";
            this.txtUpdate.SelectedText = "";
            this.txtUpdate.Size = new System.Drawing.Size(139, 28);
            this.txtUpdate.TabIndex = 170;
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(1115, 81);
            this.guna2HtmlLabel17.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(53, 24);
            this.guna2HtmlLabel17.TabIndex = 169;
            this.guna2HtmlLabel17.Text = "Update";
            // 
            // lbEx
            // 
            this.lbEx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbEx.BackColor = System.Drawing.Color.Transparent;
            this.lbEx.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEx.Location = new System.Drawing.Point(859, 83);
            this.lbEx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbEx.Name = "lbEx";
            this.lbEx.Size = new System.Drawing.Size(83, 24);
            this.lbEx.TabIndex = 168;
            this.lbEx.Text = "Expiry Date";
            // 
            // lbPlate
            // 
            this.lbPlate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbPlate.BackColor = System.Drawing.Color.Transparent;
            this.lbPlate.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlate.Location = new System.Drawing.Point(622, 82);
            this.lbPlate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbPlate.Name = "lbPlate";
            this.lbPlate.Size = new System.Drawing.Size(97, 24);
            this.lbPlate.TabIndex = 167;
            this.lbPlate.Text = "Plate Number";
            // 
            // lbDec
            // 
            this.lbDec.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbDec.BackColor = System.Drawing.Color.Transparent;
            this.lbDec.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDec.Location = new System.Drawing.Point(385, 83);
            this.lbDec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbDec.Name = "lbDec";
            this.lbDec.Size = new System.Drawing.Size(100, 24);
            this.lbDec.TabIndex = 166;
            this.lbDec.Text = "Decision Date";
            // 
            // lbcase
            // 
            this.lbcase.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbcase.BackColor = System.Drawing.Color.Transparent;
            this.lbcase.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcase.Location = new System.Drawing.Point(154, 82);
            this.lbcase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbcase.Name = "lbcase";
            this.lbcase.Size = new System.Drawing.Size(97, 24);
            this.lbcase.TabIndex = 165;
            this.lbcase.Text = "Case Number";
            // 
            // txtPlateNum
            // 
            this.txtPlateNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPlateNum.BorderColor = System.Drawing.Color.Black;
            this.txtPlateNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlateNum.DefaultText = "";
            this.txtPlateNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlateNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlateNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlateNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlateNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlateNum.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlateNum.ForeColor = System.Drawing.Color.Black;
            this.txtPlateNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlateNum.Location = new System.Drawing.Point(581, 111);
            this.txtPlateNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPlateNum.Name = "txtPlateNum";
            this.txtPlateNum.PasswordChar = '\0';
            this.txtPlateNum.PlaceholderText = "";
            this.txtPlateNum.SelectedText = "";
            this.txtPlateNum.Size = new System.Drawing.Size(172, 25);
            this.txtPlateNum.TabIndex = 164;
            // 
            // txtCaseNum
            // 
            this.txtCaseNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCaseNum.BorderColor = System.Drawing.Color.Black;
            this.txtCaseNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCaseNum.DefaultText = "";
            this.txtCaseNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCaseNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCaseNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCaseNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCaseNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCaseNum.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaseNum.ForeColor = System.Drawing.Color.Black;
            this.txtCaseNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCaseNum.Location = new System.Drawing.Point(116, 109);
            this.txtCaseNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCaseNum.Name = "txtCaseNum";
            this.txtCaseNum.PasswordChar = '\0';
            this.txtCaseNum.PlaceholderText = "";
            this.txtCaseNum.SelectedText = "";
            this.txtCaseNum.Size = new System.Drawing.Size(172, 28);
            this.txtCaseNum.TabIndex = 163;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(40, 81);
            this.guna2HtmlLabel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(18, 24);
            this.guna2HtmlLabel7.TabIndex = 174;
            this.guna2HtmlLabel7.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtID.BorderColor = System.Drawing.Color.Black;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.Enabled = false;
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(27, 109);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(47, 28);
            this.txtID.TabIndex = 173;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.guna2GroupBox1.Controls.Add(this.txtExpiryDate);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2GroupBox1.Controls.Add(this.txtCaseNum);
            this.guna2GroupBox1.Controls.Add(this.txtID);
            this.guna2GroupBox1.Controls.Add(this.txtPlateNum);
            this.guna2GroupBox1.Controls.Add(this.lbcase);
            this.guna2GroupBox1.Controls.Add(this.txtDecisionDate);
            this.guna2GroupBox1.Controls.Add(this.lbDec);
            this.guna2GroupBox1.Controls.Add(this.txtUpdate);
            this.guna2GroupBox1.Controls.Add(this.lbPlate);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel17);
            this.guna2GroupBox1.Controls.Add(this.lbEx);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(14, 531);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1234, 198);
            this.guna2GroupBox1.TabIndex = 196;
            this.guna2GroupBox1.Text = "LTFRB";
            // 
            // renewalLTFRB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 801);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataLTFRB);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "renewalLTFRB";
            this.Text = "renewalLTFRB";
            this.Load += new System.EventHandler(this.renewalLTFRB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLTFRB)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dataLTFRB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DECISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXPIRY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Update_;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtExpiryDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtDecisionDate;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbEx;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbPlate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbDec;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbcase;
        private Guna.UI2.WinForms.Guna2TextBox txtPlateNum;
        private Guna.UI2.WinForms.Guna2TextBox txtCaseNum;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
    }
}