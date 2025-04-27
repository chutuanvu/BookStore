namespace Doan1
{
    partial class ChamCong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChamCong));
            this.label2 = new System.Windows.Forms.Label();
            this.dtpngay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btxoa = new Guna.UI2.WinForms.Guna2Button();
            this.tool = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.dgvchamcong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbmacc = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.tbtimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.cbbnhanvien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btthem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ptb2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchamcong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Chấm Công:";
            // 
            // dtpngay
            // 
            this.dtpngay.BorderRadius = 15;
            this.dtpngay.BorderThickness = 2;
            this.dtpngay.Checked = true;
            this.dtpngay.FillColor = System.Drawing.Color.Teal;
            this.dtpngay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpngay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpngay.Location = new System.Drawing.Point(9, 89);
            this.dtpngay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpngay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpngay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpngay.Name = "dtpngay";
            this.dtpngay.Size = new System.Drawing.Size(176, 39);
            this.dtpngay.TabIndex = 3;
            this.dtpngay.Value = new System.DateTime(2024, 4, 28, 21, 5, 2, 751);
            // 
            // btxoa
            // 
            this.btxoa.BorderRadius = 15;
            this.btxoa.BorderThickness = 2;
            this.btxoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btxoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btxoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btxoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btxoa.FillColor = System.Drawing.Color.DarkCyan;
            this.btxoa.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btxoa.ForeColor = System.Drawing.Color.White;
            this.btxoa.Image = global::GUI.Properties.Resources.Xoa;
            this.btxoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btxoa.Location = new System.Drawing.Point(526, 82);
            this.btxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(113, 46);
            this.btxoa.TabIndex = 6;
            this.btxoa.Text = "&Xóa";
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // tool
            // 
            this.tool.AllowLinksHandling = true;
            this.tool.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // dgvchamcong
            // 
            this.dgvchamcong.AllowUserToAddRows = false;
            this.dgvchamcong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvchamcong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvchamcong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvchamcong.ColumnHeadersHeight = 18;
            this.dgvchamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvchamcong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvchamcong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvchamcong.Location = new System.Drawing.Point(9, 144);
            this.dgvchamcong.Margin = new System.Windows.Forms.Padding(2);
            this.dgvchamcong.Name = "dgvchamcong";
            this.dgvchamcong.ReadOnly = true;
            this.dgvchamcong.RowHeadersVisible = false;
            this.dgvchamcong.RowHeadersWidth = 51;
            this.dgvchamcong.RowTemplate.Height = 24;
            this.dgvchamcong.Size = new System.Drawing.Size(643, 301);
            this.dgvchamcong.TabIndex = 7;
            this.dgvchamcong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvchamcong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvchamcong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvchamcong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvchamcong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvchamcong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvchamcong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvchamcong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvchamcong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvchamcong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvchamcong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvchamcong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvchamcong.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvchamcong.ThemeStyle.ReadOnly = true;
            this.dgvchamcong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvchamcong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvchamcong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvchamcong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvchamcong.ThemeStyle.RowsStyle.Height = 24;
            this.dgvchamcong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvchamcong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvchamcong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvchamcong_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã Nhân Viên:";
            // 
            // tbmacc
            // 
            this.tbmacc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbmacc.DefaultText = "";
            this.tbmacc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbmacc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbmacc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbmacc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbmacc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbmacc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbmacc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbmacc.Location = new System.Drawing.Point(192, 92);
            this.tbmacc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbmacc.Name = "tbmacc";
            this.tbmacc.PasswordChar = '\0';
            this.tbmacc.PlaceholderText = "";
            this.tbmacc.ReadOnly = true;
            this.tbmacc.SelectedText = "";
            this.tbmacc.Size = new System.Drawing.Size(88, 29);
            this.tbmacc.TabIndex = 8;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DarkCyan;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(316, 8);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(135, 42);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "SEARCH";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.tbtimkiem.BorderRadius = 10;
            this.tbtimkiem.BorderThickness = 2;
            this.tbtimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtimkiem.DefaultText = "";
            this.tbtimkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbtimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbtimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtimkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtimkiem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbtimkiem.ForeColor = System.Drawing.Color.Black;
            this.tbtimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtimkiem.Location = new System.Drawing.Point(74, 8);
            this.tbtimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.PasswordChar = '\0';
            this.tbtimkiem.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbtimkiem.PlaceholderText = "Nhập từ khóa tìm kiếm......";
            this.tbtimkiem.SelectedText = "";
            this.tbtimkiem.Size = new System.Drawing.Size(238, 42);
            this.tbtimkiem.TabIndex = 38;
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::GUI.Properties.Resources.quayve;
            this.guna2Button3.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button3.Location = new System.Drawing.Point(2, 8);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(67, 41);
            this.guna2Button3.TabIndex = 40;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // cbbnhanvien
            // 
            this.cbbnhanvien.BackColor = System.Drawing.Color.Transparent;
            this.cbbnhanvien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbnhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbnhanvien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbnhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbnhanvien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbnhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbnhanvien.ItemHeight = 30;
            this.cbbnhanvien.Location = new System.Drawing.Point(284, 92);
            this.cbbnhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.cbbnhanvien.Name = "cbbnhanvien";
            this.cbbnhanvien.Size = new System.Drawing.Size(99, 36);
            this.cbbnhanvien.TabIndex = 41;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.SaddleBrown;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button2.Image = global::GUI.Properties.Resources.excel;
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button2.Location = new System.Drawing.Point(560, -2);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(44, 41);
            this.guna2Button2.TabIndex = 39;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btthem
            // 
            this.btthem.BorderRadius = 15;
            this.btthem.BorderThickness = 2;
            this.btthem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btthem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btthem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btthem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btthem.FillColor = System.Drawing.Color.DarkCyan;
            this.btthem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btthem.ForeColor = System.Drawing.Color.White;
            this.btthem.Image = global::GUI.Properties.Resources.add_green;
            this.btthem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btthem.ImageSize = new System.Drawing.Size(30, 30);
            this.btthem.Location = new System.Drawing.Point(396, 82);
            this.btthem.Margin = new System.Windows.Forms.Padding(2);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(112, 46);
            this.btthem.TabIndex = 4;
            this.btthem.Text = "&Thêm";
            this.btthem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ptb2
            // 
            this.ptb2.AccessibleDescription = "";
            this.ptb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptb2.Image = global::GUI.Properties.Resources.close_red;
            this.ptb2.Location = new System.Drawing.Point(609, 3);
            this.ptb2.Margin = new System.Windows.Forms.Padding(2);
            this.ptb2.Name = "ptb2";
            this.ptb2.Size = new System.Drawing.Size(30, 31);
            this.ptb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb2.TabIndex = 72;
            this.ptb2.TabStop = false;
            this.ptb2.Click += new System.EventHandler(this.Ptb2_Click);
            // 
            // ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(661, 454);
            this.Controls.Add(this.ptb2);
            this.Controls.Add(this.cbbnhanvien);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.tbtimkiem);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbmacc);
            this.Controls.Add(this.dgvchamcong);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.dtpngay);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chấm Công";
            this.Load += new System.EventHandler(this.ChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchamcong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpngay;
        private Guna.UI2.WinForms.Guna2Button btthem;
        private Guna.UI2.WinForms.Guna2Button btxoa;
        private Guna.UI2.WinForms.Guna2HtmlToolTip tool;
        private Guna.UI2.WinForms.Guna2DataGridView dgvchamcong;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbmacc;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox tbtimkiem;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2ComboBox cbbnhanvien;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox ptb2;
    }
}