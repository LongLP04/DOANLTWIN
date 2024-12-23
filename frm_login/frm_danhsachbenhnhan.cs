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
using static System.Net.Mime.MediaTypeNames;

namespace frm_login
{
    public partial class frm_danhsachbenhnhan : Form
    {
        public frm_danhsachbenhnhan()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();
        private void frm_danhsachbenhnhan_Load(object sender, EventArgs e)
        {

            string filePath = "D:\\VISUAL STUDIO\\HocWindowsForm\\PICTURE\\bacsix.png";

            dta_dsbenhnhan.AutoGenerateColumns = false;
            var listBenhNhan = db.BenhNhans
                .Select(bn => new
                {
                    Avatar = bn.Avatar,
                    BasicInfo = bn.TenBenhNhan,
                    PhoneNumber = bn.SoDienThoai,
                    Address = bn.DiaChi,
                    nextAppointment = bn.LichHens.OrderBy(lh => lh.NgayHenTT).Select(lh => lh.NgayHenTT).FirstOrDefault(), // Lấy lịch hẹn gần nhất
                    lastAppointment = bn.LichHens.OrderByDescending(lh => lh.NgayHenGN).Select(lh => lh.NgayHenGN).FirstOrDefault(),
                    
                    Service = db.DichVus
                        .Where(dv => dv.MaDichVu == bn.HoaDons.Select(hd => hd.MaDichVu).FirstOrDefault())
                        .Select(dv => dv.TenDichVu)
                        .FirstOrDefault()
                })
                .ToList();

            dta_dsbenhnhan.DataSource = listBenhNhan;
            dta_dsbenhnhan.Columns["Column3"].DataPropertyName = "BasicInfo";
            dta_dsbenhnhan.Columns["Column4"].DataPropertyName = "PhoneNumber";
            dta_dsbenhnhan.Columns["Column5"].DataPropertyName = "Address";
            dta_dsbenhnhan.Columns["Column6"].DataPropertyName = "nextAppointment";
            dta_dsbenhnhan.Columns["Column7"].DataPropertyName = "lastAppointment";
            dta_dsbenhnhan.Columns["Column8"].DataPropertyName = "Service";
            dta_dsbenhnhan.Columns["Column2"].DataPropertyName = "Avatar";

            dta_dsbenhnhan.Columns["Column1"].Width = 10;
            dta_dsbenhnhan.Columns["Column2"].Width = 60;
            dta_dsbenhnhan.Columns["Column3"].Width = 120;
            dta_dsbenhnhan.Columns["Column4"].Width = 100;
            dta_dsbenhnhan.Columns["Column5"].Width = 180;
            dta_dsbenhnhan.Columns["Column6"].Width = 140;
            dta_dsbenhnhan.Columns["Column7"].Width = 140;
            dta_dsbenhnhan.Columns["Column8"].Width = 100;
        }



        private void dta_dsbenhnhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
