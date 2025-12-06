using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using QLKhoaHocONL.Helpers;

namespace QLKhoaHocONL
{
    public partial class frmXMLData : Form
    {
        private enum DataKind { Courses, Students, Instructors, All }
        private DataKind _current = DataKind.Courses;

        public frmXMLData()
        {
            InitializeComponent();
            InitializeEvents();
            LoadInitialData();
        }

        private void InitializeEvents()
        {
            cboLoaiDuLieu.SelectedIndexChanged += cboLoaiDuLieu_SelectedIndexChanged;

            treeXML.AfterSelect += treeXML_AfterSelect;

            panelTop.MouseDown += PanelTop_MouseDown;
            panelTop.MouseMove += PanelTop_MouseMove;
            panelTop.MouseUp += PanelTop_MouseUp;
        }

        private bool _isDragging = false;
        private System.Drawing.Point _dragStartPoint;

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = true;
                _dragStartPoint = e.Location;
            }
        }

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                System.Drawing.Point newLocation = this.Location;
                newLocation.X += e.X - _dragStartPoint.X;
                newLocation.Y += e.Y - _dragStartPoint.Y;
                this.Location = newLocation;
            }
        }

        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
        }

        private void LoadInitialData()
        {
            cboLoaiDuLieu.SelectedIndex = 0;
            RefreshCurrentData();
        }

        private void cboLoaiDuLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            _current = cboLoaiDuLieu.SelectedIndex switch
            {
                0 => DataKind.Courses,
                1 => DataKind.Students,
                2 => DataKind.Instructors,
                _ => DataKind.All
            };

            RefreshCurrentData();
        }

        private void btnSyncAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(
                    "Bạn có chắc muốn đồng bộ TẤT CẢ dữ liệu từ SQL sang XML?\n\n" +
                    "- Khóa Học\n- Học Viên\n- Giảng Viên\n\n",
                    "Xác Nhận Đồng Bộ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int totalRecords = 0;

                    var courses = DbHelper.LoadCourses();
                    XMLHelper.SaveCourses(courses);
                    totalRecords += courses.Count;

                    var students = DbHelper.LoadStudents();
                    XMLHelper.SaveStudentsToXml(students);
                    totalRecords += students.Count;

                    var instructors = DbHelper.LoadInstructors();
                    XMLHelper.SaveInstructorsToXml(instructors);
                    totalRecords += instructors.Count;

                    LoadTreeAndContent();

                    MessageBox.Show(
                        $"✅ Đã đồng bộ thành công TẤT CẢ dữ liệu từ SQL → XML!\n\n" +
                        $"📊 Tổng số bản ghi: {totalRecords}\n" +
                        $"   • Khóa học: {courses.Count}\n" +
                        $"   • Học viên: {students.Count}\n" +
                        $"   • Giảng viên: {instructors.Count}",
                        "Thành Công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Lỗi đồng bộ SQL → XML:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSyncSelected_Click(object sender, EventArgs e)
        {
            try
            {
                string dataType = _current switch
                {
                    DataKind.Courses => "Khóa Học",
                    DataKind.Students => "Học Viên",
                    DataKind.Instructors => "Giảng Viên",
                    DataKind.All => "TẤT CẢ (Giảng viên, Khóa học, Học viên)",
                    _ => throw new NotImplementedException()
                };

                if (MessageBox.Show(
                    $"Bạn có chắc muốn đồng bộ dữ liệu '{dataType}' từ XML sang SQL?\n\n" +
                    "⚠️ Dữ liệu trong SQL sẽ được thay thế bởi dữ liệu từ file XML!",
                    "Xác Nhận Đồng Bộ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int recordCount = 0;

                    if (_current == DataKind.All)
                    {
                       

                        // Giảng viên trước
                        var instructors = XMLHelper.LoadInstructorsFromXml();
                        DbHelper.ReplaceInstructors(instructors);
                        int countInstr = instructors.Count;

                        // Khóa học
                        var courses = XMLHelper.LoadCourses();
                        DbHelper.ReplaceCourses(courses);
                        int countCourses = courses.Count;

                        // Học viên
                        var students = XMLHelper.LoadStudentsFromXml();
                        DbHelper.ReplaceStudents(students);
                        int countStudents = students.Count;

                        recordCount = countInstr + countCourses + countStudents;

                        MessageBox.Show(
                            $"✅ Đã đồng bộ TOÀN BỘ từ XML → SQL thành công!\n\n" +
                            $"📊 Tổng số: {recordCount}\n" +
                            $"   • Giảng viên: {countInstr}\n" +
                            $"   • Khóa học: {countCourses}\n" +
                            $"   • Học viên: {countStudents}",
                            "Thành Công",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        switch (_current)
                        {
                            case DataKind.Courses:
                                var courses = XMLHelper.LoadCourses();
                                DbHelper.ReplaceCourses(courses);
                                recordCount = courses.Count;
                                break;
                            case DataKind.Students:
                                var students = XMLHelper.LoadStudentsFromXml();
                                DbHelper.ReplaceStudents(students);
                                recordCount = students.Count;
                                break;
                            case DataKind.Instructors:
                                var instructors = XMLHelper.LoadInstructorsFromXml();
                                DbHelper.ReplaceInstructors(instructors);
                                recordCount = instructors.Count;
                                break;
                        }

                        MessageBox.Show(
                            $"✅ Đã đồng bộ '{dataType}' từ XML → SQL thành công!\n\n" +
                            $"📊 Số bản ghi: {recordCount}",
                            "Thành Công",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Lỗi đồng bộ XML → SQL:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadXml_Click(object sender, EventArgs e)
        {
            RefreshCurrentData(showMessage: true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeXML_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Tag != null)
            {
                txtXMLContent.Text = e.Node.Tag.ToString();
            }
        }

        private void RefreshCurrentData(bool showMessage = false)
        {
            try
            {
                if (_current == DataKind.All)
                {
                    treeXML.Nodes.Clear();
                    txtXMLContent.Text = "ℹ️ Chế độ 'Tất Cả' được chọn.\n\n" +
                                         "- Sử dụng nút 'Đồng Bộ XML → SQL' để đẩy toàn bộ dữ liệu lên Database.\n" +
                                         "- Sử dụng nút 'Đồng Bộ SQL → XML' để sao lưu toàn bộ Database về XML.\n\n" +
                                         "Vui lòng chọn từng loại cụ thể (Khóa Học, Giảng Viên...) để xem chi tiết nội dung.";
                    if (showMessage)
                    {
                        MessageBox.Show("Đang ở chế độ chọn Tất Cả. Vui lòng thao tác đồng bộ trực tiếp.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }

                string dataType = _current switch
                {
                    DataKind.Courses => "Khóa Học",
                    DataKind.Students => "Học Viên",
                    _ => "Giảng Viên"
                };

                LoadTreeAndContent();

                int recordCount = 0;
                string xmlPath = GetXmlPath();

                if (File.Exists(xmlPath))
                {
                    XDocument doc = XDocument.Load(xmlPath);
                    if (doc.Root != null)
                    {
                        recordCount = doc.Root.Elements().Count();
                    }
                }

                if (showMessage)
                {
                    MessageBox.Show(
                        $"✅ Đã tải lại dữ liệu '{dataType}' từ file XML!\n\n" +
                        $"📊 Tổng số bản ghi tìm thấy: {recordCount}\n",
                        "Làm Mới Thành Công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Lỗi làm mới dữ liệu:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTreeAndContent()
        {
            try
            {
                if (_current == DataKind.All) return;

                string xmlPath = GetXmlPath();

                if (!File.Exists(xmlPath))
                {
                    txtXMLContent.Text = $"⚠️ File XML chưa tồn tại: {xmlPath}\n\n" +
                                        "Vui lòng sử dụng nút 'Đồng Bộ SQL → XML' để tạo file.";
                    treeXML.Nodes.Clear();
                    return;
                }

                string xmlContent = File.ReadAllText(xmlPath);
                txtXMLContent.Text = FormatXml(xmlContent);

                LoadXmlTree(xmlPath);
            }
            catch (Exception ex)
            {
                txtXMLContent.Text = $"❌ Lỗi đọc file XML:\n{ex.Message}";
                treeXML.Nodes.Clear();
            }
        }

        private string GetXmlPath()
        {
            string dataFolder = Path.Combine(Application.StartupPath, "Data");
            if (!Directory.Exists(dataFolder))
            {
                Directory.CreateDirectory(dataFolder);
            }

            return _current switch
            {
                DataKind.Courses => Path.Combine(dataFolder, "KhoaHoc.xml"),
                DataKind.Students => Path.Combine(dataFolder, "HocVien.xml"),
                _ => Path.Combine(dataFolder, "GiangVien.xml")
            };
        }

        private void LoadXmlTree(string xmlPath)
        {
            try
            {
                treeXML.Nodes.Clear();

                XDocument xdoc = XDocument.Load(xmlPath);
                if (xdoc.Root == null) return;

                TreeNode rootNode = new TreeNode(xdoc.Root.Name.LocalName)
                {
                    Tag = xdoc.Root.ToString()
                };

                LoadXmlNode(xdoc.Root, rootNode);
                treeXML.Nodes.Add(rootNode);
                treeXML.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải cây XML: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadXmlNode(XElement element, TreeNode treeNode)
        {
            foreach (var child in element.Elements())
            {
                TreeNode childNode = new TreeNode(child.Name.LocalName)
                {
                    Tag = child.ToString()
                };

                if (child.HasAttributes)
                {
                    foreach (var attr in child.Attributes())
                    {
                        TreeNode attrNode = new TreeNode($"@{attr.Name.LocalName} = \"{attr.Value}\"");
                        childNode.Nodes.Add(attrNode);
                    }
                }

                if (!child.HasElements && !string.IsNullOrWhiteSpace(child.Value))
                {
                    TreeNode textNode = new TreeNode($"= {child.Value}");
                    childNode.Nodes.Add(textNode);
                }

                LoadXmlNode(child, childNode);
                treeNode.Nodes.Add(childNode);
            }
        }

        private string FormatXml(string xml)
        {
            try
            {
                XDocument doc = XDocument.Parse(xml);
                return doc.ToString();
            }
            catch
            {
                return xml;
            }
        }
    }
}