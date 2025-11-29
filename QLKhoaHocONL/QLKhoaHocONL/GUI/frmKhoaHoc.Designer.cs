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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabManage = new System.Windows.Forms.TabPage();
            this.panelManage = new System.Windows.Forms.Panel();
            this.dgvCourses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelForm = new Guna.UI2.WinForms.Guna2Panel();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaGoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaGiam = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHocVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThoiLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnh = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMau1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMau2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDemo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
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
            this.tabStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.panelStatsTop.SuspendLayout();
            this.cardCourses.SuspendLayout();
            this.cardStudents.SuspendLayout();
            this.cardRevenue.SuspendLayout();
            this.cardSelected.SuspendLayout();
            this.SuspendLayout();
            // tabControl
            this.tabControl.Controls.Add(this.tabManage);
            this.tabControl.Controls.Add(this.tabStats);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1180, 620);
            this.tabControl.TabIndex = 0;
            // tabManage
            this.tabManage.Controls.Add(this.panelManage);
            this.tabManage.Location = new System.Drawing.Point(4, 25);
            this.tabManage.Name = "tabManage";
            this.tabManage.Padding = new System.Windows.Forms.Padding(6);
            this.tabManage.Size = new System.Drawing.Size(1172, 591);
            this.tabManage.TabIndex = 0;
            this.tabManage.Text = "Qu?n lý khóa h?c";
            this.tabManage.UseVisualStyleBackColor = true;
            // panelManage
            this.panelManage.Controls.Add(this.dgvCourses);
            this.panelManage.Controls.Add(this.panelForm);
            this.panelManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManage.Location = new System.Drawing.Point(6, 6);
            this.panelManage.Name = "panelManage";
            this.panelManage.Size = new System.Drawing.Size(1160, 579);
            this.panelManage.TabIndex = 0;
            // dgvCourses
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.BackgroundColor = System.Drawing.Color.White;
            this.dgvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCourses.ColumnHeadersHeight = 36;
            this.dgvCourses.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvCourses.Location = new System.Drawing.Point(0, 0);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.RowTemplate.Height = 28;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(640, 579);
            this.dgvCourses.TabIndex = 0;
            this.dgvCourses.SelectionChanged += new System.EventHandler(this.dgvCourses_SelectionChanged);
            // panelForm
            this.panelForm.BorderRadius = 12;
            this.panelForm.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelForm.Location = new System.Drawing.Point(660, 10);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(490, 559);
            this.panelForm.TabIndex = 1;
            this.panelForm.Controls.Add(this.txtId);
            this.panelForm.Controls.Add(this.lblId);
            this.panelForm.Controls.Add(this.txtTen);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.txtGiaGoc);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.txtGiaGiam);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.txtHocVien);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.txtThoiLuong);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.txtAnh);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.txtMau1);
            this.panelForm.Controls.Add(this.label7);
            this.panelForm.Controls.Add(this.txtMau2);
            this.panelForm.Controls.Add(this.label8);
            this.panelForm.Controls.Add(this.txtDemo);
            this.panelForm.Controls.Add(this.label10);
            this.panelForm.Controls.Add(this.btnAdd);
            this.panelForm.Controls.Add(this.btnUpdate);
            this.panelForm.Controls.Add(this.btnDelete);
            // txtId
            this.txtId.BorderRadius = 8;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.LightGray;
            this.txtId.FillColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(170, 20);
            this.txtId.Name = "txtId";
            this.txtId.PlaceholderText = "T? sinh";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(290, 36);
            this.txtId.TabIndex = 0;
            // lblId
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(22, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            // txtTen
            this.txtTen.BorderRadius = 8;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.Location = new System.Drawing.Point(170, 70);
            this.txtTen.Name = "txtTen";
            this.txtTen.PlaceholderText = "Tên khóa h?c";
            this.txtTen.Size = new System.Drawing.Size(290, 36);
            this.txtTen.TabIndex = 2;
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên khóa h?c";
            // txtGiaGoc
            this.txtGiaGoc.BorderRadius = 8;
            this.txtGiaGoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaGoc.Location = new System.Drawing.Point(170, 120);
            this.txtGiaGoc.Name = "txtGiaGoc";
            this.txtGiaGoc.PlaceholderText = "vd: 2.500.000d";
            this.txtGiaGoc.Size = new System.Drawing.Size(290, 36);
            this.txtGiaGoc.TabIndex = 4;
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá g?c";
            // txtGiaGiam
            this.txtGiaGiam.BorderRadius = 8;
            this.txtGiaGiam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaGiam.Location = new System.Drawing.Point(170, 170);
            this.txtGiaGiam.Name = "txtGiaGiam";
            this.txtGiaGiam.PlaceholderText = "vd: 1.299.000d";
            this.txtGiaGiam.Size = new System.Drawing.Size(290, 36);
            this.txtGiaGiam.TabIndex = 6;
            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá gi?m";
            // txtHocVien
            this.txtHocVien.BorderRadius = 8;
            this.txtHocVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHocVien.Location = new System.Drawing.Point(170, 220);
            this.txtHocVien.Name = "txtHocVien";
            this.txtHocVien.PlaceholderText = "S? h?c viên";
            this.txtHocVien.Size = new System.Drawing.Size(290, 36);
            this.txtHocVien.TabIndex = 8;
            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "H?c viên";
            // txtThoiLuong
            this.txtThoiLuong.BorderRadius = 8;
            this.txtThoiLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThoiLuong.Location = new System.Drawing.Point(170, 270);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.PlaceholderText = "vd: 116h50p";
            this.txtThoiLuong.Size = new System.Drawing.Size(290, 36);
            this.txtThoiLuong.TabIndex = 10;
            // label5
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Th?i lu?ng";
            // txtAnh
            this.txtAnh.BorderRadius = 8;
            this.txtAnh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnh.Location = new System.Drawing.Point(170, 320);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.PlaceholderText = "Tên ?nh (png)";
            this.txtAnh.Size = new System.Drawing.Size(290, 36);
            this.txtAnh.TabIndex = 12;
            // label6
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tên ?nh *.png";
            // txtMau1
            this.txtMau1.BorderRadius = 8;
            this.txtMau1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMau1.Location = new System.Drawing.Point(170, 370);
            this.txtMau1.Name = "txtMau1";
            this.txtMau1.PlaceholderText = "#2979FF";
            this.txtMau1.Size = new System.Drawing.Size(130, 36);
            this.txtMau1.TabIndex = 14;
            // label7
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Màu b?t d?u";
            // txtMau2
            this.txtMau2.BorderRadius = 8;
            this.txtMau2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMau2.Location = new System.Drawing.Point(330, 370);
            this.txtMau2.Name = "txtMau2";
            this.txtMau2.PlaceholderText = "#4C3AE3";
            this.txtMau2.Size = new System.Drawing.Size(130, 36);
            this.txtMau2.TabIndex = 16;
            // label8
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Màu k?t thúc";
            // txtDemo
            this.txtDemo.BorderRadius = 8;
            this.txtDemo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDemo.Location = new System.Drawing.Point(170, 420);
            this.txtDemo.Name = "txtDemo";
            this.txtDemo.PlaceholderText = "Link demo (YouTube)";
            this.txtDemo.Size = new System.Drawing.Size(290, 36);
            this.txtDemo.TabIndex = 18;
            // label10
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Link demo";
            // btnAdd
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(25, 485);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Thêm m?i";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // btnUpdate
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.FillColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(170, 485);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 40);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "C?p nh?t";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // btnDelete
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.FillColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(330, 485);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 40);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // tabStats
            this.tabStats.Controls.Add(this.chartRevenue);
            this.tabStats.Controls.Add(this.panelStatsTop);
            this.tabStats.Location = new System.Drawing.Point(4, 25);
            this.tabStats.Name = "tabStats";
            this.tabStats.Padding = new System.Windows.Forms.Padding(10);
            this.tabStats.Size = new System.Drawing.Size(1172, 591);
            this.tabStats.TabIndex = 1;
            this.tabStats.Text = "Th?ng kê";
            this.tabStats.UseVisualStyleBackColor = true;
            // chartRevenue
            this.chartRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.chartRevenue.Location = new System.Drawing.Point(13, 150);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Size = new System.Drawing.Size(1146, 428);
            this.chartRevenue.TabIndex = 1;
            this.chartRevenue.Text = "chart1";
            // panelStatsTop
            this.panelStatsTop.Controls.Add(this.cardCourses);
            this.panelStatsTop.Controls.Add(this.cardStudents);
            this.panelStatsTop.Controls.Add(this.cardRevenue);
            this.panelStatsTop.Controls.Add(this.cardSelected);
            this.panelStatsTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatsTop.Location = new System.Drawing.Point(10, 10);
            this.panelStatsTop.Name = "panelStatsTop";
            this.panelStatsTop.Size = new System.Drawing.Size(1152, 134);
            this.panelStatsTop.TabIndex = 0;
            // cardCourses
            this.cardCourses.BorderRadius = 12;
            this.cardCourses.FillColor = System.Drawing.Color.White;
            this.cardCourses.Location = new System.Drawing.Point(3, 3);
            this.cardCourses.Name = "cardCourses";
            this.cardCourses.Size = new System.Drawing.Size(260, 120);
            this.cardCourses.TabIndex = 0;
            this.cardCourses.Controls.Add(this.lblCountValue);
            this.cardCourses.Controls.Add(this.lblCountTitle);
            // lblCountValue
            this.lblCountValue.AutoSize = true;
            this.lblCountValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCountValue.Location = new System.Drawing.Point(18, 60);
            this.lblCountValue.Name = "lblCountValue";
            this.lblCountValue.Size = new System.Drawing.Size(39, 37);
            this.lblCountValue.TabIndex = 1;
            this.lblCountValue.Text = "0";
            // lblCountTitle
            this.lblCountTitle.AutoSize = true;
            this.lblCountTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCountTitle.Location = new System.Drawing.Point(18, 18);
            this.lblCountTitle.Name = "lblCountTitle";
            this.lblCountTitle.Size = new System.Drawing.Size(98, 23);
            this.lblCountTitle.TabIndex = 0;
            this.lblCountTitle.Text = "T?ng khóa";
            // cardStudents
            this.cardStudents.BorderRadius = 12;
            this.cardStudents.FillColor = System.Drawing.Color.White;
            this.cardStudents.Location = new System.Drawing.Point(269, 3);
            this.cardStudents.Name = "cardStudents";
            this.cardStudents.Size = new System.Drawing.Size(260, 120);
            this.cardStudents.TabIndex = 1;
            this.cardStudents.Controls.Add(this.lblStudentsValue);
            this.cardStudents.Controls.Add(this.lblStudentsTitle);
            // lblStudentsValue
            this.lblStudentsValue.AutoSize = true;
            this.lblStudentsValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStudentsValue.Location = new System.Drawing.Point(18, 60);
            this.lblStudentsValue.Name = "lblStudentsValue";
            this.lblStudentsValue.Size = new System.Drawing.Size(39, 37);
            this.lblStudentsValue.TabIndex = 1;
            this.lblStudentsValue.Text = "0";
            // lblStudentsTitle
            this.lblStudentsTitle.AutoSize = true;
            this.lblStudentsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStudentsTitle.Location = new System.Drawing.Point(18, 18);
            this.lblStudentsTitle.Name = "lblStudentsTitle";
            this.lblStudentsTitle.Size = new System.Drawing.Size(117, 23);
            this.lblStudentsTitle.TabIndex = 0;
            this.lblStudentsTitle.Text = "T?ng h?c viên";
            // cardRevenue
            this.cardRevenue.BorderRadius = 12;
            this.cardRevenue.FillColor = System.Drawing.Color.White;
            this.cardRevenue.Location = new System.Drawing.Point(535, 3);
            this.cardRevenue.Name = "cardRevenue";
            this.cardRevenue.Size = new System.Drawing.Size(260, 120);
            this.cardRevenue.TabIndex = 2;
            this.cardRevenue.Controls.Add(this.lblRevenueValue);
            this.cardRevenue.Controls.Add(this.lblRevenueTitle);
            // lblRevenueValue
            this.lblRevenueValue.AutoSize = true;
            this.lblRevenueValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRevenueValue.Location = new System.Drawing.Point(18, 60);
            this.lblRevenueValue.Name = "lblRevenueValue";
            this.lblRevenueValue.Size = new System.Drawing.Size(39, 37);
            this.lblRevenueValue.TabIndex = 1;
            this.lblRevenueValue.Text = "0";
            // lblRevenueTitle
            this.lblRevenueTitle.AutoSize = true;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRevenueTitle.Location = new System.Drawing.Point(18, 18);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(134, 23);
            this.lblRevenueTitle.TabIndex = 0;
            this.lblRevenueTitle.Text = "Tong doanh thu";
            // cardSelected
            this.cardSelected.BorderRadius = 12;
            this.cardSelected.FillColor = System.Drawing.Color.White;
            this.cardSelected.Location = new System.Drawing.Point(801, 3);
            this.cardSelected.Name = "cardSelected";
            this.cardSelected.Size = new System.Drawing.Size(330, 120);
            this.cardSelected.TabIndex = 3;
            this.cardSelected.Controls.Add(this.lblSelRevenue);
            this.cardSelected.Controls.Add(this.lblSelStudents);
            this.cardSelected.Controls.Add(this.lblSelCourse);
            this.cardSelected.Controls.Add(this.lblSelTitle);
            // lblSelRevenue
            this.lblSelRevenue.AutoSize = true;
            this.lblSelRevenue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelRevenue.Location = new System.Drawing.Point(20, 90);
            this.lblSelRevenue.Name = "lblSelRevenue";
            this.lblSelRevenue.Size = new System.Drawing.Size(127, 20);
            this.lblSelRevenue.TabIndex = 3;
            this.lblSelRevenue.Text = "Doanh thu: 0 d";
            // lblSelStudents
            this.lblSelStudents.AutoSize = true;
            this.lblSelStudents.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelStudents.Location = new System.Drawing.Point(20, 66);
            this.lblSelStudents.Name = "lblSelStudents";
            this.lblSelStudents.Size = new System.Drawing.Size(142, 20);
            this.lblSelStudents.TabIndex = 2;
            this.lblSelStudents.Text = "H?c viên: 0 ngu?i";
            // lblSelCourse
            this.lblSelCourse.AutoSize = true;
            this.lblSelCourse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelCourse.Location = new System.Drawing.Point(20, 38);
            this.lblSelCourse.Name = "lblSelCourse";
            this.lblSelCourse.Size = new System.Drawing.Size(143, 23);
            this.lblSelCourse.TabIndex = 1;
            this.lblSelCourse.Text = "(Chua chon khoa)";
            // lblSelTitle
            this.lblSelTitle.AutoSize = true;
            this.lblSelTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelTitle.Location = new System.Drawing.Point(20, 12);
            this.lblSelTitle.Name = "lblSelTitle";
            this.lblSelTitle.Size = new System.Drawing.Size(149, 23);
            this.lblSelTitle.TabIndex = 0;
            this.lblSelTitle.Text = "Khoá dang ch?n";
            // frmKhoaHoc
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 620);
            this.Controls.Add(this.tabControl);
            this.Name = "frmKhoaHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Qu?n tr? khóa h?c";
            this.Load += new System.EventHandler(this.frmKhoaHoc_Load);
            this.tabControl.ResumeLayout(false);
            this.tabManage.ResumeLayout(false);
            this.panelManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
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

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabManage;
        private System.Windows.Forms.TabPage tabStats;
        private System.Windows.Forms.Panel panelManage;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCourses;
        private Guna.UI2.WinForms.Guna2Panel panelForm;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private Guna.UI2.WinForms.Guna2TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaGoc;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaGiam;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtHocVien;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtThoiLuong;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtAnh;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtMau1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtMau2;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtDemo;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
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
    }
}
