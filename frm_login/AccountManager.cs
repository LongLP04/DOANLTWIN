using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace frm_login
{
    internal class AccountManager
    {
        // Đường dẫn đến tệp account.txt trên ổ D
        private static string filePath = @"D:\VISUAL STUDIO\HocWindowsForm\account.txt";

        public AccountManager()
        {
            // Tạo tài khoản mặc định trong constructor của lớp AccountManager
            CreateAccount("anhduc123", "123456", filePath);
        }

        // Hàm mã hóa mật khẩu
        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Chuyển mật khẩu thành byte array và mã hóa
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Chuyển kết quả thành chuỗi hex
                StringBuilder builder = new StringBuilder();
                foreach (byte byteValue in bytes)
                {
                    builder.Append(byteValue.ToString("x2"));
                }

                return builder.ToString();
            }
        }


        public static bool CreateAccount(string username, string password, string filePath = @"D:\VISUAL STUDIO\HocWindowsForm\account.txt")
        {
            // Mã hóa mật khẩu
            string hashedPassword = HashPassword(password);

            string accountInfo = username + ":" + hashedPassword;

            try
            {
                // Kiểm tra nếu tệp đã tồn tại, nếu chưa thì tạo mới
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                }

                // Ghi thông tin tài khoản vào tệp
                File.AppendAllText(filePath, accountInfo + Environment.NewLine);
                Console.WriteLine("Tài khoản đã được tạo và lưu vào file.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi khi lưu tài khoản: " + ex.Message);
                return false;
            }
        }
        public static bool AuthenticateUser(string username, string password, string filePath = @"D:\VISUAL STUDIO\HocWindowsForm\account.txt")
        {
            // Đọc tất cả các dòng từ tệp
            string[] accounts = File.ReadAllLines(filePath);

            foreach (var account in accounts)
            {
                string[] accountDetails = account.Split(':');
                string storedUsername = accountDetails[0];
                string storedHashedPassword = accountDetails[1];

                // Kiểm tra tài khoản và mật khẩu đã mã hóa
                if (storedUsername == username && storedHashedPassword == HashPassword(password))
                {
                    return true;  // Đăng nhập thành công
                }
            }

            return false;  // Đăng nhập thất bại
        }

    }
}
