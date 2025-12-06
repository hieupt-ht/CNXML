using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using QLKhoaHocONL.Helpers;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL
{
    public partial class frmKhoaHoc : Form
    {
        private List<Course> _courses = new List<Course>();
        private Course _selected;
        private readonly Timer _chartTimer = new Timer();
        private readonly List<double> _targets = new List<double>();
        private readonly Random _rnd = new Random();
        private List<Instructor> _instructors = new List<Instructor>();

        public frmKhoaHoc()
        {
            InitializeComponent();
            ApplyVietnameseFonts();
            EnableChartDoubleBuffer();
            _chartTimer.Interval = 16;
            _chartTimer.Tick += ChartTimer_Tick;
        }

        private void frmKhoaHoc_Load(object sender, EventArgs e)
        {
            LoadInstructors();
            ReloadData();
            SetupChart();
            UpdateStats();
            chartRevenue.MouseClick += chartRevenue_MouseClick;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
        }

        private void LoadInstructors()
        {
            _instructors = XmlRepository.GetInstructors();

            cboInstructor.Items.Clear();
            cboInstructor.Items.Add("(Chưa chọn giảng viên)");

            foreach (var instructor in _instructors)
            {
                cboInstructor.Items.Add(instructor);
            }

            cboInstructor.DisplayMember = "FullName";
            cboInstructor.ValueMember = "InstructorId";
            cboInstructor.SelectedIndex = 0;
        }

        private void ReloadData()
        {
            _courses = XMLHelper.LoadCourses();

            var instructors = XmlRepository.GetInstructors();

            dgvCourses.DataSource = _courses.Select(c => new
            {
                c.Id,
                c.TenKhoaHoc,
                c.GiaGoc,
                c.GiaGiam,
                c.SoHocVien,
                c.ThoiLuong,
                c.TenAnh,
                c.MauBatDau,
                c.MauKetThuc,
                c.DemoLink,
                InstructorName = c.InstructorId.HasValue
                    ? instructors.FirstOrDefault(i => i.InstructorId == c.InstructorId.Value)?.FullName ?? "(Chưa có)"
                    : "(Chưa có)"
            }).ToList();

            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.ClearSelection();
            _selected = null;
            ClearInputs();
            LocalizeGridHeaders();
            UpdateStats();
        }

        private void dgvCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count == 0) return;
            var id = (int)dgvCourses.SelectedRows[0].Cells["Id"].Value;
            _selected = _courses.FirstOrDefault(c => c.Id == id);
            if (_selected == null) return;

            txtId.Text = _selected.Id.ToString();
            txtTen.Text = _selected.TenKhoaHoc;
            txtGiaGoc.Text = _selected.GiaGoc;
            txtGiaGiam.Text = _selected.GiaGiam;
            txtHocVien.Text = _selected.SoHocVien.ToString();
            txtThoiLuong.Text = _selected.ThoiLuong;
            txtAnh.Text = _selected.TenAnh;
            txtMau1.Text = _selected.MauBatDau;
            txtMau2.Text = _selected.MauKetThuc;
            txtDemo.Text = _selected.DemoLink;

            if (_selected.InstructorId.HasValue)
            {
                var instructor = _instructors.FirstOrDefault(i => i.InstructorId == _selected.InstructorId.Value);
                if (instructor != null)
                {
                    cboInstructor.SelectedItem = instructor;
                }
                else
                {
                    cboInstructor.SelectedIndex = 0;
                }
            }
            else
            {
                cboInstructor.SelectedIndex = 0;
            }

            UpdateSelectedStats();
        }

        private void ApplyVietnameseFonts()
        {
            var font = new Font("Times New Roman", 10, FontStyle.Regular);
            var fontBold = new Font("Times New Roman", 10, FontStyle.Bold);

            this.Font = font;
            tabControl.Font = font;
            tabManage.Font = font;
            tabStats.Font = font;

            foreach (var lbl in panelForm.Controls.OfType<Label>())
            {
                lbl.Font = font;
            }

            foreach (var txt in panelForm.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
            {
                txt.Font = font;
            }

            foreach (var btn in panelForm.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                btn.Font = fontBold;
            }

            cboInstructor.Font = font;

            if (groupActions != null)
            {
                groupActions.Font = fontBold;
            }

            dgvCourses.ColumnHeadersDefaultCellStyle.Font = fontBold;
            dgvCourses.DefaultCellStyle.Font = font;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputs();
            ReloadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newCourse = ReadForm();
            if (newCourse == null) return;

            int maxId = _courses.Any() ? _courses.Max(c => c.Id) : 0;
            newCourse.Id = maxId + 1;

            _courses.Add(newCourse);
            XMLHelper.SaveCourses(_courses);

            ReloadData();
            MessageBox.Show("Đã thêm thành công!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Chọn một khóa học để sửa.");
                return;
            }

            var updatedInfo = ReadForm();
            if (updatedInfo == null) return;

            var courseInList = _courses.FirstOrDefault(c => c.Id == _selected.Id);
            if (courseInList != null)
            {
                courseInList.TenKhoaHoc = updatedInfo.TenKhoaHoc;
                courseInList.GiaGoc = updatedInfo.GiaGoc;
                courseInList.GiaGiam = updatedInfo.GiaGiam;
                courseInList.SoHocVien = updatedInfo.SoHocVien;
                courseInList.ThoiLuong = updatedInfo.ThoiLuong;
                courseInList.TenAnh = updatedInfo.TenAnh;
                courseInList.MauBatDau = updatedInfo.MauBatDau;
                courseInList.MauKetThuc = updatedInfo.MauKetThuc;
                courseInList.DemoLink = updatedInfo.DemoLink;
                courseInList.InstructorId = updatedInfo.InstructorId;

                XMLHelper.SaveCourses(_courses);
                ReloadData();
                MessageBox.Show("Đã cập nhật file XML!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Chọn một khóa học để xóa.");
                return;
            }

            if (MessageBox.Show("Xóa khóa học này khỏi XML?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var courseToRemove = _courses.FirstOrDefault(c => c.Id == _selected.Id);
                if (courseToRemove != null)
                {
                    _courses.Remove(courseToRemove);
                    XMLHelper.SaveCourses(_courses);
                    ReloadData();
                    MessageBox.Show("Đã xóa thành công!");
                }
            }
        }

        private Course ReadForm()
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Tên khóa học không được trống.");
                txtTen.Focus();
                return null;
            }

            if (!int.TryParse(txtHocVien.Text, out var hv) || hv < 0)
            {
                MessageBox.Show("Số học viên phải là số nguyên không âm.");
                txtHocVien.Focus();
                return null;
            }

            var startColor = txtMau1.Text.Trim();
            var endColor = txtMau2.Text.Trim();
            if (string.IsNullOrWhiteSpace(startColor) || string.IsNullOrWhiteSpace(endColor))
            {
                (startColor, endColor) = GenerateGradientPair();
                txtMau1.Text = startColor;
                txtMau2.Text = endColor;
            }

            int? instructorId = null;
            if (cboInstructor.SelectedIndex > 0 && cboInstructor.SelectedItem is Instructor selectedInstructor)
            {
                instructorId = selectedInstructor.InstructorId;
            }

            return new Course
            {
                TenKhoaHoc = txtTen.Text.Trim(),
                GiaGoc = txtGiaGoc.Text.Trim(),
                GiaGiam = txtGiaGiam.Text.Trim(),
                SoHocVien = hv,
                ThoiLuong = txtThoiLuong.Text.Trim(),
                TenAnh = txtAnh.Text.Trim(),
                MauBatDau = startColor,
                MauKetThuc = endColor,
                DemoLink = txtDemo.Text.Trim(),
                InstructorId = instructorId
            };
        }

        private void txtAnh_IconRightClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh bìa khóa học";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Chỉ cho chọn ảnh

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string sourceFileName = ofd.FileName;
                    string fileName = Path.GetFileName(sourceFileName);

                    txtAnh.Text = fileName;

                    try
                    {
                        string projectPath = Application.StartupPath;
                        string destFolder = Path.Combine(projectPath, "Images");
                        if (!Directory.Exists(destFolder))
                        {
                            Directory.CreateDirectory(destFolder);
                        }

                        string destPath = Path.Combine(destFolder, fileName);

                        File.Copy(sourceFileName, destPath, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể copy ảnh vào thư mục hệ thống: " + ex.Message);
                    }
                }
            }
        }

        private void ClearInputs()
        {
            txtId.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtGiaGoc.Text = string.Empty;
            txtGiaGiam.Text = string.Empty;
            txtHocVien.Text = "0";
            txtThoiLuong.Text = string.Empty;
            txtAnh.Text = string.Empty;
            var (m1, m2) = GenerateGradientPair();
            txtMau1.Text = m1;
            txtMau2.Text = m2;
            txtDemo.Text = string.Empty;
            cboInstructor.SelectedIndex = 0;
            _selected = null;
            UpdateSelectedStats(null);
        }

        private void EnableChartDoubleBuffer()
        {
            typeof(Chart).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                ?.SetValue(chartRevenue, true);
        }

        private void SetupChart()
        {
            chartRevenue.Series.Clear();
            chartRevenue.ChartAreas.Clear();
            var area = new ChartArea("RevenueArea");
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Angle = -30;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            area.AxisY.Minimum = 0;
            chartRevenue.ChartAreas.Add(area);

            var series = new Series("Doanh thu từng khóa")
            {
                ChartType = SeriesChartType.Column,
                ChartArea = "RevenueArea"
            };
            chartRevenue.Series.Add(series);
        }

        private (string start, string end) GenerateGradientPair()
        {
            double hue = _rnd.NextDouble() * 360;
            var start = HslToColor(hue, 0.65, 0.55);
            var end = HslToColor(hue, 0.70, 0.42);
            return (ColorToHex(start), ColorToHex(end));
        }

        private static Color HslToColor(double h, double s, double l)
        {
            h = h % 360;
            s = Math.Max(0, Math.Min(1, s));
            l = Math.Max(0, Math.Min(1, l));

            double c = (1 - Math.Abs(2 * l - 1)) * s;
            double x = c * (1 - Math.Abs((h / 60) % 2 - 1));
            double m = l - c / 2;

            double r = 0, g = 0, b = 0;
            if (h < 60) { r = c; g = x; }
            else if (h < 120) { r = x; g = c; }
            else if (h < 180) { g = c; b = x; }
            else if (h < 240) { g = x; b = c; }
            else if (h < 300) { r = x; b = c; }
            else { r = c; b = x; }

            return Color.FromArgb(
                (int)Math.Round((r + m) * 255),
                (int)Math.Round((g + m) * 255),
                (int)Math.Round((b + m) * 255));
        }

        private static string ColorToHex(Color c)
        {
            return ColorTranslator.ToHtml(c).ToUpperInvariant();
        }

        private void UpdateStats()
        {
            if (chartRevenue.Series.Count == 0) SetupChart();

            int totalCourses = _courses.Count;
            int totalStudents = _courses.Sum(c => c.SoHocVien);
            decimal totalRevenue = 0;

            var series = chartRevenue.Series[0];
            series.Points.Clear();
            _targets.Clear();
            bool animate = tabControl.SelectedTab == tabStats;

            foreach (var c in _courses)
            {
                var price = ParseMoney(c.GiaGiam);
                var revenue = price * c.SoHocVien;
                totalRevenue += revenue;
                double start = animate ? 0 : (double)revenue;
                int idx = series.Points.AddXY(c.TenKhoaHoc, start);
                series.Points[idx].Tag = c.Id;
                _targets.Add((double)revenue);
            }

            chartRevenue.ResetAutoValues();

            lblCountValue.Text = totalCourses.ToString();
            lblStudentsValue.Text = totalStudents.ToString();
            lblRevenueValue.Text = $"{totalRevenue:N0} đ";
            if (_selected == null) UpdateSelectedStats(null);

            _chartTimer.Stop();
            if (animate)
            {
                _chartTimer.Start();
            }
            else
            {
                for (int i = 0; i < series.Points.Count && i < _targets.Count; i++)
                {
                    series.Points[i].YValues[0] = _targets[i];
                }
            }
        }

        private void UpdateSelectedStats(Course courseOverride = null)
        {
            var course = courseOverride ?? _selected;
            if (course == null)
            {
                lblSelCourse.Text = "Tất cả khóa học";
                lblSelStudents.Text = $"Học viên: {_courses.Sum(c => c.SoHocVien):N0}";
                lblSelRevenue.Text = $"Doanh thu: {_courses.Sum(c => ParseMoney(c.GiaGiam) * c.SoHocVien):N0} đ";
                return;
            }

            var revenue = ParseMoney(course.GiaGiam) * course.SoHocVien;
            lblSelCourse.Text = course.TenKhoaHoc;
            lblSelStudents.Text = $"Học viên: {course.SoHocVien:N0}";
            lblSelRevenue.Text = $"Doanh thu: {revenue:N0} đ";
        }

        private void chartRevenue_MouseClick(object sender, MouseEventArgs e)
        {
            var hit = chartRevenue.HitTest(e.X, e.Y);
            if (hit?.Series == null || hit.PointIndex < 0) return;

            var point = hit.Series.Points[hit.PointIndex];
            Course course = null;
            if (point.Tag is int id)
            {
                course = _courses.FirstOrDefault(c => c.Id == id);
            }
            else
            {
                var label = point.AxisLabel;
                course = _courses.FirstOrDefault(c => c.TenKhoaHoc == label);
            }

            if (course != null)
            {
                _selected = course;
                UpdateSelectedStats(course);
            }
        }

        private void ChartTimer_Tick(object sender, EventArgs e)
        {
            if (chartRevenue.Series.Count == 0) return;
            var points = chartRevenue.Series[0].Points;
            bool done = true;

            for (int i = 0; i < points.Count; i++)
            {
                double target = i < _targets.Count ? _targets[i] : 0;
                double current = points[i].YValues[0];
                if (current < target)
                {
                    var delta = target - current;
                    double step = Math.Max(1, delta * 0.2);
                    current = Math.Min(target, current + step);
                    points[i].YValues[0] = current;
                    done = false;
                }
            }

            chartRevenue.ChartAreas[0].RecalculateAxesScale();
            chartRevenue.Invalidate();
            if (done) _chartTimer.Stop();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabStats)
            {
                UpdateStats();
            }
            else
            {
                _chartTimer.Stop();
            }
        }

        private void LocalizeGridHeaders()
        {
            void SetHeader(string name, string text)
            {
                if (dgvCourses.Columns.Contains(name))
                    dgvCourses.Columns[name].HeaderText = text;
            }

            SetHeader("Id", "ID");
            SetHeader("TenKhoaHoc", "Tên khóa học");
            SetHeader("GiaGoc", "Giá gốc");
            SetHeader("GiaGiam", "Giá giảm");
            SetHeader("SoHocVien", "Học viên");
            SetHeader("ThoiLuong", "Thời lượng");
            SetHeader("TenAnh", "Ảnh");
            SetHeader("MauBatDau", "Màu bắt đầu");
            SetHeader("MauKetThuc", "Màu kết thúc");
            SetHeader("DemoLink", "Demo");
            SetHeader("InstructorName", "Giảng viên");
        }

        private decimal ParseMoney(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return 0;
            var digits = new string(text.Where(char.IsDigit).ToArray());
            if (decimal.TryParse(digits, out var val))
                return val;
            return 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}