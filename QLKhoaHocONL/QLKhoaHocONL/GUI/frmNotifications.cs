using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QLKhoaHocONL.Helpers;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL.GUI
{
    internal class frmNotifications : Form
    {
        private readonly DataGridView _grid = new DataGridView();
        private readonly FlowLayoutPanel _panelButtons = new FlowLayoutPanel();
        private readonly Button _btnMarkRead = new Button();
        private readonly Button _btnMarkAll = new Button();
        private readonly Button _btnRefresh = new Button();
        private readonly CheckBox _chkOnlyUnread = new CheckBox();
        private readonly Label _lblHint = new Label();

        public frmNotifications()
        {
            Text = "Thông báo";
            StartPosition = FormStartPosition.CenterParent;
            Width = 820;
            Height = 520;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            BuildGrid();
            BuildButtons();
            BuildHint();

            Controls.Add(_grid);
            Controls.Add(_panelButtons);
            Controls.Add(_lblHint);

            LoadData();
        }

        private void BuildGrid()
        {
            _grid.Dock = DockStyle.Fill;
            _grid.AllowUserToAddRows = false;
            _grid.AllowUserToDeleteRows = false;
            _grid.ReadOnly = true;
            _grid.RowHeadersVisible = false;
            _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _grid.MultiSelect = true;
            _grid.BackgroundColor = Color.White;
            _grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 252);
            _grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 241, 233);
            _grid.DefaultCellStyle.SelectionForeColor = Color.Black;
            _grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 249, 240);
            _grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(51, 51, 51);
            _grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _grid.ColumnHeadersHeight = 38;
            _grid.EnableHeadersVisualStyles = false;

            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", Visible = false });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tiêu đề", FillWeight = 130 });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nội dung", FillWeight = 230 });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thời gian", FillWeight = 90 });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", FillWeight = 70 });

            _grid.DoubleClick += (s, e) => MarkSelectedAsRead();
        }

        private void BuildButtons()
        {
            _panelButtons.Dock = DockStyle.Bottom;
            _panelButtons.Height = 50;
            _panelButtons.FlowDirection = FlowDirection.RightToLeft;
            _panelButtons.Padding = new Padding(6, 8, 6, 8);

            _btnMarkRead.Text = "Đánh dấu đã xem";
            _btnMarkRead.Width = 150;
            _btnMarkRead.Click += (s, e) => { MarkSelectedAsRead(); };

            _btnMarkAll.Text = "Đánh dấu tất cả";
            _btnMarkAll.Width = 130;
            _btnMarkAll.Click += (s, e) => { DbHelper.MarkAllNotificationsAsRead(); LoadData(); };

            _btnRefresh.Text = "Làm mới";
            _btnRefresh.Width = 100;
            _btnRefresh.Click += (s, e) => LoadData();

            _chkOnlyUnread.Text = "Chỉ hiện chưa xem";
            _chkOnlyUnread.Width = 140;
            _chkOnlyUnread.CheckedChanged += (s, e) => LoadData();

            _panelButtons.Controls.Add(_btnRefresh);
            _panelButtons.Controls.Add(_btnMarkAll);
            _panelButtons.Controls.Add(_btnMarkRead);
            _panelButtons.Controls.Add(_chkOnlyUnread);
        }

        private void BuildHint()
        {
            _lblHint.Dock = DockStyle.Top;
            _lblHint.Height = 26;
            _lblHint.TextAlign = ContentAlignment.MiddleLeft;
            _lblHint.Padding = new Padding(10, 0, 0, 0);
            _lblHint.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            _lblHint.ForeColor = Color.DimGray;
            _lblHint.Text = "Mẹo: double-click để đánh dấu đã xem.";
        }

        private void LoadData()
        {
            bool onlyUnread = _chkOnlyUnread.Checked;
            var items = DbHelper.LoadNotifications(includeRead: !onlyUnread);

            _grid.Rows.Clear();
            foreach (var n in items)
            {
                int rowIndex = _grid.Rows.Add(
                    n.Id,
                    n.Title,
                    n.Content,
                    n.CreatedAt.ToString("dd/MM/yyyy HH:mm"),
                    n.IsRead ? "Đã xem" : "Chưa xem");

                if (!_grid.Rows[rowIndex].IsNewRow && !n.IsRead)
                {
                    _grid.Rows[rowIndex].DefaultCellStyle.Font = new Font(_grid.DefaultCellStyle.Font, FontStyle.Bold);
                    _grid.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(233, 83, 43);
                }
            }
        }

        private void MarkSelectedAsRead()
        {
            var ids = _grid.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(r => Convert.ToInt32(r.Cells[0].Value))
                .ToList();

            if (!ids.Any()) return;
            DbHelper.MarkNotificationsAsRead(ids);
            LoadData();
        }
    }
}
