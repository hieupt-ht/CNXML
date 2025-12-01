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
            _courses = XMLHelper.LoadCourses();
            dgvCourses.DataSource = _courses.Select(c => new
            {
                c.Id,
                TenKhoaHoc = c.TenKhoaHoc,
                GiaGoc = c.GiaGoc,
                GiaGiam = c.GiaGiam,
                SoHocVien = c.SoHocVien,
                ThoiLuong = c.ThoiLuong,
                TenAnh = c.TenAnh,
                MauBatDau = c.MauBatDau,
                MauKetThuc = c.MauKetThuc,
                DemoLink = c.DemoLink
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
            newCourse.Id = _courses.Any() ? _courses.Max(c => c.Id) + 1 : 1;
            _courses.Add(newCourse);
            SaveAndRefresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Ch\u1ecdn m\u1ed9t kh\u00f3a h\u1ecdc \u0111\u1ec3 s\u1eeda.");
                return;
            }

            var updated = ReadForm();
            if (updated == null) return;
            updated.Id = _selected.Id;

            var idx = _courses.FindIndex(c => c.Id == _selected.Id);
            if (idx >= 0)
            {
                _courses[idx] = updated;
                SaveAndRefresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Ch\u1ecdn m\u1ed9t kh\u00f3a h\u1ecdc \u0111\u1ec3 x\u00f3a.");
                return;
            }

            if (MessageBox.Show("X\u00f3a kh\u00f3a h\u1ecdc n\u00e0y?", "X\u00e1c nh\u1eadn", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _courses = _courses.Where(c => c.Id != _selected.Id).ToList();
                SaveAndRefresh();
            }
        }

        private Course ReadForm()
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("T\u00ean kh\u00f3a h\u1ecdc kh\u00f4ng \u0111\u01b0\u1ee3c tr\u1ed1ng.");
                return null;
            }

            int.TryParse(txtHocVien.Text, out var hv);
            return new Course
            {
                TenKhoaHoc = txtTen.Text.Trim(),
                GiaGoc = txtGiaGoc.Text.Trim(),
                GiaGiam = txtGiaGiam.Text.Trim(),
                SoHocVien = hv,
                ThoiLuong = txtThoiLuong.Text.Trim(),
                TenAnh = txtAnh.Text.Trim(),
                MauBatDau = txtMau1.Text.Trim(),
                MauKetThuc = txtMau2.Text.Trim(),
                DemoLink = txtDemo.Text.Trim()
            };
        }

        private void SaveAndRefresh()
        {
            XMLHelper.SaveCourses(_courses);
            ReloadData();
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
            txtMau1.Text = string.Empty;
            txtMau2.Text = string.Empty;
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

            var series = new Series("Doanh thu t\u1eebng kh\u00f3a")
            {
                ChartType = SeriesChartType.Column,
                ChartArea = "RevenueArea"
            };
            chartRevenue.Series.Add(series);
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
            lblRevenueValue.Text = $"{totalRevenue:N0} \u0111";
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
                lblSelCourse.Text = "T\u1ea5t c\u1ea3 kh\u00f3a h\u1ecdc";
                lblSelStudents.Text = $"H\u1ecdc vi\u00ean: {_courses.Sum(c => c.SoHocVien):N0}";
                lblSelRevenue.Text = $"Doanh thu: {_courses.Sum(c => ParseMoney(c.GiaGiam) * c.SoHocVien):N0} \u0111";
                return;
            }

            var revenue = ParseMoney(course.GiaGiam) * course.SoHocVien;
            lblSelCourse.Text = course.TenKhoaHoc;
            lblSelStudents.Text = $"H\u1ecdc vi\u00ean: {course.SoHocVien:N0}";
            lblSelRevenue.Text = $"Doanh thu: {revenue:N0} \u0111";
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
