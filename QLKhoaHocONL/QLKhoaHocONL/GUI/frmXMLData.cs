using System;
using System.Linq;
using System.Windows.Forms;
using QLKhoaHocONL.Helpers;

namespace QLKhoaHocONL
{
    public partial class frmXMLData : Form
    {
        private enum DataKind { Courses, Students, Instructors }

        private readonly DataGridView _grid = new DataGridView();
        private readonly ComboBox _cboType = new ComboBox();
        private DataKind _current = DataKind.Courses;

        public frmXMLData()
        {
            InitializeComponent();
            BuildUI();
        }

        private void BuildUI()
        {
            Text = "Đồng bộ SQL ↔ XML";
            Width = 900;
            Height = 560;
            StartPosition = FormStartPosition.CenterParent;

            _cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboType.Items.AddRange(new object[] { "Khóa học", "Học viên", "Giảng viên" });
            _cboType.SelectedIndex = 0;
            _cboType.SelectedIndexChanged += (_, __) =>
            {
                _current = _cboType.SelectedIndex switch
                {
                    0 => DataKind.Courses,
                    1 => DataKind.Students,
                    _ => DataKind.Instructors
                };
                _grid.DataSource = null;
            };

            var btnLoadDb = new Button { Text = "Lấy dữ liệu SQL", Width = 140 };
            var btnExportXml = new Button { Text = "Xuất ra XML", Width = 140 };
            var btnImportXml = new Button { Text = "Nhập XML → SQL", Width = 160 };

            btnLoadDb.Click += (_, __) => LoadFromDb();
            btnExportXml.Click += (_, __) => ExportToXml();
            btnImportXml.Click += (_, __) => ImportFromXml();

            var topPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 50,
                Padding = new Padding(8),
                FlowDirection = FlowDirection.LeftToRight
            };
            topPanel.Controls.AddRange(new Control[] { new Label { Text = "Đối tượng:", AutoSize = true, Padding = new Padding(0, 8, 8, 0) }, _cboType, btnLoadDb, btnExportXml, btnImportXml });

            _grid.Dock = DockStyle.Fill;
            _grid.ReadOnly = true;
            _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _grid.MultiSelect = false;
            _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Controls.Add(_grid);
            Controls.Add(topPanel);
        }

        private void LoadFromDb()
        {
            switch (_current)
            {
                case DataKind.Courses:
                    _grid.DataSource = DbHelper.LoadCourses().Select(c => new
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
                    break;
                case DataKind.Students:
                    _grid.DataSource = DbHelper.LoadStudents().Select(s => new
                    {
                        s.StudentId,
                        s.FullName,
                        s.Email,
                        s.Phone,
                        s.Address
                    }).ToList();
                    break;
                case DataKind.Instructors:
                    _grid.DataSource = DbHelper.LoadInstructors().Select(i => new
                    {
                        i.InstructorId,
                        i.FullName,
                        i.Email,
                        i.Phone,
                        i.Expertise
                    }).ToList();
                    break;
            }
        }

        private void ExportToXml()
        {
            try
            {
                switch (_current)
                {
                    case DataKind.Courses:
                        XMLHelper.SaveCourses(DbHelper.LoadCourses());
                        break;
                    case DataKind.Students:
                        XMLHelper.SaveStudentsToXml(DbHelper.LoadStudents());
                        break;
                    case DataKind.Instructors:
                        XMLHelper.SaveInstructorsToXml(DbHelper.LoadInstructors());
                        break;
                }
                MessageBox.Show("Đã xuất ra thư mục Data/ thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất XML: " + ex.Message);
            }
        }

        private void ImportFromXml()
        {
            try
            {
                switch (_current)
                {
                    case DataKind.Courses:
                        var courses = XMLHelper.LoadCourses();
                        DbHelper.ReplaceCourses(courses);
                        break;
                    case DataKind.Students:
                        var students = XMLHelper.LoadStudentsFromXml();
                        DbHelper.ReplaceStudents(students);
                        break;
                    case DataKind.Instructors:
                        var instructors = XMLHelper.LoadInstructorsFromXml();
                        DbHelper.ReplaceInstructors(instructors);
                        break;
                }
                LoadFromDb();
                MessageBox.Show("Đã nhập dữ liệu từ XML vào SQL.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập XML: " + ex.Message);
            }
        }
    }
}
