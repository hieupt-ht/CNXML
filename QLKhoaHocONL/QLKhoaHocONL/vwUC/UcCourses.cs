using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace QLKhoaHocONL.vwUC
{
    public partial class UcCourses : UserControl
    {
        public UcCourses()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DocXML();
        }

        private void DocXML()
        {
            try
            {
                flowLayoutPanelKhoaHoc.Controls.Clear();
                string path = "KhoaHoc.xml";

                if (!File.Exists(path)) return;

                XDocument doc = XDocument.Load(path);

                foreach (var item in doc.Descendants("KhoaHoc"))
                {
                    UC_ItemKhoaHoc uc = new UC_ItemKhoaHoc();

                    string ten = item.Element("TenKhoaHoc")?.Value;
                    string giaCu = item.Element("GiaGoc")?.Value;
                    string giaMoi = item.Element("GiaGiam")?.Value;
                    string anh = item.Element("TenAnh")?.Value;
                    string mau1 = item.Element("MauBatDau")?.Value;
                    string mau2 = item.Element("MauKetThuc")?.Value;

                    string pathAnh = Path.Combine(Application.StartupPath, "Images", anh);

                    uc.NapDuLieu(ten, giaCu, giaMoi, pathAnh, mau1, mau2);

                    flowLayoutPanelKhoaHoc.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}