using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace QLKhoaHocONL
{
    partial class frmKhoaHoc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoaHoc));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabManage = new System.Windows.Forms.TabPage();
            this.panelManage = new System.Windows.Forms.Panel();
            this.dgvCourses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelForm = new Guna.UI2.WinForms.Guna2Panel();
            this.groupActions = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.cboInstructor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDemo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMau2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMau1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnh = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThoiLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHocVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaGiam = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaGoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabStats = new System.Windows.Forms.TabPage();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelStatsTop = new System.Windows.Forms.FlowLayoutPanel();
            this.cardCourses = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCountValue = new System.Windows.Forms.Label();
            this.lblCountTitle = new System.Windows.Forms.Label();
            this.cardStudents = new Guna.UI2.WinForms.Guna2Panel();
            this.lblStudentsValue = new System.Windows.Forms.Label();
            this.lblStudentsTitle = new System.Windows.Forms.Label();
            this.cardRevenue = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRevenueValue = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.cardSelected = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSelRevenue = new System.Windows.Forms.Label();
            this.lblSelStudents = new System.Windows.Forms.Label();
            this.lblSelCourse = new System.Windows.Forms.Label();
            this.lblSelTitle = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabManage.SuspendLayout();
            this.panelManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.panelForm.SuspendLayout();
            this.groupActions.SuspendLayout();
            this.tabStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.panelStatsTop.SuspendLayout();
            this.cardCourses.SuspendLayout();
            this.cardStudents.SuspendLayout();
            this.cardRevenue.SuspendLayout();
            this.cardSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabManage);
            this.tabControl.Controls.Add(this.tabStats);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1465, 733);
            this.tabControl.TabIndex = 0;
            // 
            // tabManage
            // 
            this.tabManage.Controls.Add(this.panelManage);
            this.tabManage.Location = new System.Drawing.Point(4, 28);
            this.tabManage.Name = "tabManage";
            this.tabManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabManage.Size = new System.Drawing.Size(1457, 701);
            this.tabManage.TabIndex = 0;
            this.tabManage.Text = "Quản lý khóa học";
            this.tabManage.UseVisualStyleBackColor = true;
            // 
            // panelManage
            // 
            this.panelManage.Controls.Add(this.dgvCourses);
            this.panelManage.Controls.Add(this.panelForm);
            this.panelManage.Controls.Add(this.label1);
            this.panelManage.Controls.Add(this.txtId);
            this.panelManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManage.Location = new System.Drawing.Point(3, 3);
            this.panelManage.Name = "panelManage";
            this.panelManage.Padding = new System.Windows.Forms.Padding(10);
            this.panelManage.Size = new System.Drawing.Size(1451, 695);
            this.panelManage.TabIndex = 0;
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCourses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCourses.ColumnHeadersHeight = 36;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCourses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCourses.Location = new System.Drawing.Point(10, 10);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.RowTemplate.Height = 28;
            this.dgvCourses.Size = new System.Drawing.Size(951, 675);
            this.dgvCourses.TabIndex = 0;
            this.dgvCourses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCourses.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCourses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCourses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCourses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCourses.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCourses.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCourses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCourses.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCourses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.dgvCourses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCourses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCourses.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvCourses.ThemeStyle.ReadOnly = true;
            this.dgvCourses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCourses.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCourses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.dgvCourses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCourses.ThemeStyle.RowsStyle.Height = 28;
            this.dgvCourses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCourses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCourses.SelectionChanged += new System.EventHandler(this.dgvCourses_SelectionChanged);
            // 
            // panelForm
            // 
            this.panelForm.BorderRadius = 12;
            this.panelForm.Controls.Add(this.groupActions);
            this.panelForm.Controls.Add(this.cboInstructor);
            this.panelForm.Controls.Add(this.label11);
            this.panelForm.Controls.Add(this.txtDemo);
            this.panelForm.Controls.Add(this.label10);
            this.panelForm.Controls.Add(this.txtMau2);
            this.panelForm.Controls.Add(this.label9);
            this.panelForm.Controls.Add(this.txtMau1);
            this.panelForm.Controls.Add(this.label8);
            this.panelForm.Controls.Add(this.txtAnh);
            this.panelForm.Controls.Add(this.label7);
            this.panelForm.Controls.Add(this.txtThoiLuong);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.txtHocVien);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.txtGiaGiam);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.txtGiaGoc);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.txtTen);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.btnClose);
            this.panelForm.Controls.Add(this.btnRefresh);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelForm.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelForm.Location = new System.Drawing.Point(961, 10);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(480, 675);
            this.panelForm.TabIndex = 1;
            // 
            // groupActions
            // 
            this.groupActions.BorderRadius = 8;
            this.groupActions.Controls.Add(this.btnAdd);
            this.groupActions.Controls.Add(this.btnUpdate);
            this.groupActions.Controls.Add(this.btnDelete);
            this.groupActions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupActions.Location = new System.Drawing.Point(20, 467);
            this.groupActions.Name = "groupActions";
            this.groupActions.Size = new System.Drawing.Size(430, 130);
            this.groupActions.TabIndex = 24;
            this.groupActions.Text = "Thao tác";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 8;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::QLKhoaHocONL.Properties.Resources.ic_add;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAdd.Location = new System.Drawing.Point(20, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 8;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::QLKhoaHocONL.Properties.Resources.ic_edit;
            this.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdate.ImageSize = new System.Drawing.Size(32, 32);
            this.btnUpdate.Location = new System.Drawing.Point(160, 60);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 45);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::QLKhoaHocONL.Properties.Resources.ic_delete;
            this.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelete.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDelete.Location = new System.Drawing.Point(300, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cboInstructor
            // 
            this.cboInstructor.BackColor = System.Drawing.Color.Transparent;
            this.cboInstructor.BorderRadius = 8;
            this.cboInstructor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInstructor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboInstructor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboInstructor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboInstructor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboInstructor.ItemHeight = 30;
            this.cboInstructor.Location = new System.Drawing.Point(160, 413);
            this.cboInstructor.Name = "cboInstructor";
            this.cboInstructor.Size = new System.Drawing.Size(290, 36);
            this.cboInstructor.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Giảng viên";
            // 
            // txtDemo
            // 
            this.txtDemo.BorderRadius = 8;
            this.txtDemo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDemo.DefaultText = "";
            this.txtDemo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDemo.Location = new System.Drawing.Point(160, 368);
            this.txtDemo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDemo.Name = "txtDemo";
            this.txtDemo.PlaceholderText = "Link demo";
            this.txtDemo.SelectedText = "";
            this.txtDemo.Size = new System.Drawing.Size(290, 36);
            this.txtDemo.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Link demo";
            // 
            // txtMau2
            // 
            this.txtMau2.BorderRadius = 8;
            this.txtMau2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMau2.DefaultText = "";
            this.txtMau2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMau2.Location = new System.Drawing.Point(310, 321);
            this.txtMau2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMau2.Name = "txtMau2";
            this.txtMau2.PlaceholderText = "#FF0000";
            this.txtMau2.SelectedText = "";
            this.txtMau2.Size = new System.Drawing.Size(140, 36);
            this.txtMau2.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Màu kết thúc";
            // 
            // txtMau1
            // 
            this.txtMau1.BorderRadius = 8;
            this.txtMau1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMau1.DefaultText = "";
            this.txtMau1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMau1.Location = new System.Drawing.Point(160, 321);
            this.txtMau1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMau1.Name = "txtMau1";
            this.txtMau1.PlaceholderText = "#0000FF";
            this.txtMau1.SelectedText = "";
            this.txtMau1.Size = new System.Drawing.Size(140, 36);
            this.txtMau1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Màu bắt đầu";
            // 
            // txtAnh
            // 
            this.txtAnh.BorderRadius = 8;
            this.txtAnh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnh.DefaultText = "";
            this.txtAnh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAnh.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtAnh.IconRight = ((System.Drawing.Image)(resources.GetObject("txtAnh.IconRight")));
            this.txtAnh.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtAnh.Location = new System.Drawing.Point(160, 248);
            this.txtAnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.PlaceholderText = "Chọn file ảnh...";
            this.txtAnh.SelectedText = "";
            this.txtAnh.Size = new System.Drawing.Size(290, 36);
            this.txtAnh.TabIndex = 14;
            this.txtAnh.IconRightClick += new System.EventHandler(this.txtAnh_IconRightClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tên ảnh bìa";
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.BorderRadius = 8;
            this.txtThoiLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThoiLuong.DefaultText = "";
            this.txtThoiLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThoiLuong.Location = new System.Drawing.Point(160, 197);
            this.txtThoiLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.PlaceholderText = "Thời lượng (vd: 40h)";
            this.txtThoiLuong.SelectedText = "";
            this.txtThoiLuong.Size = new System.Drawing.Size(290, 36);
            this.txtThoiLuong.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Thời lượng";
            // 
            // txtHocVien
            // 
            this.txtHocVien.BorderRadius = 8;
            this.txtHocVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHocVien.DefaultText = "";
            this.txtHocVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHocVien.Location = new System.Drawing.Point(160, 148);
            this.txtHocVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHocVien.Name = "txtHocVien";
            this.txtHocVien.PlaceholderText = "Số học viên";
            this.txtHocVien.SelectedText = "";
            this.txtHocVien.Size = new System.Drawing.Size(290, 36);
            this.txtHocVien.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Học viên";
            // 
            // txtGiaGiam
            // 
            this.txtGiaGiam.BorderRadius = 8;
            this.txtGiaGiam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaGiam.DefaultText = "";
            this.txtGiaGiam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaGiam.Location = new System.Drawing.Point(310, 99);
            this.txtGiaGiam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaGiam.Name = "txtGiaGiam";
            this.txtGiaGiam.PlaceholderText = "vd: 1.499.000đ";
            this.txtGiaGiam.SelectedText = "";
            this.txtGiaGiam.Size = new System.Drawing.Size(140, 36);
            this.txtGiaGiam.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giá giảm";
            // 
            // txtGiaGoc
            // 
            this.txtGiaGoc.BorderRadius = 8;
            this.txtGiaGoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaGoc.DefaultText = "";
            this.txtGiaGoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaGoc.Location = new System.Drawing.Point(160, 99);
            this.txtGiaGoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaGoc.Name = "txtGiaGoc";
            this.txtGiaGoc.PlaceholderText = "vd: 2.500.000đ";
            this.txtGiaGoc.SelectedText = "";
            this.txtGiaGoc.Size = new System.Drawing.Size(140, 36);
            this.txtGiaGoc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá gốc";
            // 
            // txtTen
            // 
            this.txtTen.BorderRadius = 8;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.DefaultText = "";
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTen.Location = new System.Drawing.Point(160, 29);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.PlaceholderText = "Tên khóa học";
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(290, 36);
            this.txtTen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên khóa học";
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 8;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::QLKhoaHocONL.Properties.Resources.ic_close;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClose.Location = new System.Drawing.Point(240, 615);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(210, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 8;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::QLKhoaHocONL.Properties.Resources.ic_refresh;
            this.btnRefresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRefresh.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRefresh.Location = new System.Drawing.Point(20, 615);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(210, 45);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // txtId
            // 
            this.txtId.BorderRadius = 8;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.LightGray;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtId.Location = new System.Drawing.Point(773, 33);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.PlaceholderText = "Tự động";
            this.txtId.ReadOnly = true;
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(100, 36);
            this.txtId.TabIndex = 2;
            this.txtId.Visible = false;
            // 
            // tabStats
            // 
            this.tabStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tabStats.Controls.Add(this.chartRevenue);
            this.tabStats.Controls.Add(this.panelStatsTop);
            this.tabStats.Location = new System.Drawing.Point(4, 28);
            this.tabStats.Name = "tabStats";
            this.tabStats.Padding = new System.Windows.Forms.Padding(15);
            this.tabStats.Size = new System.Drawing.Size(1457, 701);
            this.tabStats.TabIndex = 1;
            this.tabStats.Text = "Thống kê";
            // 
            // chartRevenue
            // 
            this.chartRevenue.BackColor = System.Drawing.Color.Transparent;
            this.chartRevenue.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRevenue.Location = new System.Drawing.Point(15, 159);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartRevenue.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(86)))), ((int)(((byte)(214))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(132))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(162)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(86))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(64))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))))};
            this.chartRevenue.Size = new System.Drawing.Size(1427, 527);
            this.chartRevenue.TabIndex = 1;
            this.chartRevenue.Text = "chart1";
            // 
            // panelStatsTop
            // 
            this.panelStatsTop.Controls.Add(this.cardCourses);
            this.panelStatsTop.Controls.Add(this.cardStudents);
            this.panelStatsTop.Controls.Add(this.cardRevenue);
            this.panelStatsTop.Controls.Add(this.cardSelected);
            this.panelStatsTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatsTop.Location = new System.Drawing.Point(15, 15);
            this.panelStatsTop.Name = "panelStatsTop";
            this.panelStatsTop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelStatsTop.Size = new System.Drawing.Size(1427, 144);
            this.panelStatsTop.TabIndex = 0;
            // 
            // cardCourses
            // 
            this.cardCourses.BackColor = System.Drawing.Color.Transparent;
            this.cardCourses.BorderRadius = 15;
            this.cardCourses.Controls.Add(this.lblCountValue);
            this.cardCourses.Controls.Add(this.lblCountTitle);
            this.cardCourses.FillColor = System.Drawing.Color.White;
            this.cardCourses.Location = new System.Drawing.Point(3, 3);
            this.cardCourses.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cardCourses.Name = "cardCourses";
            this.cardCourses.ShadowDecoration.BorderRadius = 15;
            this.cardCourses.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(86)))), ((int)(((byte)(214)))));
            this.cardCourses.ShadowDecoration.Depth = 15;
            this.cardCourses.ShadowDecoration.Enabled = true;
            this.cardCourses.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.cardCourses.Size = new System.Drawing.Size(280, 125);
            this.cardCourses.TabIndex = 0;
            // 
            // lblCountValue
            // 
            this.lblCountValue.AutoSize = true;
            this.lblCountValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCountValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblCountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(86)))), ((int)(((byte)(214)))));
            this.lblCountValue.Location = new System.Drawing.Point(18, 55);
            this.lblCountValue.Name = "lblCountValue";
            this.lblCountValue.Size = new System.Drawing.Size(54, 62);
            this.lblCountValue.TabIndex = 1;
            this.lblCountValue.Text = "0";
            // 
            // lblCountTitle
            // 
            this.lblCountTitle.AutoSize = true;
            this.lblCountTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCountTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCountTitle.Location = new System.Drawing.Point(20, 20);
            this.lblCountTitle.Name = "lblCountTitle";
            this.lblCountTitle.Size = new System.Drawing.Size(108, 25);
            this.lblCountTitle.TabIndex = 0;
            this.lblCountTitle.Text = "Tổng khóa";
            // 
            // cardStudents
            // 
            this.cardStudents.BackColor = System.Drawing.Color.Transparent;
            this.cardStudents.BorderRadius = 15;
            this.cardStudents.Controls.Add(this.lblStudentsValue);
            this.cardStudents.Controls.Add(this.lblStudentsTitle);
            this.cardStudents.FillColor = System.Drawing.Color.White;
            this.cardStudents.Location = new System.Drawing.Point(296, 3);
            this.cardStudents.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cardStudents.Name = "cardStudents";
            this.cardStudents.ShadowDecoration.BorderRadius = 15;
            this.cardStudents.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(162)))), ((int)(((byte)(235)))));
            this.cardStudents.ShadowDecoration.Depth = 15;
            this.cardStudents.ShadowDecoration.Enabled = true;
            this.cardStudents.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.cardStudents.Size = new System.Drawing.Size(280, 125);
            this.cardStudents.TabIndex = 1;
            // 
            // lblStudentsValue
            // 
            this.lblStudentsValue.AutoSize = true;
            this.lblStudentsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentsValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblStudentsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(162)))), ((int)(((byte)(235)))));
            this.lblStudentsValue.Location = new System.Drawing.Point(18, 55);
            this.lblStudentsValue.Name = "lblStudentsValue";
            this.lblStudentsValue.Size = new System.Drawing.Size(54, 62);
            this.lblStudentsValue.TabIndex = 1;
            this.lblStudentsValue.Text = "0";
            // 
            // lblStudentsTitle
            // 
            this.lblStudentsTitle.AutoSize = true;
            this.lblStudentsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStudentsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblStudentsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblStudentsTitle.Name = "lblStudentsTitle";
            this.lblStudentsTitle.Size = new System.Drawing.Size(138, 25);
            this.lblStudentsTitle.TabIndex = 0;
            this.lblStudentsTitle.Text = "Tổng học viên";
            // 
            // cardRevenue
            // 
            this.cardRevenue.BackColor = System.Drawing.Color.Transparent;
            this.cardRevenue.BorderRadius = 15;
            this.cardRevenue.Controls.Add(this.lblRevenueValue);
            this.cardRevenue.Controls.Add(this.lblRevenueTitle);
            this.cardRevenue.FillColor = System.Drawing.Color.White;
            this.cardRevenue.Location = new System.Drawing.Point(589, 3);
            this.cardRevenue.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cardRevenue.Name = "cardRevenue";
            this.cardRevenue.ShadowDecoration.BorderRadius = 15;
            this.cardRevenue.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cardRevenue.ShadowDecoration.Depth = 15;
            this.cardRevenue.ShadowDecoration.Enabled = true;
            this.cardRevenue.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.cardRevenue.Size = new System.Drawing.Size(280, 125);
            this.cardRevenue.TabIndex = 2;
            // 
            // lblRevenueValue
            // 
            this.lblRevenueValue.AutoSize = true;
            this.lblRevenueValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRevenueValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblRevenueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblRevenueValue.Location = new System.Drawing.Point(18, 63);
            this.lblRevenueValue.Name = "lblRevenueValue";
            this.lblRevenueValue.Size = new System.Drawing.Size(40, 46);
            this.lblRevenueValue.TabIndex = 1;
            this.lblRevenueValue.Text = "0";
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.AutoSize = true;
            this.lblRevenueTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblRevenueTitle.Location = new System.Drawing.Point(20, 20);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(156, 25);
            this.lblRevenueTitle.TabIndex = 0;
            this.lblRevenueTitle.Text = "Tổng doanh thu";
            // 
            // cardSelected
            // 
            this.cardSelected.BackColor = System.Drawing.Color.Transparent;
            this.cardSelected.BorderRadius = 15;
            this.cardSelected.Controls.Add(this.lblSelRevenue);
            this.cardSelected.Controls.Add(this.lblSelStudents);
            this.cardSelected.Controls.Add(this.lblSelCourse);
            this.cardSelected.Controls.Add(this.lblSelTitle);
            this.cardSelected.FillColor = System.Drawing.Color.White;
            this.cardSelected.Location = new System.Drawing.Point(882, 3);
            this.cardSelected.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cardSelected.Name = "cardSelected";
            this.cardSelected.ShadowDecoration.BorderRadius = 15;
            this.cardSelected.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(64)))));
            this.cardSelected.ShadowDecoration.Depth = 15;
            this.cardSelected.ShadowDecoration.Enabled = true;
            this.cardSelected.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.cardSelected.Size = new System.Drawing.Size(360, 125);
            this.cardSelected.TabIndex = 3;
            // 
            // lblSelRevenue
            // 
            this.lblSelRevenue.AutoSize = true;
            this.lblSelRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lblSelRevenue.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSelRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSelRevenue.Location = new System.Drawing.Point(22, 91);
            this.lblSelRevenue.Name = "lblSelRevenue";
            this.lblSelRevenue.Size = new System.Drawing.Size(112, 21);
            this.lblSelRevenue.TabIndex = 3;
            this.lblSelRevenue.Text = "Doanh thu: 0 đ";
            // 
            // lblSelStudents
            // 
            this.lblSelStudents.AutoSize = true;
            this.lblSelStudents.BackColor = System.Drawing.Color.Transparent;
            this.lblSelStudents.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSelStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSelStudents.Location = new System.Drawing.Point(22, 68);
            this.lblSelStudents.Name = "lblSelStudents";
            this.lblSelStudents.Size = new System.Drawing.Size(86, 21);
            this.lblSelStudents.TabIndex = 2;
            this.lblSelStudents.Text = "Học viên: 0";
            // 
            // lblSelCourse
            // 
            this.lblSelCourse.AutoSize = true;
            this.lblSelCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblSelCourse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSelCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(64)))));
            this.lblSelCourse.Location = new System.Drawing.Point(22, 40);
            this.lblSelCourse.Name = "lblSelCourse";
            this.lblSelCourse.Size = new System.Drawing.Size(150, 25);
            this.lblSelCourse.TabIndex = 1;
            this.lblSelCourse.Text = "Tất cả khóa học";
            // 
            // lblSelTitle
            // 
            this.lblSelTitle.AutoSize = true;
            this.lblSelTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSelTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSelTitle.Location = new System.Drawing.Point(22, 12);
            this.lblSelTitle.Name = "lblSelTitle";
            this.lblSelTitle.Size = new System.Drawing.Size(157, 25);
            this.lblSelTitle.TabIndex = 0;
            this.lblSelTitle.Text = "Khóa đang chọn";
            // 
            // frmKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 733);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.MaximizeBox = false;
            this.Name = "frmKhoaHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý khóa học";
            this.Load += new System.EventHandler(this.frmKhoaHoc_Load);
            this.tabControl.ResumeLayout(false);
            this.tabManage.ResumeLayout(false);
            this.panelManage.ResumeLayout(false);
            this.panelManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.groupActions.ResumeLayout(false);
            this.tabStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.panelStatsTop.ResumeLayout(false);
            this.cardCourses.ResumeLayout(false);
            this.cardCourses.PerformLayout();
            this.cardStudents.ResumeLayout(false);
            this.cardStudents.PerformLayout();
            this.cardRevenue.ResumeLayout(false);
            this.cardRevenue.PerformLayout();
            this.cardSelected.ResumeLayout(false);
            this.cardSelected.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabManage;
        private System.Windows.Forms.TabPage tabStats;
        private System.Windows.Forms.Panel panelManage;
        private Chart chartRevenue;
        private System.Windows.Forms.FlowLayoutPanel panelStatsTop;
        private Guna.UI2.WinForms.Guna2Panel cardCourses;
        private System.Windows.Forms.Label lblCountValue;
        private System.Windows.Forms.Label lblCountTitle;
        private Guna.UI2.WinForms.Guna2Panel cardStudents;
        private System.Windows.Forms.Label lblStudentsValue;
        private System.Windows.Forms.Label lblStudentsTitle;
        private Guna.UI2.WinForms.Guna2Panel cardRevenue;
        private System.Windows.Forms.Label lblRevenueValue;
        private System.Windows.Forms.Label lblRevenueTitle;
        private Guna.UI2.WinForms.Guna2Panel cardSelected;
        private System.Windows.Forms.Label lblSelRevenue;
        private System.Windows.Forms.Label lblSelStudents;
        private System.Windows.Forms.Label lblSelCourse;
        private System.Windows.Forms.Label lblSelTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCourses;
        private Guna.UI2.WinForms.Guna2Panel panelForm;
        private Guna.UI2.WinForms.Guna2GroupBox groupActions;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2ComboBox cboInstructor;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtDemo;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtMau2;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtMau1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtAnh;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtThoiLuong;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtHocVien;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaGiam;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaGoc;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
    }
}