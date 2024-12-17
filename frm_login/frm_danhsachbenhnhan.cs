using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_login
{
    public partial class frm_danhsachbenhnhan : Form
    {
        public frm_danhsachbenhnhan()
        {
            InitializeComponent();
        }

        private void frm_danhsachbenhnhan_Load(object sender, EventArgs e)
        {

            string filePath = "D:\\VISUAL STUDIO\\HocWindowsForm\\PICTURE\\bacsix.png";

            // Kiểm tra và thêm cột nếu cần
            if (dta_dsbenhnhan.Columns.Count < 8)
            {
                dta_dsbenhnhan.Columns.Clear();
                dta_dsbenhnhan.Columns.Add("STT", "STT");
                dta_dsbenhnhan.Columns.Add(new DataGridViewImageColumn() { HeaderText = "Hình Ảnh", Name = "imgColumn", ImageLayout = DataGridViewImageCellLayout.Zoom });
                dta_dsbenhnhan.Columns.Add("HoTen", "Họ Tên");
                dta_dsbenhnhan.Columns.Add("SDT", "Số Điện Thoại");
                dta_dsbenhnhan.Columns.Add("DiaChi", "Địa Chỉ");
                dta_dsbenhnhan.Columns.Add("NgayKham", "Ngày Khám");
                dta_dsbenhnhan.Columns.Add("NgayTaiKham", "Ngày Tái Khám");
                dta_dsbenhnhan.Columns.Add("DichVu", "Dịch Vụ");
            }

            for (int i = 0; i < 10; i++)
            {
                dta_dsbenhnhan.Rows.Add();

                if (File.Exists(filePath))
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        dta_dsbenhnhan.Rows[i].Cells[1].Value = Image.FromStream(fs);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tệp hình ảnh tại đường dẫn: " + filePath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dta_dsbenhnhan.Rows[i].Cells[1].Value = null;
                }

                dta_dsbenhnhan.Rows[i].Cells[2].Value = "Anh Đức";
                dta_dsbenhnhan.Rows[i].Cells[3].Value = "0339632131";
                dta_dsbenhnhan.Rows[i].Cells[4].Value = "BR-VT";
                dta_dsbenhnhan.Rows[i].Cells[5].Value = "21-10-2024";
                dta_dsbenhnhan.Rows[i].Cells[6].Value = "21-10-2023";
                dta_dsbenhnhan.Rows[i].Cells[7].Value = "Lấy tủy";
            }
        }

        private void dta_dsbenhnhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
