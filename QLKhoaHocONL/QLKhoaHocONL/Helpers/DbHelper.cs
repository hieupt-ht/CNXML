using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL.Helpers
{
    /// <summary>
    /// Truy cập dữ liệu SQL Server cho tài khoản, khóa học, giảng viên, học viên.
    /// </summary>
    internal static class DbHelper
    {
        private static string ConnStr => ConfigurationManager.ConnectionStrings["OnlineCourseDb"]?.ConnectionString
                                         ?? "Server=(localdb)\\MSSQLLocalDB;Database=OnlineCourseDB;Trusted_Connection=True;";

        private static SqlConnection OpenConnection()
        {
            var conn = new SqlConnection(ConnStr);
            conn.Open();
            return conn;
        }

        #region Accounts
        public static Account Authenticate(string username, string password)
        {
            const string sql = @"SELECT AccountId, Username, Password, FullName, Role
                                 FROM Account WHERE Username = @u AND Password = @p";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", password);
            using var rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                return new Account
                {
                    AccountId = rd.GetInt32(0),
                    Username = rd.GetString(1),
                    Password = rd.GetString(2),
                    FullName = rd.IsDBNull(3) ? null : rd.GetString(3),
                    Role = rd.GetString(4)
                };
            }
            return null;
        }

        public static bool AddAccount(Account account, out string error)
        {
            error = string.Empty;
            const string checkSql = "SELECT 1 FROM Account WHERE Username = @u";
            const string insertSql = @"INSERT INTO Account(Username, Password, FullName, Role)
                                       OUTPUT INSERTED.AccountId
                                       VALUES(@u, @p, @f, @r)";
            using var conn = OpenConnection();
            using (var checkCmd = new SqlCommand(checkSql, conn))
            {
                checkCmd.Parameters.AddWithValue("@u", account.Username);
                var exists = checkCmd.ExecuteScalar() != null;
                if (exists)
                {
                    error = "Tài khoản đã tồn tại.";
                    return false;
                }
            }

            using var cmd = new SqlCommand(insertSql, conn);
            cmd.Parameters.AddWithValue("@u", account.Username);
            cmd.Parameters.AddWithValue("@p", account.Password);
            cmd.Parameters.AddWithValue("@f", (object)account.FullName ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@r", account.Role ?? "User");

            account.AccountId = (int)cmd.ExecuteScalar();
            return true;
        }
        #endregion

        #region Courses
        public static List<Course> LoadCourses(bool onlyOwned = false, string username = null)
        {
            var list = new List<Course>();
            using var conn = OpenConnection();
            string sql = @"SELECT c.CourseId, c.TenKhoaHoc, c.GiaGoc, c.GiaGiam, c.SoHocVien, c.ThoiLuong,
                                  c.TenAnh, c.MauBatDau, c.MauKetThuc, c.DemoLink,
                                  c.InstructorId, i.FullName AS InstructorName
                           FROM Course c
                           LEFT JOIN Instructor i ON c.InstructorId = i.InstructorId";

            if (onlyOwned && !string.IsNullOrWhiteSpace(username))
            {
                sql += " INNER JOIN Account a ON a.Username = @user INNER JOIN AccountCourse ac ON ac.AccountId = a.AccountId AND ac.CourseId = c.CourseId";
            }

            using var cmd = new SqlCommand(sql, conn);
            if (onlyOwned && !string.IsNullOrWhiteSpace(username))
            {
                cmd.Parameters.AddWithValue("@user", username);
            }

            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new Course
                {
                    Id = rd.GetInt32(0),
                    TenKhoaHoc = rd.GetString(1),
                    GiaGoc = rd.IsDBNull(2) ? null : rd.GetString(2),
                    GiaGiam = rd.IsDBNull(3) ? null : rd.GetString(3),
                    SoHocVien = rd.GetInt32(4),
                    ThoiLuong = rd.IsDBNull(5) ? null : rd.GetString(5),
                    TenAnh = rd.IsDBNull(6) ? null : rd.GetString(6),
                    MauBatDau = rd.IsDBNull(7) ? null : rd.GetString(7),
                    MauKetThuc = rd.IsDBNull(8) ? null : rd.GetString(8),
                    DemoLink = rd.IsDBNull(9) ? null : rd.GetString(9),
                    InstructorId = rd.IsDBNull(10) ? (int?)null : rd.GetInt32(10),
                    InstructorName = rd.IsDBNull(11) ? null : rd.GetString(11)
                });
            }
            return list;
        }

        public static Course GetCourse(int id)
        {
            const string sql = @"SELECT c.CourseId, c.TenKhoaHoc, c.GiaGoc, c.GiaGiam, c.SoHocVien, c.ThoiLuong,
                                        c.TenAnh, c.MauBatDau, c.MauKetThuc, c.DemoLink,
                                        c.InstructorId, i.FullName AS InstructorName
                                 FROM Course c
                                 LEFT JOIN Instructor i ON c.InstructorId = i.InstructorId
                                 WHERE c.CourseId = @id";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                return new Course
                {
                    Id = rd.GetInt32(0),
                    TenKhoaHoc = rd.GetString(1),
                    GiaGoc = rd.IsDBNull(2) ? null : rd.GetString(2),
                    GiaGiam = rd.IsDBNull(3) ? null : rd.GetString(3),
                    SoHocVien = rd.GetInt32(4),
                    ThoiLuong = rd.IsDBNull(5) ? null : rd.GetString(5),
                    TenAnh = rd.IsDBNull(6) ? null : rd.GetString(6),
                    MauBatDau = rd.IsDBNull(7) ? null : rd.GetString(7),
                    MauKetThuc = rd.IsDBNull(8) ? null : rd.GetString(8),
                    DemoLink = rd.IsDBNull(9) ? null : rd.GetString(9),
                    InstructorId = rd.IsDBNull(10) ? (int?)null : rd.GetInt32(10),
                    InstructorName = rd.IsDBNull(11) ? null : rd.GetString(11)
                };
            }
            return null;
        }

        public static int AddCourse(Course c)
        {
            const string sql = @"INSERT INTO Course(TenKhoaHoc, GiaGoc, GiaGiam, SoHocVien, ThoiLuong,
                                                   TenAnh, MauBatDau, MauKetThuc, DemoLink, InstructorId)
                                 OUTPUT INSERTED.CourseId
                                 VALUES(@ten, @giaGoc, @giaGiam, @soHv, @thoiLuong, @anh, @mau1, @mau2, @demo, @instructor)";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            FillCourseParameters(cmd, c);
            return (int)cmd.ExecuteScalar();
        }

        public static void UpdateCourse(Course c)
        {
            const string sql = @"UPDATE Course SET
                                    TenKhoaHoc = @ten,
                                    GiaGoc = @giaGoc,
                                    GiaGiam = @giaGiam,
                                    SoHocVien = @soHv,
                                    ThoiLuong = @thoiLuong,
                                    TenAnh = @anh,
                                    MauBatDau = @mau1,
                                    MauKetThuc = @mau2,
                                    DemoLink = @demo,
                                    InstructorId = @instructor
                                 WHERE CourseId = @id";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            FillCourseParameters(cmd, c);
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteCourse(int id)
        {
            using var conn = OpenConnection();
            using var cmd = new SqlCommand("DELETE FROM Course WHERE CourseId = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        private static void FillCourseParameters(SqlCommand cmd, Course c)
        {
            cmd.Parameters.AddWithValue("@ten", c.TenKhoaHoc);
            cmd.Parameters.AddWithValue("@giaGoc", (object)c.GiaGoc ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@giaGiam", (object)c.GiaGiam ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@soHv", c.SoHocVien);
            cmd.Parameters.AddWithValue("@thoiLuong", (object)c.ThoiLuong ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@anh", (object)c.TenAnh ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@mau1", (object)c.MauBatDau ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@mau2", (object)c.MauKetThuc ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@demo", (object)c.DemoLink ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@instructor", (object)c.InstructorId ?? DBNull.Value);
        }
        #endregion

        #region Instructors
        public static List<Instructor> LoadInstructors()
        {
            var list = new List<Instructor>();
            using var conn = OpenConnection();
            using var cmd = new SqlCommand("SELECT InstructorId, FullName, Email, Phone, Expertise FROM Instructor", conn);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new Instructor
                {
                    InstructorId = rd.GetInt32(0),
                    FullName = rd.GetString(1),
                    Email = rd.IsDBNull(2) ? null : rd.GetString(2),
                    Phone = rd.IsDBNull(3) ? null : rd.GetString(3),
                    Expertise = rd.IsDBNull(4) ? null : rd.GetString(4)
                });
            }
            return list;
        }

        public static int AddInstructor(Instructor i)
        {
            const string sql = @"INSERT INTO Instructor(FullName, Email, Phone, Expertise)
                                 OUTPUT INSERTED.InstructorId
                                 VALUES(@name, @mail, @phone, @exp)";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", i.FullName);
            cmd.Parameters.AddWithValue("@mail", (object)i.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@phone", (object)i.Phone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@exp", (object)i.Expertise ?? DBNull.Value);
            return (int)cmd.ExecuteScalar();
        }

        public static void UpdateInstructor(Instructor i)
        {
            const string sql = @"UPDATE Instructor SET FullName=@name, Email=@mail, Phone=@phone, Expertise=@exp
                                 WHERE InstructorId=@id";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", i.FullName);
            cmd.Parameters.AddWithValue("@mail", (object)i.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@phone", (object)i.Phone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@exp", (object)i.Expertise ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@id", i.InstructorId);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteInstructor(int id)
        {
            using var conn = OpenConnection();
            using var cmd = new SqlCommand("DELETE FROM Instructor WHERE InstructorId=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        #endregion

        #region Students & Ownership
        public static List<Student> LoadStudents()
        {
            var list = new List<Student>();
            using var conn = OpenConnection();
            using var cmd = new SqlCommand("SELECT StudentId, FullName, Email, Phone, Address FROM Student", conn);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new Student
                {
                    StudentId = rd.GetInt32(0),
                    FullName = rd.GetString(1),
                    Email = rd.IsDBNull(2) ? null : rd.GetString(2),
                    Phone = rd.IsDBNull(3) ? null : rd.GetString(3),
                    Address = rd.IsDBNull(4) ? null : rd.GetString(4)
                });
            }
            return list;
        }

        public static int AddStudent(Student s)
        {
            const string sql = @"INSERT INTO Student(FullName, Email, Phone, Address)
                                 OUTPUT INSERTED.StudentId
                                 VALUES(@name, @mail, @phone, @addr)";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", s.FullName);
            cmd.Parameters.AddWithValue("@mail", (object)s.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@phone", (object)s.Phone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@addr", (object)s.Address ?? DBNull.Value);
            return (int)cmd.ExecuteScalar();
        }

        public static void UpdateStudent(Student s)
        {
            const string sql = @"UPDATE Student SET FullName=@name, Email=@mail, Phone=@phone, Address=@addr
                                 WHERE StudentId=@id";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", s.FullName);
            cmd.Parameters.AddWithValue("@mail", (object)s.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@phone", (object)s.Phone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@addr", (object)s.Address ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@id", s.StudentId);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteStudent(int id)
        {
            using var conn = OpenConnection();
            using var cmd = new SqlCommand("DELETE FROM Student WHERE StudentId=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public static void AddUserCourse(string username, int courseId)
        {
            const string sql = @"DECLARE @accId INT = (SELECT AccountId FROM Account WHERE Username=@u);
                                 IF @accId IS NULL RETURN;
                                 IF NOT EXISTS(SELECT 1 FROM AccountCourse WHERE AccountId=@accId AND CourseId=@c)
                                 BEGIN
                                     INSERT INTO AccountCourse(AccountId, CourseId) VALUES(@accId, @c);
                                 END";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@c", courseId);
            cmd.ExecuteNonQuery();
        }

        public static List<int> LoadUserCourseIds(string username)
        {
            var ids = new List<int>();
            const string sql = @"SELECT ac.CourseId
                                 FROM AccountCourse ac
                                 INNER JOIN Account a ON ac.AccountId = a.AccountId
                                 WHERE a.Username = @u";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@u", username);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ids.Add(rd.GetInt32(0));
            }
            return ids;
        }
        #endregion

        #region Videos
        public static List<Video> LoadVideos(int courseId)
        {
            var list = new List<Video>();
            const string sql = @"SELECT VideoId, CourseId, Title, Url, [Order]
                                 FROM Video WHERE CourseId = @c ORDER BY [Order]";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@c", courseId);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new Video
                {
                    CourseId = rd.GetInt32(1),
                    Title = rd.GetString(2),
                    Url = rd.GetString(3),
                    Order = rd.GetInt32(4)
                });
            }
            return list;
        }
        #endregion
    }
}
