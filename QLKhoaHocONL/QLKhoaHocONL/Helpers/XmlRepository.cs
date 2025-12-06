using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL.Helpers
{
    internal static class XmlRepository
    {
        private static string DataFolder => Path.Combine(Application.StartupPath, "Data");
        private static string CourseXmlPath => Path.Combine(DataFolder, "KhoaHoc.xml");
        private static string StudentXmlPath => Path.Combine(DataFolder, "HocVien.xml");
        private static string InstructorXmlPath => Path.Combine(DataFolder, "GiangVien.xml");

        private static void EnsureFileExists(string path, string rootName)
        {
            if (!Directory.Exists(DataFolder)) Directory.CreateDirectory(DataFolder);
            if (!File.Exists(path))
            {
                new XDocument(new XElement(rootName)).Save(path);
            }
        }

        // =========================================================================
        // 1. QUẢN LÝ HỌC VIÊN (STUDENTS)
        // =========================================================================
        public static List<Student> GetStudents()
        {
            EnsureFileExists(StudentXmlPath, "Students");
            var doc = XDocument.Load(StudentXmlPath);

            return doc.Descendants("Student")
                      .Select(x => new Student
                      {
                          StudentId = (int?)x.Element("StudentId") ?? 0,
                          FullName = (string)x.Element("FullName"),
                          Email = (string)x.Element("Email"),
                          Phone = (string)x.Element("Phone"),
                          Address = (string)x.Element("Address")
                      })
                      .OrderBy(s => s.StudentId)
                      .ToList();
        }

        public static void AddStudent(Student s)
        {
            EnsureFileExists(StudentXmlPath, "Students");
            var doc = XDocument.Load(StudentXmlPath);

            int maxId = doc.Descendants("Student")
                           .Select(x => (int?)x.Element("StudentId"))
                           .Max() ?? 0;
            s.StudentId = maxId + 1;

            doc.Root.Add(new XElement("Student",
                new XElement("StudentId", s.StudentId),
                new XElement("FullName", s.FullName),
                new XElement("Email", s.Email ?? ""),
                new XElement("Phone", s.Phone ?? ""),
                new XElement("Address", s.Address ?? "")
            ));
            doc.Save(StudentXmlPath);
        }

        public static void UpdateStudent(Student s)
        {
            EnsureFileExists(StudentXmlPath, "Students");
            var doc = XDocument.Load(StudentXmlPath);

            var target = doc.Descendants("Student")
                            .FirstOrDefault(x => (int?)x.Element("StudentId") == s.StudentId);
            if (target != null)
            {
                target.SetElementValue("FullName", s.FullName);
                target.SetElementValue("Email", s.Email);
                target.SetElementValue("Phone", s.Phone);
                target.SetElementValue("Address", s.Address);
                doc.Save(StudentXmlPath);
            }
        }

        public static void DeleteStudent(int id)
        {
            EnsureFileExists(StudentXmlPath, "Students");
            var doc = XDocument.Load(StudentXmlPath);
            doc.Descendants("Student").Where(x => (int?)x.Element("StudentId") == id).Remove();
            doc.Save(StudentXmlPath);
        }

        // =========================================================================
        // 2. QUẢN LÝ GIẢNG VIÊN (INSTRUCTORS)
        // =========================================================================
        public static List<Instructor> GetInstructors()
        {
            EnsureFileExists(InstructorXmlPath, "Instructors");
            var doc = XDocument.Load(InstructorXmlPath);

            return doc.Descendants("Instructor")
                      .Select(x => new Instructor
                      {
                          InstructorId = (int?)x.Element("InstructorId") ?? 0,
                          FullName = (string)x.Element("FullName"),
                          Email = (string)x.Element("Email"),
                          Phone = (string)x.Element("Phone"),
                          Expertise = (string)x.Element("Expertise")
                      })
                      .OrderBy(i => i.InstructorId)
                      .ToList();
        }

        public static void AddInstructor(Instructor i)
        {
            EnsureFileExists(InstructorXmlPath, "Instructors");
            var doc = XDocument.Load(InstructorXmlPath);

            int maxId = doc.Descendants("Instructor")
                           .Select(x => (int?)x.Element("InstructorId"))
                           .Max() ?? 0;
            i.InstructorId = maxId + 1;

            doc.Root.Add(new XElement("Instructor",
                new XElement("InstructorId", i.InstructorId),
                new XElement("FullName", i.FullName),
                new XElement("Email", i.Email ?? ""),
                new XElement("Phone", i.Phone ?? ""),
                new XElement("Expertise", i.Expertise ?? "")
            ));
            doc.Save(InstructorXmlPath);
        }

        public static void UpdateInstructor(Instructor i)
        {
            EnsureFileExists(InstructorXmlPath, "Instructors");
            var doc = XDocument.Load(InstructorXmlPath);

            var target = doc.Descendants("Instructor")
                            .FirstOrDefault(x => (int?)x.Element("InstructorId") == i.InstructorId);
            if (target != null)
            {
                target.SetElementValue("FullName", i.FullName);
                target.SetElementValue("Email", i.Email);
                target.SetElementValue("Phone", i.Phone);
                target.SetElementValue("Expertise", i.Expertise);
                doc.Save(InstructorXmlPath);
            }
        }

        public static void DeleteInstructor(int id)
        {
            EnsureFileExists(InstructorXmlPath, "Instructors");
            var doc = XDocument.Load(InstructorXmlPath);
            doc.Descendants("Instructor").Where(x => (int?)x.Element("InstructorId") == id).Remove();
            doc.Save(InstructorXmlPath);
        }

        // =========================================================================
        // 3. QUẢN LÝ KHÓA HỌC (COURSES)
        // =========================================================================
        public static List<Course> GetCourses()
        {
            EnsureFileExists(CourseXmlPath, "Courses");
            var doc = XDocument.Load(CourseXmlPath);

            return doc.Descendants("Course")
                      .Select(x => new Course
                      {
                          Id = (int?)x.Element("Id") ?? 0,
                          TenKhoaHoc = (string)x.Element("TenKhoaHoc"),
                          GiaGoc = (string)x.Element("GiaGoc"),
                          GiaGiam = (string)x.Element("GiaGiam"),
                          SoHocVien = (int?)x.Element("SoHocVien") ?? 0,
                          ThoiLuong = (string)x.Element("ThoiLuong"),
                          TenAnh = (string)x.Element("TenAnh"),
                          MauBatDau = (string)x.Element("MauBatDau"),
                          MauKetThuc = (string)x.Element("MauKetThuc"),
                          DemoLink = (string)x.Element("DemoLink"),
                          InstructorId = (int?)x.Element("InstructorId"),
                          InstructorName = (string)x.Element("InstructorName")
                      })
                      .OrderBy(c => c.Id)
                      .ToList();
        }

        public static void AddCourse(Course c)
        {
            EnsureFileExists(CourseXmlPath, "Courses");
            var doc = XDocument.Load(CourseXmlPath);

            int maxId = doc.Descendants("Course")
                           .Select(x => (int?)x.Element("Id"))
                           .Max() ?? 0;
            c.Id = maxId + 1;

            doc.Root.Add(new XElement("Course",
                new XElement("Id", c.Id),
                new XElement("TenKhoaHoc", c.TenKhoaHoc),
                new XElement("GiaGoc", c.GiaGoc ?? ""),
                new XElement("GiaGiam", c.GiaGiam ?? ""),
                new XElement("SoHocVien", c.SoHocVien),
                new XElement("ThoiLuong", c.ThoiLuong ?? ""),
                new XElement("TenAnh", c.TenAnh ?? ""),
                new XElement("MauBatDau", c.MauBatDau ?? ""),
                new XElement("MauKetThuc", c.MauKetThuc ?? ""),
                new XElement("DemoLink", c.DemoLink ?? ""),
                new XElement("InstructorId", c.InstructorId),
                new XElement("InstructorName", c.InstructorName ?? "")
            ));
            doc.Save(CourseXmlPath);
        }

        public static void UpdateCourse(Course c)
        {
            EnsureFileExists(CourseXmlPath, "Courses");
            var doc = XDocument.Load(CourseXmlPath);

            var target = doc.Descendants("Course")
                            .FirstOrDefault(x => (int?)x.Element("Id") == c.Id);
            if (target != null)
            {
                target.SetElementValue("TenKhoaHoc", c.TenKhoaHoc);
                target.SetElementValue("GiaGoc", c.GiaGoc);
                target.SetElementValue("GiaGiam", c.GiaGiam);
                target.SetElementValue("SoHocVien", c.SoHocVien);
                target.SetElementValue("ThoiLuong", c.ThoiLuong);
                target.SetElementValue("TenAnh", c.TenAnh);
                target.SetElementValue("MauBatDau", c.MauBatDau);
                target.SetElementValue("MauKetThuc", c.MauKetThuc);
                target.SetElementValue("DemoLink", c.DemoLink);
                target.SetElementValue("InstructorId", c.InstructorId);
                target.SetElementValue("InstructorName", c.InstructorName);

                doc.Save(CourseXmlPath);
            }
        }

        public static void DeleteCourse(int id)
        {
            EnsureFileExists(CourseXmlPath, "Courses");
            var doc = XDocument.Load(CourseXmlPath);
            doc.Descendants("Course").Where(x => (int?)x.Element("Id") == id).Remove();
            doc.Save(CourseXmlPath);
        }
    }
}