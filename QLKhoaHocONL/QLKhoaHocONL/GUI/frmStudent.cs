using System;
using System.Linq;
using System.Windows.Forms;
using QLKhoaHocONL.Helpers;
using QLKhoaHocONL.Models;
using System.Drawing;

namespace QLKhoaHocONL.GUI
{
    public partial class frmStudent : Form
    {
        private Student _selected;

        public frmStudent()
        {
            InitializeComponent();
            ApplyVietnameseFonts();

            txtPhone.KeyPress += TxtPhone_KeyPress;
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtPhone.Text.Length >= 10 && !char.IsControl(e.KeyChar) && txtPhone.SelectionLength == 0)
            {
                e.Handled = true;
            }
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ApplyVietnameseFonts()
        {
            var font = new Font("Times New Roman", 10, FontStyle.Regular);
            var fontBold = new Font("Times New Roman", 10, FontStyle.Bold);

            this.Font = font;

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

            dgvStudents.ColumnHeadersDefaultCellStyle.Font = fontBold;
            dgvStudents.DefaultCellStyle.Font = font;
        }

        private void LoadData()
        {
           
            var list = XmlRepository.GetStudents();

            dgvStudents.DataSource = list.Select(s => new
            {
                s.StudentId,
                s.FullName,
                s.Email,
                s.Phone,
                s.Address
            }).ToList();

            dgvStudents.ClearSelection();
            _selected = null;
            ClearInputs();
            LocalizeGridHeaders();
        }

        private void LocalizeGridHeaders()
        {
            void SetHeader(string name, string text)
            {
                if (dgvStudents.Columns.Contains(name))
                    dgvStudents.Columns[name].HeaderText = text;
            }

            SetHeader("StudentId", "ID");
            SetHeader("FullName", "Họ tên");
            SetHeader("Email", "Email");
            SetHeader("Phone", "Số điện thoại");
            SetHeader("Address", "Địa chỉ");
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0) return;

            var row = dgvStudents.SelectedRows[0];
            _selected = new Student
            {
                StudentId = (int)row.Cells["StudentId"].Value,
                FullName = row.Cells["FullName"].Value?.ToString(),
                Email = row.Cells["Email"].Value?.ToString(),
                Phone = row.Cells["Phone"].Value?.ToString(),
                Address = row.Cells["Address"].Value?.ToString()
            };

            txtId.Text = _selected.StudentId.ToString();
            txtName.Text = _selected.FullName;
            txtEmail.Text = _selected.Email;
            txtPhone.Text = _selected.Phone;
            txtAddress.Text = _selected.Address;
        }

        private Student ReadForm()
        {
            // Kiểm tra Tên
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Họ tên không được trống.");
                txtName.Focus();
                return null;
            }

            // Kiểm tra Email
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email là bắt buộc.");
                txtEmail.Focus();
                return null;
            }

            // Check trùng Email trong danh sách XML hiện tại của Học Viên
            var currentList = XmlRepository.GetStudents();
            // Nếu tìm thấy ai đó có cùng email (mà ID khác với người đang sửa) -> Báo lỗi
            bool isDuplicate = currentList.Any(s =>
                s.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                (_selected == null || s.StudentId != _selected.StudentId)
            );

            if (isDuplicate)
            {
                MessageBox.Show($"Email '{email}' đã tồn tại! Vui lòng nhập email khác.");
                txtEmail.Focus();
                return null;
            }

            // Kiểm tra Số điện thoại (10 số hoặc Null)
            string phone = txtPhone.Text.Trim();
            if (string.IsNullOrEmpty(phone))
            {
                phone = null;
            }
            else
            {
                if (phone.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải có đúng 10 chữ số.");
                    txtPhone.Focus();
                    return null;
                }
            }

            return new Student
            {
                FullName = txtName.Text.Trim(),
                Email = email,
                Phone = phone,
                Address = txtAddress.Text.Trim()
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = ReadForm();
            if (student == null) return;

            XmlRepository.AddStudent(student);
            LoadData(); // Load lại từ XML -> Thấy ngay dữ liệu mới
            MessageBox.Show("Đã thêm học viên thành công vào XML!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Chọn học viên để sửa.");
                return;
            }

            var student = ReadForm();
            if (student == null) return;

            student.StudentId = _selected.StudentId;
            XmlRepository.UpdateStudent(student);
            LoadData();
            MessageBox.Show("Đã cập nhật thành công vào XML!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Chọn học viên để xóa.");
                return;
            }

            if (MessageBox.Show("Xóa học viên này khỏi XML?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                XmlRepository.DeleteStudent(_selected.StudentId);
                LoadData();
                MessageBox.Show("Đã xóa thành công khỏi XML!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearInputs()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            _selected = null;
        }
    }
}