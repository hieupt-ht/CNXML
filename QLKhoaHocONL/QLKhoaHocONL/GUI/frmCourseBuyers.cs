// ============= FILE: frmCourseBuyers.cs =============
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL.GUI
{
    internal partial class frmCourseBuyers : Form
    {
        private readonly string _courseName;
        private readonly List<CourseBuyer> _buyers;

        public frmCourseBuyers(string courseName, List<CourseBuyer> buyers)
        {
            InitializeComponent();

            _courseName = courseName;
            _buyers = buyers;

            this.Text = $"Học viên mua: {courseName}";

            // Load data
            LoadBuyersData();
        }

        private void LoadBuyersData()
        {
            gridBuyers.Rows.Clear();

            int stt = 1;
            foreach (var buyer in _buyers)
            {
                string displayName = string.IsNullOrWhiteSpace(buyer.FullName)
                    ? buyer.Username
                    : buyer.FullName;

                gridBuyers.Rows.Add(
                    stt++,
                    displayName,
                    buyer.Email ?? string.Empty,
                    buyer.Phone ?? string.Empty,
                    buyer.PurchasedAt.ToString("dd/MM/yyyy HH:mm")
                );
            }
        }
    }
}