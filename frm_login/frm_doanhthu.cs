using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_login
{
    public partial class frm_doanhthu : Form
    {
        public frm_doanhthu()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel26_Click(object sender, EventArgs e)
        {

        }
        Model1 db = new Model1();
        private void frm_doanhthu_Load(object sender, EventArgs e)
        {
            dta_doanhthu.AutoGenerateColumns = false;


            // Thêm dữ liệu mẫu

            //var doanhThuList = db.HoaDons
            //     .Join(db.DoanhThus,
            //           hd => hd.MaDichVu,       // Join HoaDon.MaDichVu với DoanhThu.MaDoanhThu
            //           dt => dt.MaDoanhThu,
            //           (hd, dt) => new {
            //               LoaiDichVu = dt.TenDichVu,
            //               Ngay = db.LichHens
            //                          .Where(lh => lh.MaBenhNhan == hd.MaBenhNhan)  // Lọc LichHen theo MaBenhNhan
            //                          .Select(lh => lh.NgayHenGN)
            //                          .FirstOrDefault(),  // Lấy NgayHenGN đầu tiên tương ứng
            //               Gia = dt.Gia
            //           })
            //     .ToList();
            var doanhThuList = db.DoanhThus
                .Select(dt => new
                {
                    Type = dt.TenDichVu,
                    Date = dt.NgayHoaDon,
                    Price = dt.Gia
                })
                .ToList();


            // Gán dữ liệu vào DataGridView
            dta_doanhthu.DataSource = doanhThuList;
            dta_doanhthu.Columns["Column1"].DataPropertyName = "Type";
            dta_doanhthu.Columns["Column2"].DataPropertyName = "Date";
            dta_doanhthu.Columns["Column3"].DataPropertyName = "Price";


        }
    }
}
