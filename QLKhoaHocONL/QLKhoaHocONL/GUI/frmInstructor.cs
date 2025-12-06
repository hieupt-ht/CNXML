using System;
using System.Linq;
using System.Windows.Forms;
using QLKhoaHocONL.Helpers;
using QLKhoaHocONL.Models;
using System.Drawing;

namespace QLKhoaHocONL.GUI
{
    public partial class frmInstructor : Form
    {
        private Instructor _selected;

        public frmInstructor()
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

        private void frmInstructor_Load(object sender, EventArgs e)
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

            dgvInstructors.ColumnHeadersDefaultCellStyle.Font = fontBold;
            dgvInstructors.DefaultCellStyle.Font = font;
        }

        private void LoadData()
        {
            var list = XmlRepository.GetInstructors();

            dgvInstructors.DataSource = list.Select(i => new
            {
                i.InstructorId,
                i.FullName,
                i.Email,
                i.Phone,
                i.Expertise
            }).ToList();

            dgvInstructors.ClearSelection();
            _selected = null;
            ClearInputs();
            LocalizeGridHeaders();
        }

        private void LocalizeGridHeaders()
        {
            void SetHeader(string name, string text)
            {
                if (dgvInstructors.Columns.Contains(name))
                    dgvInstructors.Columns[name].HeaderText = text;
            }

            SetHeader("InstructorId", "ID");
            SetHeader("FullName", "Họ tên");
            SetHeader("Email", "Email");
            SetHeader("Phone", "Số điện thoại");
            SetHeader("Expertise", "Chuyên môn");
        }

        private void dgvInstructors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInstructors.SelectedRows.Count == 0) return;

            var row = dgvInstructors.SelectedRows[0];
            _selected = new Instructor
            {
                InstructorId = (int)row.Cells["InstructorId"].Value,
                FullName = row.Cells["FullName"].Value?.ToString(),
                Email = row.Cells["Email"].Value?.ToString(),
                Phone = row.Cells["Phone"].Value?.ToString(),
                Expertise = row.Cells["Expertise"].Value?.ToString()
            };

            txtId.Text = _selected.InstructorId.ToString();
            txtName.Text = _selected.FullName;
            txtEmail.Text = _selected.Email;
            txtPhone.Text = _selected.Phone;
            txtExpertise.Text = _selected.Expertise;
        }

        private Instructor ReadForm()
        {
            // 1. Kiểm tra Tên
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Họ tên không được trống.");
                txtName.Focus();
                return null;
            }

            // 2. Kiểm tra Email 
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email là bắt buộc.");
                txtEmail.Focus();
                return null;
            }

            // Check trùng Email trong danh sách XML hiện tại
            var currentList = XmlRepository.GetInstructors();
            // Nếu tìm thấy ai đó có cùng email (mà ID khác với người đang sửa) -> Báo lỗi
            bool isDuplicate = currentList.Any(i =>
                i.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                (_selected == null || i.InstructorId != _selected.InstructorId)
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

            return new Instructor
            {
                FullName = txtName.Text.Trim(),
                Email = email,
                Phone = phone,
                Expertise = txtExpertise.Text.Trim()
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var instructor = ReadForm();
            if (instructor == null) return;

            XmlRepository.AddInstructor(instructor);
            LoadData();
            MessageBox.Show("Đã thêm giảng viên thành công vào XML!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Chọn giảng viên để sửa.");
                return;
            }

            var instructor = ReadForm();
            if (instructor == null) return;

            instructor.InstructorId = _selected.InstructorId;
            XmlRepository.UpdateInstructor(instructor);
            LoadData();
            MessageBox.Show("Đã cập nhật thành công vào XML!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Chọn giảng viên để xóa.");
                return;
            }

            if (MessageBox.Show("Xóa giảng viên này khỏi XML?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                XmlRepository.DeleteInstructor(_selected.InstructorId);
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
            txtExpertise.Text = string.Empty;
            _selected = null;
        }
    }
}