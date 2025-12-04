using System;
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
            ReloadData();
            SetupChart();
            UpdateStats();
            chartRevenue.MouseClick += chartRevenue_MouseClick;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
        }

        private void ReloadData()
        {
            _courses = DbHelper.LoadCourses();
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
                c.InstructorName
            }).ToList();
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.AutoResizeColumns();
            dgvCourses.ClearSelection();
            _selected = null;
            ClearInputs();
            LocalizeGridHeaders();
            UpdateStats();
            UpdateSelectedStats();
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
            newCourse.Id = DbHelper.AddCourse(newCourse);
            _courses.Add(newCourse);
            ReloadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Chọn một khóa học để sửa.");
                return;
            }

            var updated = ReadForm();
            if (updated == null) return;
            updated.Id = _selected.Id;

            DbHelper.UpdateCourse(updated);
            ReloadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Chọn một khóa học để xóa.");
                return;
            }

            if (MessageBox.Show("Xóa khóa học này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DbHelper.DeleteCourse(_selected.Id);
                ReloadData();
            }
        }

        private Course ReadForm()
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Tên khóa học không được trống.");
                return null;
            }

            int.TryParse(txtHocVien.Text, out var hv);
            var startColor = txtMau1.Text.Trim();
            var endColor = txtMau2.Text.Trim();
            if (string.IsNullOrWhiteSpace(startColor) || string.IsNullOrWhiteSpace(endColor))
            {
                (startColor, endColor) = GenerateGradientPair();
                txtMau1.Text = startColor;
                txtMau2.Text = endColor;
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
                DemoLink = txtDemo.Text.Trim()
            };
        }

        private void ClearInputs()
        {
            txtId.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtGiaGoc.Text = string.Empty;
            txtGiaGiam.Text = string.Empty;
            txtHocVien.Text = string.Empty;
            txtThoiLuong.Text = string.Empty;
            txtAnh.Text = string.Empty;
            var (m1, m2) = GenerateGradientPair();
            txtMau1.Text = m1;
            txtMau2.Text = m2;
            txtDemo.Text = string.Empty;
            _selected = null;
            UpdateSelectedStats(null);
        }

        private void EnableChartDoubleBuffer()
        {
            // Chart control hides DoubleBuffered; enable via reflection to reduce flicker while animating.
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
            // Sinh màu đồng bộ cùng tông để tránh phải nhập tay.
            double hue = _rnd.NextDouble() * 360; // 0-360
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
                    double step = Math.Max(1, delta * 0.2); // ease-out to keep animation smooth
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
    }
}
