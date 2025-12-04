using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL.Helpers
{
    /// <summary>
    /// Trợ giúp đọc/ghi dữ liệu XML cho khóa học, tài khoản, đơn mua.
    /// </summary>
    internal static class XMLHelper
    {
        private static string DataDir => Path.Combine(Application.StartupPath, "Data");
        private static string CoursesPath => Path.Combine(DataDir, "KhoaHoc.xml");
        private static string AccountsPath => Path.Combine(DataDir, "Accounts.xml");
        private static string EnrollmentsPath => Path.Combine(DataDir, "UserCourses.xml");
        private static string VideosPath => Path.Combine(DataDir, "Videos.xml");
        private static string StudentsPath => Path.Combine(DataDir, "HocVien.xml");
        private static string InstructorsPath => Path.Combine(DataDir, "GiangVien.xml");

        public static void EnsureSeedData()
        {
            Directory.CreateDirectory(DataDir);

            if (!File.Exists(AccountsPath))
            {
                var doc = new XDocument(
                    new XElement("Accounts",
                        new XElement("Account",
                            new XElement("Username", "admin"),
                            new XElement("Password", "admin123"),
                            new XElement("FullName", "Quản trị viên"),
                            new XElement("Role", "Admin")),
                        new XElement("Account",
                            new XElement("Username", "hocvien"),
                            new XElement("Password", "123456"),
                            new XElement("FullName", "Học viên F8"),
                            new XElement("Role", "User"))
                    )
                );
                doc.Save(AccountsPath);
            }

            if (!File.Exists(EnrollmentsPath))
            {
                new XDocument(new XElement("UserCourses")).Save(EnrollmentsPath);
            }

            if (!File.Exists(VideosPath))
            {
                var doc = new XDocument(
                    new XElement("Videos",
                        new XElement("Video",
                            new XElement("CourseId", 1),
                            new XElement("Title", "Giới thiệu khóa HTML/CSS"),
                            new XElement("Url", "https://www.youtube.com/watch?v=zWSkX8r08i0"),
                            new XElement("Order", 1)),
                        new XElement("Video",
                            new XElement("CourseId", 1),
                            new XElement("Title", "Thiết lập VSCode cho HTML/CSS"),
                            new XElement("Url", "https://www.youtube.com/watch?v=R6plN3FvzFY"),
                            new XElement("Order", 2)),
                        new XElement("Video",
                            new XElement("CourseId", 2),
                            new XElement("Title", "JavaScript cơ bản - Biến và kiểu dữ liệu"),
                            new XElement("Url", "https://www.youtube.com/watch?v=MGhw6XliFgo"),
                            new XElement("Order", 1)),
                        new XElement("Video",
                            new XElement("CourseId", 3),
                            new XElement("Title", "ReactJS - Component và Props"),
                            new XElement("Url", "https://www.youtube.com/watch?v=Ke90Tje7VS0"),
                            new XElement("Order", 1))
                    ));
                doc.Save(VideosPath);
            }
        }

        public static List<Course> LoadCourses()
        {
            try
            {
                if (!File.Exists(CoursesPath)) return new List<Course>();
                var doc = XDocument.Load(CoursesPath);
                return doc.Descendants("KhoaHoc").Select(x => new Course
                {
                    Id = int.TryParse(x.Element("MaKhoaHoc")?.Value, out var id) ? id : 0,
                    TenKhoaHoc = x.Element("TenKhoaHoc")?.Value,
                    GiaGoc = x.Element("GiaGoc")?.Value,
                    GiaGiam = x.Element("GiaGiam")?.Value,
                    SoHocVien = int.TryParse(x.Element("SoHocVien")?.Value, out var hv) ? hv : 0,
                    ThoiLuong = x.Element("ThoiLuong")?.Value,
                    TenAnh = x.Element("TenAnh")?.Value,
                    MauBatDau = x.Element("MauBatDau")?.Value,
                    MauKetThuc = x.Element("MauKetThuc")?.Value,
                    DemoLink = x.Element("DemoLink")?.Value ?? "https://www.youtube.com/watch?v=3Cg3smqsOmk"
                }).OrderBy(c => c.Id).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không đọc được KhoaHoc.xml: " + ex.Message);
                return new List<Course>();
            }
        }

        public static void SaveCourses(IEnumerable<Course> courses)
        {
            var doc = new XDocument(
                new XElement("DanhSachKhoaHoc",
                    courses.Select(c => new XElement("KhoaHoc",
                        new XElement("MaKhoaHoc", c.Id),
                        new XElement("TenKhoaHoc", c.TenKhoaHoc),
                        new XElement("GiaGoc", c.GiaGoc),
                        new XElement("GiaGiam", c.GiaGiam),
                        new XElement("SoHocVien", c.SoHocVien),
                        new XElement("ThoiLuong", c.ThoiLuong),
                        new XElement("TenAnh", c.TenAnh),
                        new XElement("MauBatDau", c.MauBatDau),
                        new XElement("MauKetThuc", c.MauKetThuc),
                        new XElement("DemoLink", c.DemoLink)
                    ))
                ));
            doc.Save(CoursesPath);
        }

        public static List<Student> LoadStudentsFromXml()
        {
            if (!File.Exists(StudentsPath)) return new List<Student>();
            var doc = XDocument.Load(StudentsPath);
            return doc.Descendants("Student").Select(x => new Student
            {
                StudentId = int.TryParse(x.Element("StudentId")?.Value, out var id) ? id : 0,
                FullName = x.Element("FullName")?.Value,
                Email = x.Element("Email")?.Value,
                Phone = x.Element("Phone")?.Value,
                Address = x.Element("Address")?.Value
            }).ToList();
        }

        public static void SaveStudentsToXml(IEnumerable<Student> students)
        {
            Directory.CreateDirectory(DataDir);
            var doc = new XDocument(
                new XElement("Students",
                    students.Select(s => new XElement("Student",
                        new XElement("StudentId", s.StudentId),
                        new XElement("FullName", s.FullName),
                        new XElement("Email", s.Email),
                        new XElement("Phone", s.Phone),
                        new XElement("Address", s.Address)
                    ))));
            doc.Save(StudentsPath);
        }

        public static List<Instructor> LoadInstructorsFromXml()
        {
            if (!File.Exists(InstructorsPath)) return new List<Instructor>();
            var doc = XDocument.Load(InstructorsPath);
            return doc.Descendants("Instructor").Select(x => new Instructor
            {
                InstructorId = int.TryParse(x.Element("InstructorId")?.Value, out var id) ? id : 0,
                FullName = x.Element("FullName")?.Value,
                Email = x.Element("Email")?.Value,
                Phone = x.Element("Phone")?.Value,
                Expertise = x.Element("Expertise")?.Value
            }).ToList();
        }

        public static void SaveInstructorsToXml(IEnumerable<Instructor> instructors)
        {
            Directory.CreateDirectory(DataDir);
            var doc = new XDocument(
                new XElement("Instructors",
                    instructors.Select(i => new XElement("Instructor",
                        new XElement("InstructorId", i.InstructorId),
                        new XElement("FullName", i.FullName),
                        new XElement("Email", i.Email),
                        new XElement("Phone", i.Phone),
                        new XElement("Expertise", i.Expertise)
                    ))));
            doc.Save(InstructorsPath);
        }

        public static List<Account> LoadAccounts()
        {
            if (!File.Exists(AccountsPath)) return new List<Account>();
            var doc = XDocument.Load(AccountsPath);
            return doc.Descendants("Account").Select(x => new Account
            {
                Username = x.Element("Username")?.Value,
                Password = x.Element("Password")?.Value,
                FullName = x.Element("FullName")?.Value,
                Role = x.Element("Role")?.Value ?? "User"
            }).ToList();
        }

        public static void SaveAccounts(IEnumerable<Account> accounts)
        {
            var doc = new XDocument(
                new XElement("Accounts",
                    accounts.Select(a => new XElement("Account",
                        new XElement("Username", a.Username),
                        new XElement("Password", a.Password),
                        new XElement("FullName", a.FullName),
                        new XElement("Role", a.Role ?? "User")
                    ))));
            doc.Save(AccountsPath);
        }

        public static Account Authenticate(string username, string password)
        {
            var list = LoadAccounts();
            return list.FirstOrDefault(a =>
                string.Equals(a.Username, username, StringComparison.OrdinalIgnoreCase)
                && a.Password == password);
        }

        public static List<Video> LoadVideos(int courseId)
        {
            if (!File.Exists(VideosPath)) return new List<Video>();
            var doc = XDocument.Load(VideosPath);
            return doc.Descendants("Video")
                .Where(x => int.TryParse(x.Element("CourseId")?.Value, out var id) && id == courseId)
                .Select(x => new Video
                {
                    CourseId = courseId,
                    Title = x.Element("Title")?.Value,
                    Url = x.Element("Url")?.Value,
                    Order = int.TryParse(x.Element("Order")?.Value, out var o) ? o : 0
                })
                .OrderBy(v => v.Order)
                .ToList();
        }

        public static bool AddAccount(Account account, out string error)
        {
            error = string.Empty;
            var accounts = LoadAccounts();
            if (accounts.Any(a => string.Equals(a.Username, account.Username, StringComparison.OrdinalIgnoreCase)))
            {
                error = "Tài khoản đã tồn tại.";
                return false;
            }

            accounts.Add(account);
            SaveAccounts(accounts);
            return true;
        }

        public static List<int> LoadUserCourses(string username)
        {
            if (!File.Exists(EnrollmentsPath)) return new List<int>();
            var doc = XDocument.Load(EnrollmentsPath);
            return doc.Descendants("Enrollment")
                .Where(x => string.Equals(x.Element("Username")?.Value, username, StringComparison.OrdinalIgnoreCase))
                .Select(x => int.TryParse(x.Element("CourseId")?.Value, out var id) ? id : 0)
                .Where(id => id > 0)
                .Distinct()
                .ToList();
        }

        public static void AddUserCourse(string username, int courseId)
        {
            XDocument doc;
            if (File.Exists(EnrollmentsPath))
                doc = XDocument.Load(EnrollmentsPath);
            else
                doc = new XDocument(new XElement("UserCourses"));

            bool existed = doc.Descendants("Enrollment").Any(x =>
                string.Equals(x.Element("Username")?.Value, username, StringComparison.OrdinalIgnoreCase) &&
                x.Element("CourseId")?.Value == courseId.ToString());

            if (!existed)
            {
                doc.Root?.Add(new XElement("Enrollment",
                    new XElement("Username", username),
                    new XElement("CourseId", courseId)));
                doc.Save(EnrollmentsPath);
            }
        }
    }
}
