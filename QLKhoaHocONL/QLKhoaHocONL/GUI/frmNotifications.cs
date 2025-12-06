// ============= FILE: frmNotifications.cs =============
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QLKhoaHocONL.Helpers;

namespace QLKhoaHocONL.GUI
{
    internal partial class frmNotifications : Form
    {
        public frmNotifications()
        {
            InitializeComponent();
            LoadData();
        }

        // ===== EVENT HANDLERS =====

        private void gridNotifications_DoubleClick(object sender, EventArgs e)
        {
            MarkSelectedAsRead();
        }

        private void btnMarkRead_Click(object sender, EventArgs e)
        {
            MarkSelectedAsRead();
        }

        private void btnMarkAll_Click(object sender, EventArgs e)
        {
            try
            {
                DbHelper.MarkAllNotificationsAsRead();
                LoadData();
                MessageBox.Show(
                    "Đã đánh dấu tất cả thông báo là đã xem!",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void chkOnlyUnread_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        // ===== HELPER METHODS =====

        private void LoadData()
        {
            try
            {
                bool onlyUnread = chkOnlyUnread.Checked;
                var items = DbHelper.LoadNotifications(includeRead: !onlyUnread);

                gridNotifications.Rows.Clear();

                foreach (var notification in items)
                {
                    int rowIndex = gridNotifications.Rows.Add(
                        notification.Id,
                        notification.Title,
                        notification.Content,
                        notification.CreatedAt.ToString("dd/MM/yyyy HH:mm"),
                        notification.IsRead ? "Đã xem" : "Chưa xem"
                    );

                    // Highlight unread notifications
                    if (!gridNotifications.Rows[rowIndex].IsNewRow && !notification.IsRead)
                    {
                        gridNotifications.Rows[rowIndex].DefaultCellStyle.Font =
                            new Font(gridNotifications.DefaultCellStyle.Font, FontStyle.Bold);
                        gridNotifications.Rows[rowIndex].DefaultCellStyle.ForeColor =
                            Color.FromArgb(233, 83, 43);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi tải dữ liệu: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void MarkSelectedAsRead()
        {
            try
            {
                if (gridNotifications.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Vui lòng chọn ít nhất một thông báo!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                var ids = gridNotifications.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Select(row => Convert.ToInt32(row.Cells[0].Value))
                    .ToList();

                DbHelper.MarkNotificationsAsRead(ids);
                LoadData();

                MessageBox.Show(
                    $"Đã đánh dấu {ids.Count} thông báo là đã xem!",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblHint_Click(object sender, EventArgs e)
        {

        }
    }
}