using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL.GUI
{
    internal class frmCourseBuyers : Form
    {
        public frmCourseBuyers(string courseName, List<CourseBuyer> buyers)
        {
            Text = $"Hoc vien mua: {courseName}";
            StartPosition = FormStartPosition.CenterParent;
            Width = 760;
            Height = 420;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            var grid = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false
            };

            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", Width = 60, FillWeight = 40 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ho ten/Username" });
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email" });
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phone", FillWeight = 80 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngay mua", FillWeight = 90 });

            int stt = 1;
            foreach (var b in buyers)
            {
                string displayName = string.IsNullOrWhiteSpace(b.FullName) ? b.Username : b.FullName;
                grid.Rows.Add(
                    stt++,
                    displayName,
                    b.Email ?? string.Empty,
                    b.Phone ?? string.Empty,
                    b.PurchasedAt.ToString("dd/MM/yyyy HH:mm")
                );
            }

            Controls.Add(grid);
        }
    }
}
