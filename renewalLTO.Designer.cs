namespace FinalGUI
{
    partial class renewalLTO
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
            this.dataLTOrenew = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEHICLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MVUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGISTERED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtORdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtDuedate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtUpdate = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtORnum = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRegName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtVehicleT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPlate = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.refresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLTOrenew)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 62);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(491, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "LTO TRUCKS RENEWALS";
            // 
            // dataLTOrenew
            // 
            this.dataLTOrenew.AllowUserToAddRows = false;
            this.dataLTOrenew.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataLTOrenew.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataLTOrenew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLTOrenew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataLTOrenew.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLTOrenew.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataLTOrenew.ColumnHeadersHeight = 50;
            this.dataLTOrenew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PLATE,
            this.VEHICLE,
            this.COLOR,
            this.MVUC,
            this.DUE,
            this.REGISTERED,
            this.OR,
            this.ORD,
            this.Update_});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataLTOrenew.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataLTOrenew.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataLTOrenew.Location = new System.Drawing.Point(40, 127);
            this.dataLTOrenew.Margin = new System.Windows.Forms.Padding(2);
            this.dataLTOrenew.Name = "dataLTOrenew";
            this.dataLTOrenew.ReadOnly = true;
            this.dataLTOrenew.RowHeadersVisible = false;
            this.dataLTOrenew.RowHeadersWidth = 49;
            this.dataLTOrenew.RowTemplate.Height = 24;
            this.dataLTOrenew.Size = new System.Drawing.Size(1172, 386);
            this.dataLTOrenew.TabIndex = 115;
            this.dataLTOrenew.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataLTOrenew.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataLTOrenew.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataLTOrenew.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataLTOrenew.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataLTOrenew.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataLTOrenew.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataLTOrenew.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataLTOrenew.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataLTOrenew.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLTOrenew.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataLTOrenew.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataLTOrenew.ThemeStyle.HeaderStyle.Height = 50;
            this.dataLTOrenew.ThemeStyle.ReadOnly = true;
            this.dataLTOrenew.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataLTOrenew.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataLTOrenew.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLTOrenew.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataLTOrenew.ThemeStyle.RowsStyle.Height = 24;
            this.dataLTOrenew.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataLTOrenew.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataLTOrenew.SelectionChanged += new System.EventHandler(this.dataLTOrenew_SelectionChanged);
            // 
            // ID
            // 
            this.ID.FillWeight = 25.38071F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // PLATE
            // 
            this.PLATE.FillWeight = 108.291F;
            this.PLATE.HeaderText = "Plate Number";
            this.PLATE.MinimumWidth = 6;
            this.PLATE.Name = "PLATE";
            this.PLATE.ReadOnly = true;
            // 
            // VEHICLE
            // 
            this.VEHICLE.FillWeight = 108.291F;
            this.VEHICLE.HeaderText = "Vehicle Type";
            this.VEHICLE.MinimumWidth = 6;
            this.VEHICLE.Name = "VEHICLE";
            this.VEHICLE.ReadOnly = true;
            // 
            // COLOR
            // 
            this.COLOR.FillWeight = 108.291F;
            this.COLOR.HeaderText = "Color";
            this.COLOR.MinimumWidth = 6;
            this.COLOR.Name = "COLOR";
            this.COLOR.ReadOnly = true;
            // 
            // MVUC
            // 
            this.MVUC.FillWeight = 108.291F;
            this.MVUC.HeaderText = "MVUC Rate";
            this.MVUC.MinimumWidth = 6;
            this.MVUC.Name = "MVUC";
            this.MVUC.ReadOnly = true;
            // 
            // DUE
            // 
            this.DUE.FillWeight = 108.291F;
            this.DUE.HeaderText = "Due Date";
            this.DUE.MinimumWidth = 6;
            this.DUE.Name = "DUE";
            this.DUE.ReadOnly = true;
            // 
            // REGISTERED
            // 
            this.REGISTERED.FillWeight = 108.291F;
            this.REGISTERED.HeaderText = "Registered Name";
            this.REGISTERED.MinimumWidth = 6;
            this.REGISTERED.Name = "REGISTERED";
            this.REGISTERED.ReadOnly = true;
            // 
            // OR
            // 
            this.OR.FillWeight = 108.291F;
            this.OR.HeaderText = "OR Number";
            this.OR.MinimumWidth = 6;
            this.OR.Name = "OR";
            this.OR.ReadOnly = true;
            // 
            // ORD
            // 
            this.ORD.FillWeight = 108.291F;
            this.ORD.HeaderText = "OR Date";
            this.ORD.MinimumWidth = 6;
            this.ORD.Name = "ORD";
            this.ORD.ReadOnly = true;
            // 
            // Update_
            // 
            this.Update_.FillWeight = 108.291F;
            this.Update_.HeaderText = "Update";
            this.Update_.MinimumWidth = 6;
            this.Update_.Name = "Update_";
            this.Update_.ReadOnly = true;
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
            this.txtSearch.Location = new System.Drawing.Point(948, 94);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(189, 27);
            this.txtSearch.TabIndex = 154;
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
            this.btnSearch.Location = new System.Drawing.Point(1142, 94);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedColor = System.Drawing.Color.DimGray;
            this.btnSearch.Size = new System.Drawing.Size(70, 27);
            this.btnSearch.TabIndex = 155;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(37, 50);
            this.guna2HtmlLabel10.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(18, 24);
            this.guna2HtmlLabel10.TabIndex = 176;
            this.guna2HtmlLabel10.Text = "ID";
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
            this.txtID.Location = new System.Drawing.Point(18, 78);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(60, 28);
            this.txtID.TabIndex = 175;
            // 
            // txtORdate
            // 
            this.txtORdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtORdate.Checked = true;
            this.txtORdate.CustomFormat = "yyyy-MM-dd";
            this.txtORdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtORdate.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtORdate.ForeColor = System.Drawing.Color.White;
            this.txtORdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtORdate.Location = new System.Drawing.Point(765, 143);
            this.txtORdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtORdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtORdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtORdate.Name = "txtORdate";
            this.txtORdate.Size = new System.Drawing.Size(194, 28);
            this.txtORdate.TabIndex = 174;
            this.txtORdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtORdate.Value = new System.DateTime(2024, 4, 1, 0, 0, 0, 0);
            // 
            // txtDuedate
            // 
            this.txtDuedate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDuedate.Checked = true;
            this.txtDuedate.CustomFormat = "yyyy-MM-dd";
            this.txtDuedate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtDuedate.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuedate.ForeColor = System.Drawing.Color.White;
            this.txtDuedate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtDuedate.Location = new System.Drawing.Point(18, 143);
            this.txtDuedate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDuedate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDuedate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDuedate.Name = "txtDuedate";
            this.txtDuedate.Size = new System.Drawing.Size(194, 28);
            this.txtDuedate.TabIndex = 173;
            this.txtDuedate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDuedate.Value = new System.DateTime(2024, 4, 1, 0, 0, 0, 0);
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
            this.txtUpdate.Location = new System.Drawing.Point(999, 143);
            this.txtUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.PasswordChar = '\0';
            this.txtUpdate.PlaceholderText = "";
            this.txtUpdate.SelectedText = "";
            this.txtUpdate.Size = new System.Drawing.Size(132, 28);
            this.txtUpdate.TabIndex = 172;
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(1045, 115);
            this.guna2HtmlLabel17.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(53, 24);
            this.guna2HtmlLabel17.TabIndex = 171;
            this.guna2HtmlLabel17.Text = "Update";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(831, 113);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(62, 24);
            this.guna2HtmlLabel6.TabIndex = 170;
            this.guna2HtmlLabel6.Text = "OR Date";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(556, 113);
            this.guna2HtmlLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(85, 24);
            this.guna2HtmlLabel7.TabIndex = 169;
            this.guna2HtmlLabel7.Text = "OR Number";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(280, 115);
            this.guna2HtmlLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(122, 24);
            this.guna2HtmlLabel8.TabIndex = 168;
            this.guna2HtmlLabel8.Text = "Registered Name";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(75, 115);
            this.guna2HtmlLabel9.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(67, 24);
            this.guna2HtmlLabel9.TabIndex = 167;
            this.guna2HtmlLabel9.Text = "Due Date";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(1003, 48);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(84, 24);
            this.guna2HtmlLabel4.TabIndex = 166;
            this.guna2HtmlLabel4.Text = "MVUC Rate";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(765, 48);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(42, 24);
            this.guna2HtmlLabel5.TabIndex = 165;
            this.guna2HtmlLabel5.Text = "Color";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(496, 48);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(92, 24);
            this.guna2HtmlLabel2.TabIndex = 164;
            this.guna2HtmlLabel2.Text = "Vehicle Type";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial Narrow", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(194, 48);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(97, 24);
            this.guna2HtmlLabel3.TabIndex = 163;
            this.guna2HtmlLabel3.Text = "Plate Number";
            // 
            // txtMRate
            // 
            this.txtMRate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtMRate.BorderColor = System.Drawing.Color.Black;
            this.txtMRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMRate.DefaultText = "";
            this.txtMRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMRate.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRate.ForeColor = System.Drawing.Color.Black;
            this.txtMRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMRate.Location = new System.Drawing.Point(937, 78);
            this.txtMRate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtMRate.Name = "txtMRate";
            this.txtMRate.PasswordChar = '\0';
            this.txtMRate.PlaceholderText = "";
            this.txtMRate.SelectedText = "";
            this.txtMRate.Size = new System.Drawing.Size(194, 28);
            this.txtMRate.TabIndex = 162;
            // 
            // txtORnum
            // 
            this.txtORnum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtORnum.BorderColor = System.Drawing.Color.Black;
            this.txtORnum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtORnum.DefaultText = "";
            this.txtORnum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtORnum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtORnum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtORnum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtORnum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtORnum.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtORnum.ForeColor = System.Drawing.Color.Black;
            this.txtORnum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtORnum.Location = new System.Drawing.Point(495, 143);
            this.txtORnum.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtORnum.Name = "txtORnum";
            this.txtORnum.PasswordChar = '\0';
            this.txtORnum.PlaceholderText = "";
            this.txtORnum.SelectedText = "";
            this.txtORnum.Size = new System.Drawing.Size(194, 28);
            this.txtORnum.TabIndex = 161;
            // 
            // txtColor
            // 
            this.txtColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtColor.BorderColor = System.Drawing.Color.Black;
            this.txtColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColor.DefaultText = "";
            this.txtColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColor.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.ForeColor = System.Drawing.Color.Black;
            this.txtColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColor.Location = new System.Drawing.Point(704, 78);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtColor.Name = "txtColor";
            this.txtColor.PasswordChar = '\0';
            this.txtColor.PlaceholderText = "";
            this.txtColor.SelectedText = "";
            this.txtColor.Size = new System.Drawing.Size(194, 28);
            this.txtColor.TabIndex = 160;
            // 
            // txtRegName
            // 
            this.txtRegName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtRegName.BorderColor = System.Drawing.Color.Black;
            this.txtRegName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegName.DefaultText = "";
            this.txtRegName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegName.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegName.ForeColor = System.Drawing.Color.Black;
            this.txtRegName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegName.Location = new System.Drawing.Point(239, 145);
            this.txtRegName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtRegName.Name = "txtRegName";
            this.txtRegName.PasswordChar = '\0';
            this.txtRegName.PlaceholderText = "";
            this.txtRegName.SelectedText = "";
            this.txtRegName.Size = new System.Drawing.Size(194, 28);
            this.txtRegName.TabIndex = 159;
            // 
            // txtVehicleT
            // 
            this.txtVehicleT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtVehicleT.BorderColor = System.Drawing.Color.Black;
            this.txtVehicleT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVehicleT.DefaultText = "";
            this.txtVehicleT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVehicleT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVehicleT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVehicleT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVehicleT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVehicleT.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleT.ForeColor = System.Drawing.Color.Black;
            this.txtVehicleT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVehicleT.Location = new System.Drawing.Point(442, 78);
            this.txtVehicleT.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtVehicleT.Name = "txtVehicleT";
            this.txtVehicleT.PasswordChar = '\0';
            this.txtVehicleT.PlaceholderText = "";
            this.txtVehicleT.SelectedText = "";
            this.txtVehicleT.Size = new System.Drawing.Size(194, 28);
            this.txtVehicleT.TabIndex = 158;
            // 
            // txtPlate
            // 
            this.txtPlate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPlate.BorderColor = System.Drawing.Color.Black;
            this.txtPlate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlate.DefaultText = "";
            this.txtPlate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlate.Enabled = false;
            this.txtPlate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlate.Font = new System.Drawing.Font("Arial Narrow", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlate.ForeColor = System.Drawing.Color.Black;
            this.txtPlate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlate.Location = new System.Drawing.Point(147, 78);
            this.txtPlate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.PasswordChar = '\0';
            this.txtPlate.PlaceholderText = "";
            this.txtPlate.SelectedText = "";
            this.txtPlate.Size = new System.Drawing.Size(194, 28);
            this.txtPlate.TabIndex = 157;
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
            this.btnClear.Font = new System.Drawing.Font("Arial", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(400, 719);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.PressedColor = System.Drawing.Color.DimGray;
            this.btnClear.Size = new System.Drawing.Size(93, 37);
            this.btnClear.TabIndex = 181;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // refresh
            // 
            this.refresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.BorderRadius = 10;
            this.refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.refresh.Font = new System.Drawing.Font("Arial", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Location = new System.Drawing.Point(497, 719);
            this.refresh.Margin = new System.Windows.Forms.Padding(2);
            this.refresh.Name = "refresh";
            this.refresh.PressedColor = System.Drawing.Color.DimGray;
            this.refresh.Size = new System.Drawing.Size(93, 37);
            this.refresh.TabIndex = 180;
            this.refresh.Text = "Refresh";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
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
            this.btnDelete.Font = new System.Drawing.Font("Arial", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(797, 719);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedColor = System.Drawing.Color.DimGray;
            this.btnDelete.Size = new System.Drawing.Size(93, 37);
            this.btnDelete.TabIndex = 179;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnEdit.Font = new System.Drawing.Font("Arial", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(693, 719);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PressedColor = System.Drawing.Color.DimGray;
            this.btnEdit.Size = new System.Drawing.Size(93, 37);
            this.btnEdit.TabIndex = 178;
            this.btnEdit.Text = "Update";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnAdd.Font = new System.Drawing.Font("Arial", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(596, 719);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.DimGray;
            this.btnAdd.Size = new System.Drawing.Size(93, 37);
            this.btnAdd.TabIndex = 177;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.guna2GroupBox1.Controls.Add(this.txtORdate);
            this.guna2GroupBox1.Controls.Add(this.txtPlate);
            this.guna2GroupBox1.Controls.Add(this.txtVehicleT);
            this.guna2GroupBox1.Controls.Add(this.txtRegName);
            this.guna2GroupBox1.Controls.Add(this.txtColor);
            this.guna2GroupBox1.Controls.Add(this.txtORnum);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel10);
            this.guna2GroupBox1.Controls.Add(this.txtMRate);
            this.guna2GroupBox1.Controls.Add(this.txtID);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.txtDuedate);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GroupBox1.Controls.Add(this.txtUpdate);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel17);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel9);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(40, 517);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1172, 198);
            this.guna2GroupBox1.TabIndex = 197;
            this.guna2GroupBox1.Text = "LTO";
            // 
            // renewalLTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 801);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataLTOrenew);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "renewalLTO";
            this.Text = "renewalLTO";
            this.Load += new System.EventHandler(this.renewalLTO_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLTOrenew)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dataLTOrenew;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEHICLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MVUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGISTERED;
        private System.Windows.Forms.DataGridViewTextBoxColumn OR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Update_;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtORdate;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtDuedate;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtMRate;
        private Guna.UI2.WinForms.Guna2TextBox txtORnum;
        private Guna.UI2.WinForms.Guna2TextBox txtColor;
        private Guna.UI2.WinForms.Guna2TextBox txtRegName;
        private Guna.UI2.WinForms.Guna2TextBox txtVehicleT;
        private Guna.UI2.WinForms.Guna2TextBox txtPlate;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button refresh;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
    }
}