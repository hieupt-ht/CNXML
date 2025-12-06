using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using QLKhoaHocONL.Models;

namespace QLKhoaHocONL.Helpers
{
    /// <summary>
    /// Truy cập dữ liệu SQL Server (Mapping: C# English -> SQL Vietnamese)
    /// </summary>
    internal static class DbHelper
    {
        private static string ConnStr => ConfigurationManager.ConnectionStrings["OnlineCourseDb"]?.ConnectionString
                                         ?? "Server=.;Database=OnlineCourseDB;Trusted_Connection=True;";

        private static SqlConnection OpenConnection()
        {
            var conn = new SqlConnection(ConnStr);
            conn.Open();
            return conn;
        }

        #region Accounts (TaiKhoan)
        public static Account Authenticate(string username, string password)
        {
            // Mapping: MaTaiKhoan, TenDangNhap, MatKhau, HoTen, VaiTro
            const string sql = @"SELECT MaTaiKhoan, TenDangNhap, MatKhau, HoTen, VaiTro
                                 FROM TaiKhoan 
                                 WHERE TenDangNhap = @u AND MatKhau = @p";
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
            const string checkSql = "SELECT 1 FROM TaiKhoan WHERE TenDangNhap = @u";
            const string insertSql = @"INSERT INTO TaiKhoan(TenDangNhap, MatKhau, HoTen, VaiTro)
                                       OUTPUT INSERTED.MaTaiKhoan
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

        #region Courses (KhoaHoc)
        public static List<Course> LoadCourses(bool onlyOwned = false, string username = null)
        {
            var list = new List<Course>();
            using var conn = OpenConnection();
            
            // Mapping: MaKhoaHoc, LinkDemo, MaGiangVien...
            string sql = @"SELECT k.MaKhoaHoc, k.TenKhoaHoc, k.GiaGoc, k.GiaGiam, k.SoHocVien, k.ThoiLuong,
                                  k.TenAnh, k.MauBatDau, k.MauKetThuc, k.LinkDemo,
                                  k.MaGiangVien, gv.HoTen AS TenGiangVien
                           FROM KhoaHoc k
                           LEFT JOIN GiangVien gv ON k.MaGiangVien = gv.MaGiangVien";

            // Nếu chỉ load khóa học đã mua (JOIN qua bang TaiKhoan_KhoaHoc va TaiKhoan)
            if (onlyOwned && !string.IsNullOrWhiteSpace(username))
            {
                sql += @" INNER JOIN TaiKhoan_KhoaHoc tkkh ON tkkh.MaKhoaHoc = k.MaKhoaHoc
                          INNER JOIN TaiKhoan tk ON tk.MaTaiKhoan = tkkh.MaTaiKhoan
                          WHERE tk.TenDangNhap = @user";
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

        public static int AddCourse(Course c)
        {
            const string sql = @"INSERT INTO KhoaHoc(TenKhoaHoc, GiaGoc, GiaGiam, SoHocVien, ThoiLuong,
                                                     TenAnh, MauBatDau, MauKetThuc, LinkDemo, MaGiangVien)
                                 OUTPUT INSERTED.MaKhoaHoc
                                 VALUES(@ten, @giaGoc, @giaGiam, @soHv, @thoiLuong, @anh, @mau1, @mau2, @demo, @instructor)";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            FillCourseParameters(cmd, c);
            return (int)cmd.ExecuteScalar();
        }

        public static void UpdateCourse(Course c)
        {
            const string sql = @"UPDATE KhoaHoc SET
                                    TenKhoaHoc = @ten,
                                    GiaGoc = @giaGoc,
                                    GiaGiam = @giaGiam,
                                    SoHocVien = @soHv,
                                    ThoiLuong = @thoiLuong,
                                    TenAnh = @anh,
                                    MauBatDau = @mau1,
                                    MauKetThuc = @mau2,
                                    LinkDemo = @demo,
                                    MaGiangVien = @instructor
                                 WHERE MaKhoaHoc = @id";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            FillCourseParameters(cmd, c);
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteCourse(int id)
        {
            using var conn = OpenConnection();
            using var cmd = new SqlCommand("DELETE FROM KhoaHoc WHERE MaKhoaHoc = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public static void ReplaceCourses(IEnumerable<Course> courses)
        {
            using var conn = OpenConnection();
            using var tran = conn.BeginTransaction();
            try
            {
                new SqlCommand("SET IDENTITY_INSERT KhoaHoc ON", conn, tran).ExecuteNonQuery();

                foreach (var c in courses)
                {
                    // Update dòng 
                    string updateSql = @"UPDATE KhoaHoc SET
                                            TenKhoaHoc=@ten, GiaGoc=@giaGoc, GiaGiam=@giaGiam,
                                            SoHocVien=@soHv, ThoiLuong=@thoiLuong, TenAnh=@anh,
                                            MauBatDau=@mau1, MauKetThuc=@mau2, LinkDemo=@demo,
                                            MaGiangVien=@instId
                                         WHERE MaKhoaHoc=@id";

                    using (var cmdUpdate = new SqlCommand(updateSql, conn, tran))
                    {
                        FillCourseParameters(cmdUpdate, c);
                        cmdUpdate.Parameters.AddWithValue("@id", c.Id);

                        int rowsAffected = cmdUpdate.ExecuteNonQuery();

                        // Nếu Update không được -> ID này chưa có trong SQL -> Thì Insert mới
                        if (rowsAffected == 0)
                        {
                            string insertSql = @"INSERT INTO KhoaHoc(MaKhoaHoc, TenKhoaHoc, GiaGoc, GiaGiam, SoHocVien, ThoiLuong,
                                                                     TenAnh, MauBatDau, MauKetThuc, LinkDemo, MaGiangVien)
                                                 VALUES(@id, @ten, @giaGoc, @giaGiam, @soHv, @thoiLuong, @anh, @mau1, @mau2, @demo, @instId)";
                            using var cmdInsert = new SqlCommand(insertSql, conn, tran);
                            FillCourseParameters(cmdInsert, c);
                            cmdInsert.Parameters.AddWithValue("@id", c.Id);
                            cmdInsert.ExecuteNonQuery();
                        }
                    }
                }

                new SqlCommand("SET IDENTITY_INSERT KhoaHoc OFF", conn, tran).ExecuteNonQuery();

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
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

            if (c.InstructorId != null && c.InstructorId > 0)
                cmd.Parameters.AddWithValue("@instId", c.InstructorId);
            else
                cmd.Parameters.AddWithValue("@instId", DBNull.Value);
        }
        #endregion

        #region Instructors (GiangVien)
        public static List<Instructor> LoadInstructors()
        {
            var list = new List<Instructor>();
            using var conn = OpenConnection();
            using var cmd = new SqlCommand("SELECT MaGiangVien, HoTen, Email, DienThoai, ChuyenMon FROM GiangVien", conn);
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
            const string sql = @"INSERT INTO GiangVien(HoTen, Email, DienThoai, ChuyenMon)
                                 OUTPUT INSERTED.MaGiangVien
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
            const string sql = @"UPDATE GiangVien SET HoTen=@name, Email=@mail, DienThoai=@phone, ChuyenMon=@exp
                                 WHERE MaGiangVien=@id";
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
            using var cmd = new SqlCommand("DELETE FROM GiangVien WHERE MaGiangVien=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public static void ReplaceInstructors(IEnumerable<Instructor> instructors)
        {
            using var conn = OpenConnection();
            using var tran = conn.BeginTransaction();
            try
            {
                // Set MaGiangVien bên bảng KhoaHoc về NULL
                // để tránh lỗi FK_KhoaHoc_GiangVien.
                new SqlCommand("UPDATE KhoaHoc SET MaGiangVien = NULL", conn, tran).ExecuteNonQuery();

                // Bây giờ mới được phép xóa Giảng viên
                new SqlCommand("DELETE FROM GiangVien", conn, tran).ExecuteNonQuery();

                // Reset ID về 0 (để khi insert bắt đầu từ 1)
                new SqlCommand("DBCC CHECKIDENT('GiangVien', RESEED, 0)", conn, tran).ExecuteNonQuery();

                // Thêm lại Giảng viên từ XML vào
                foreach (var i in instructors)
                {
                    var sql = @"INSERT INTO GiangVien(HoTen, Email, DienThoai, ChuyenMon) VALUES(@n,@e,@p,@x)";
                    using var cmd = new SqlCommand(sql, conn, tran);
                    cmd.Parameters.AddWithValue("@n", (object)i.FullName ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@e", (object)i.Email ?? DBNull.Value);

                    // Xử lý sđt null chuẩn xác
                    if (string.IsNullOrEmpty(i.Phone))
                        cmd.Parameters.AddWithValue("@p", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@p", i.Phone);

                    cmd.Parameters.AddWithValue("@x", (object)i.Expertise ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
        #endregion

        #region Students (HocVien)
        public static List<Student> LoadStudents()
        {
            var list = new List<Student>();
            using var conn = OpenConnection();

            const string sql = "SELECT MaHocVien, HoTen, Email, DienThoai, DiaChi, MaTaiKhoan FROM HocVien";
            using var cmd = new SqlCommand(sql, conn);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new Student
                {
                    StudentId = rd.GetInt32(0),
                    FullName = rd.GetString(1),
                    Email = rd.IsDBNull(2) ? null : rd.GetString(2),
                    Phone = rd.IsDBNull(3) ? null : rd.GetString(3),
                    Address = rd.IsDBNull(4) ? null : rd.GetString(4),
                    AccountId = rd.IsDBNull(5) ? (int?)null : rd.GetInt32(5)
                });
            }
            return list;
        }

        public static int AddStudent(Student s)
        {
            const string sql = @"INSERT INTO HocVien(HoTen, Email, DienThoai, DiaChi, MaTaiKhoan)
                                 OUTPUT INSERTED.MaHocVien
                                 VALUES(@name, @mail, @phone, @addr, @accId)";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", s.FullName);
            cmd.Parameters.AddWithValue("@mail", (object)s.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@phone", (object)s.Phone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@addr", (object)s.Address ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@accId", (object)s.AccountId ?? DBNull.Value);
            return (int)cmd.ExecuteScalar();
        }

        public static void UpdateStudent(Student s)
        {
            const string sql = @"UPDATE HocVien SET HoTen=@name, Email=@mail, DienThoai=@phone, DiaChi=@addr, MaTaiKhoan=@accId
                                 WHERE MaHocVien=@id";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", s.FullName);
            cmd.Parameters.AddWithValue("@mail", (object)s.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@phone", (object)s.Phone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@addr", (object)s.Address ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@accId", (object)s.AccountId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@id", s.StudentId);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteStudent(int id)
        {
            using var conn = OpenConnection();
            using var cmd = new SqlCommand("DELETE FROM HocVien WHERE MaHocVien=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public static void ReplaceStudents(IEnumerable<Student> students)
        {
            using var conn = OpenConnection();
            using var tran = conn.BeginTransaction();
            try
            {
                new SqlCommand("DELETE FROM HocVien", conn, tran).ExecuteNonQuery();
                new SqlCommand("DBCC CHECKIDENT('HocVien', RESEED, 0)", conn, tran).ExecuteNonQuery();

                foreach (var s in students)
                {
                    var sql = @"INSERT INTO HocVien(HoTen, Email, DienThoai, DiaChi) VALUES(@n,@e,@p,@a)";
                    using var cmd = new SqlCommand(sql, conn, tran);
                    cmd.Parameters.AddWithValue("@n", (object)s.FullName ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@e", (object)s.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@p", (object)s.Phone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@a", (object)s.Address ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
                tran.Commit();
            }
            catch { tran.Rollback(); throw; }
        }
        #endregion

        #region Buying Logic (TaiKhoan_KhoaHoc)
        public static bool AddUserCourse(string username, int courseId)
        {
            if (string.IsNullOrWhiteSpace(username)) return false;

            using var conn = OpenConnection();

            // Lấy MaTaiKhoan
            int? accId = null;
            using (var cmdAcc = new SqlCommand("SELECT MaTaiKhoan FROM TaiKhoan WHERE TenDangNhap=@u", conn))
            {
                cmdAcc.Parameters.AddWithValue("@u", username);
                var obj = cmdAcc.ExecuteScalar();
                if (obj != null && obj != DBNull.Value) accId = Convert.ToInt32(obj);
            }

            if (accId == null) return false;

            // Check đã mua chưa
            using (var cmdCheck = new SqlCommand("SELECT 1 FROM TaiKhoan_KhoaHoc WHERE MaTaiKhoan=@a AND MaKhoaHoc=@c", conn))
            {
                cmdCheck.Parameters.AddWithValue("@a", accId.Value);
                cmdCheck.Parameters.AddWithValue("@c", courseId);
                if (cmdCheck.ExecuteScalar() != null) return false;
            }

            // Mua (Insert)
            using (var cmdInsert = new SqlCommand("INSERT INTO TaiKhoan_KhoaHoc(MaTaiKhoan, MaKhoaHoc) VALUES(@a, @c)", conn))
            {
                cmdInsert.Parameters.AddWithValue("@a", accId.Value);
                cmdInsert.Parameters.AddWithValue("@c", courseId);
                cmdInsert.ExecuteNonQuery();
            }

            AddPurchaseNotification(conn, accId.Value, courseId, username);
            return true;
        }

        public static List<int> LoadUserCourseIds(string username)
        {
            var ids = new List<int>();
            const string sql = @"SELECT tkkh.MaKhoaHoc
                                 FROM TaiKhoan_KhoaHoc tkkh
                                 INNER JOIN TaiKhoan tk ON tkkh.MaTaiKhoan = tk.MaTaiKhoan
                                 WHERE tk.TenDangNhap = @u";
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

        public static List<CourseBuyer> LoadCourseBuyers(int courseId)
        {
            var list = new List<CourseBuyer>();
            // JOIN 3 bang: TaiKhoan_KhoaHoc -> TaiKhoan -> HocVien
            const string sql = @"SELECT tk.MaTaiKhoan, tk.TenDangNhap, tk.HoTen, 
                                        hv.Email, hv.DienThoai, tkkh.NgayMua
                                 FROM TaiKhoan_KhoaHoc tkkh
                                 INNER JOIN TaiKhoan tk ON tkkh.MaTaiKhoan = tk.MaTaiKhoan
                                 LEFT JOIN HocVien hv ON hv.MaTaiKhoan = tk.MaTaiKhoan
                                 WHERE tkkh.MaKhoaHoc = @c
                                 ORDER BY tkkh.NgayMua DESC";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@c", courseId);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new CourseBuyer
                {
                    AccountId = rd.GetInt32(0),
                    Username = rd.GetString(1),
                    FullName = rd.IsDBNull(2) ? null : rd.GetString(2),
                    Email = rd.IsDBNull(3) ? null : rd.GetString(3),
                    Phone = rd.IsDBNull(4) ? null : rd.GetString(4),
                    PurchasedAt = rd.GetDateTime(5)
                });
            }
            return list;
        }
        #endregion

        #region Notifications (ThongBao)
        public static List<NotificationItem> LoadNotifications(bool includeRead = true)
        {
            var list = new List<NotificationItem>();
            const string sql = @"SELECT MaThongBao, TieuDe, NoiDung, NgayTao, DaDoc
                                 FROM ThongBao
                                 WHERE (@all = 1 OR DaDoc = 0)
                                 ORDER BY NgayTao DESC";
            using var conn = OpenConnection();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@all", includeRead ? 1 : 0);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new NotificationItem
                {
                    Id = rd.GetInt32(0),
                    Title = rd.GetString(1),
                    Content = rd.GetString(2),
                    CreatedAt = rd.GetDateTime(3),
                    IsRead = rd.GetBoolean(4)
                });
            }
            return list;
        }

        public static int CountUnreadNotifications()
        {
            using var conn = OpenConnection();
            using var cmd = new SqlCommand("SELECT COUNT(*) FROM ThongBao WHERE DaDoc = 0", conn);
            return Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
        }

        public static void MarkNotificationsAsRead(IEnumerable<int> ids)
        {
            if (ids == null) return;
            var list = new List<int>(ids);
            if (list.Count == 0) return;

            using var conn = OpenConnection();
            var paramNames = new List<string>();
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            for (int i = 0; i < list.Count; i++)
            {
                var pName = "@id" + i;
                paramNames.Add(pName);
                cmd.Parameters.AddWithValue(pName, list[i]);
            }

            cmd.CommandText = $"UPDATE ThongBao SET DaDoc = 1 WHERE MaThongBao IN ({string.Join(",", paramNames)})";
            cmd.ExecuteNonQuery();
        }

        public static void MarkAllNotificationsAsRead()
        {
            using var conn = OpenConnection();
            using var cmd = new SqlCommand("UPDATE ThongBao SET DaDoc = 1 WHERE DaDoc = 0", conn);
            cmd.ExecuteNonQuery();
        }

        private static void AddPurchaseNotification(SqlConnection conn, int accountId, int courseId, string username)
        {
            string courseName = null;
            // Lay TenKhoaHoc
            using (var cmdCourse = new SqlCommand("SELECT TenKhoaHoc FROM KhoaHoc WHERE MaKhoaHoc = @id", conn))
            {
                cmdCourse.Parameters.AddWithValue("@id", courseId);
                var obj = cmdCourse.ExecuteScalar();
                if (obj != null && obj != DBNull.Value) courseName = Convert.ToString(obj);
            }

            string fullName = null;
            // Lay HoTen TaiKhoan
            using (var cmdAcc = new SqlCommand("SELECT HoTen FROM TaiKhoan WHERE MaTaiKhoan = @id", conn))
            {
                cmdAcc.Parameters.AddWithValue("@id", accountId);
                var obj = cmdAcc.ExecuteScalar();
                if (obj != null && obj != DBNull.Value) fullName = Convert.ToString(obj);
            }

            string displayName = string.IsNullOrWhiteSpace(fullName) ? username : fullName;
            string title = "Học viên mua khóa học";
            string content = $"{displayName} đã mua khóa {(courseName ?? courseId.ToString())}";

            using var cmd = new SqlCommand(
                "INSERT INTO ThongBao(TieuDe, NoiDung, MaKhoaHoc, MaTaiKhoan) VALUES(@t, @ct, @courseId, @accId)", conn);
            cmd.Parameters.AddWithValue("@t", title);
            cmd.Parameters.AddWithValue("@ct", content);
            cmd.Parameters.AddWithValue("@courseId", courseId);
            cmd.Parameters.AddWithValue("@accId", accountId);
            cmd.ExecuteNonQuery();
        }
        #endregion

        #region Videos (VideoBaiGiang)
        public static List<Video> LoadVideos(int courseId)
        {
            var list = new List<Video>();
            // Mapping: MaVideo, MaKhoaHoc, TieuDe, Link, ThuTu
            const string sql = @"SELECT MaVideo, MaKhoaHoc, TieuDe, Link, ThuTu
                                 FROM VideoBaiGiang 
                                 WHERE MaKhoaHoc = @c 
                                 ORDER BY ThuTu";
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