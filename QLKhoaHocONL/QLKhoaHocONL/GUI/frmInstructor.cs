using System;
using System.Linq;
using System.Windows.Forms;
using QLKhoaHocONL.Helpers;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL.GUI
{
    public class frmInstructor : Form
    {
        private readonly DataGridView _grid = new DataGridView();
        private readonly TextBox _txtName = new TextBox();
        private readonly TextBox _txtEmail = new TextBox();
        private readonly TextBox _txtPhone = new TextBox();
        private readonly TextBox _txtExp = new TextBox();
        private Instructor _selected;

        public frmInstructor()
        {
            Text = "Quản lý giảng viên";
            Width = 820;
            Height = 520;
            StartPosition = FormStartPosition.CenterParent;
            BuildUI();
            Load += (_, __) => LoadData();
        }

        private void BuildUI()
        {
            var panelForm = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 140,
                ColumnCount = 4,
                RowCount = 2,
                Padding = new Padding(8)
            };
            panelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
            panelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35));
            panelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
            panelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35));

            panelForm.Controls.Add(new Label { Text = "Họ tên", AutoSize = true, Anchor = AnchorStyles.Left }, 0, 0);
            panelForm.Controls.Add(_txtName, 1, 0);
            panelForm.Controls.Add(new Label { Text = "Email", AutoSize = true, Anchor = AnchorStyles.Left }, 2, 0);
            panelForm.Controls.Add(_txtEmail, 3, 0);
            panelForm.Controls.Add(new Label { Text = "SĐT", AutoSize = true, Anchor = AnchorStyles.Left }, 0, 1);
            panelForm.Controls.Add(_txtPhone, 1, 1);
            panelForm.Controls.Add(new Label { Text = "Chuyên môn", AutoSize = true, Anchor = AnchorStyles.Left }, 2, 1);
            panelForm.Controls.Add(_txtExp, 3, 1);

            _txtName.Dock = _txtEmail.Dock = _txtPhone.Dock = _txtExp.Dock = DockStyle.Fill;

            var btnPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 44,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(8, 0, 8, 0)
            };
            var btnAdd = new Button { Text = "Thêm", Width = 90 };
            var btnUpd = new Button { Text = "Sửa", Width = 90 };
            var btnDel = new Button { Text = "Xóa", Width = 90 };
            var btnClose = new Button { Text = "Đóng", Width = 90 };
            btnAdd.Click += (_, __) => AddInstructor();
            btnUpd.Click += (_, __) => UpdateInstructor();
            btnDel.Click += (_, __) => DeleteInstructor();
            btnClose.Click += (_, __) => Close();
            btnPanel.Controls.AddRange(new Control[] { btnAdd, btnUpd, btnDel, btnClose });

            _grid.Dock = DockStyle.Fill;
            _grid.ReadOnly = true;
            _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _grid.MultiSelect = false;
            _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _grid.CellClick += (_, __) => BindSelected();

            Controls.Add(_grid);
            Controls.Add(btnPanel);
            Controls.Add(panelForm);
        }

        private void LoadData()
        {
            var list = DbHelper.LoadInstructors();
            _grid.DataSource = list.Select(i => new
            {
                i.InstructorId,
                i.FullName,
                i.Email,
                i.Phone,
                i.Expertise
            }).ToList();
            _grid.ClearSelection();
            _selected = null;
            ClearInputs();
        }

        private void BindSelected()
        {
            if (_grid.SelectedRows.Count == 0) return;
            var row = _grid.SelectedRows[0];
            _selected = new Instructor
            {
                InstructorId = (int)row.Cells["InstructorId"].Value,
                FullName = row.Cells["FullName"].Value?.ToString(),
                Email = row.Cells["Email"].Value?.ToString(),
                Phone = row.Cells["Phone"].Value?.ToString(),
                Expertise = row.Cells["Expertise"].Value?.ToString()
            };
            _txtName.Text = _selected.FullName;
            _txtEmail.Text = _selected.Email;
            _txtPhone.Text = _selected.Phone;
            _txtExp.Text = _selected.Expertise;
        }

        private Instructor ReadForm()
        {
            if (string.IsNullOrWhiteSpace(_txtName.Text))
            {
                MessageBox.Show("Họ tên không được trống.");
                return null;
            }
            return new Instructor
            {
                FullName = _txtName.Text.Trim(),
                Email = _txtEmail.Text.Trim(),
                Phone = _txtPhone.Text.Trim(),
                Expertise = _txtExp.Text.Trim()
            };
        }

        private void AddInstructor()
        {
            var i = ReadForm();
            if (i == null) return;
            DbHelper.AddInstructor(i);
            LoadData();
        }

        private void UpdateInstructor()
        {
            if (_selected == null)
            {
                MessageBox.Show("Chọn giảng viên để sửa.");
                return;
            }
            var i = ReadForm();
            if (i == null) return;
            i.InstructorId = _selected.InstructorId;
            DbHelper.UpdateInstructor(i);
            LoadData();
        }

        private void DeleteInstructor()
        {
            if (_selected == null)
            {
                MessageBox.Show("Chọn giảng viên để xóa.");
                return;
            }
            if (MessageBox.Show("Xóa giảng viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DbHelper.DeleteInstructor(_selected.InstructorId);
                LoadData();
            }
        }

        private void ClearInputs()
        {
            _txtName.Text = _txtEmail.Text = _txtPhone.Text = _txtExp.Text = string.Empty;
        }
    }
}
