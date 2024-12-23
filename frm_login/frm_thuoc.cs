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
    public partial class frm_thuoc : Form
    {
        public frm_thuoc()
        {
            InitializeComponent();
        }

        private void dta_thuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Model1 db = new Model1();

        private void frm_thuoc_Load(object sender, EventArgs e)
        {
            string filePath = "D:\\VISUAL STUDIO\\QLPKDa\\PICTURE\\THUOC.png";

            dta_thuoc.AutoGenerateColumns = false;

            var listThuoc = db.Thuoc_
                .Join(db.ToaThuocs, thuoc => thuoc.MaToa, toa => toa.MaToa, (thuoc, toa) => new { thuoc, toa })
                .Join(db.HoaDons, combined => combined.toa.MaHoaDon, hoaDon => hoaDon.MaHoaDon, (combined, hoaDon) => new { combined, hoaDon })
                .Join(db.BenhNhans, combinedHoaDon => combinedHoaDon.hoaDon.MaBenhNhan, benhNhan => benhNhan.MaBenhNhan, (combinedHoaDon, benhNhan) => new
                {
                    TenThuoc = combinedHoaDon.combined.thuoc.TenThuoc,
                    Gia = combinedHoaDon.combined.thuoc.Gia,
                    LieuLuon = combinedHoaDon.combined.toa.LieuLuon,
                    SoLuong = combinedHoaDon.combined.toa.SoLuong,
                    Ghichu = combinedHoaDon.hoaDon.GhiChu,
                    TenBenhNhan = benhNhan.TenBenhNhan,
                    Avatar = benhNhan.Avatar,
                    LichHen = benhNhan.LichHens
                        .Select(lh => lh.NgayHenTT)
                        .FirstOrDefault(),
                    DichVu = db.DichVus
            .Where(dv => dv.MaDichVu == combinedHoaDon.hoaDon.MaDichVu)
            .Select(dv => dv.TenDichVu)
            .FirstOrDefault()
                })
                .ToList();


            // Gán danh sách dữ liệu vào DataGridView
            dta_thuoc.DataSource = listThuoc;

            // Gán dữ liệu cho từng cột hiện có
            dta_thuoc.Columns["Column3"].DataPropertyName = "TenBenhNhan";
            dta_thuoc.Columns["Column4"].DataPropertyName = "LichHen";
            dta_thuoc.Columns["Column5"].DataPropertyName = "DichVu";
            dta_thuoc.Columns["Column6"].DataPropertyName = "TenThuoc";
            dta_thuoc.Columns["Column7"].DataPropertyName = "Gia";
            dta_thuoc.Columns["Column8"].DataPropertyName = "Ghichu";
            dta_thuoc.Columns["Column2"].DataPropertyName = "Avatar";

            dta_thuoc.Columns["Column1"].Width = 10;
            dta_thuoc.Columns["Column2"].Width = 50;  
            dta_thuoc.Columns["Column3"].Width = 100;  
            dta_thuoc.Columns["Column4"].Width = 160;  
            dta_thuoc.Columns["Column5"].Width = 80; 
            dta_thuoc.Columns["Column6"].Width = 90;  
            dta_thuoc.Columns["Column7"].Width = 80;
            dta_thuoc.Columns["Column8"].Width = 220;



        }
    }
}
