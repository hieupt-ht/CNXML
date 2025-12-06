using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QLKhoaHocONL
{
    public partial class UcRoadmap : UserControl
    {
        public UcRoadmap()
        {
            InitializeComponent();

            // Set up button click events
            btnFrontend.Click += (s, e) => OpenLink("https://fullstack.edu.vn/learning-paths/front-end-development");
            btnBackend.Click += (s, e) => OpenLink("https://fullstack.edu.vn/learning-paths/back-end-development");
        }

        private void OpenLink(string link)
        {
            try
            {
                Process.Start(new ProcessStartInfo { FileName = link, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không mở được link: " + ex.Message);
            }
        }
    }
}
