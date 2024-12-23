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
    public partial class frm_lichhen : Form
    {
        public frm_lichhen()
        {
            InitializeComponent();
        }

        private void dta_lichhen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Model1 db = new Model1();
        private void frm_lichhen_Load(object sender, EventArgs e)
        {
            string filePath = "D:\\VISUAL STUDIO\\QLPKDa\\PICTURE\\THUOC.png";
            // Gán dữ liệu vào DataGridView mà không thêm cột
            dta_lichhen.AutoGenerateColumns = false;

            // Tạo danh sách dữ liệu
            var listLichHen = db.LichHens
                .AsEnumerable()
                .Select(lh => new
                {
                    Avatar = lh.BenhNhan.Avatar != null ? (Image)(new ImageConverter().ConvertFrom(lh.BenhNhan.Avatar)) : null,
                    BasicInfo = lh.BenhNhan.TenBenhNhan,
                    Time = lh.NgayHenTT,
                    Date = lh.NgayHenGN,
                    Service = db.DichVus
                        .Where(dv => dv.MaDichVu == lh.MaDichVu)
                        .Select(dv => dv.TenDichVu)
                        .FirstOrDefault(),

                    Note = lh.Ghichu
                })
                .ToList();

            // Gán danh sách dữ liệu vào DataGridView
            dta_lichhen.DataSource = listLichHen;

            // Gán dữ liệu cho từng cột hiện có
            dta_lichhen.Columns["Column3"].DataPropertyName = "BasicInfo";
            dta_lichhen.Columns["Column4"].DataPropertyName = "Time";
            dta_lichhen.Columns["Column5"].DataPropertyName = "Date";
            dta_lichhen.Columns["Column6"].DataPropertyName = "Service";
            dta_lichhen.Columns["Column7"].DataPropertyName = "Note";
            dta_lichhen.Columns["Column2"].DataPropertyName = "Avatar";

            dta_lichhen.Columns["Column1"].Width = 10;
            dta_lichhen.Columns["Column2"].Width = 50;  // Cột Avatar có độ rộng 100
            dta_lichhen.Columns["Column3"].Width = 150;  // Cột BasicInfo có độ rộng 150
            dta_lichhen.Columns["Column4"].Width = 160;  // Cột Time có độ rộng 120
            dta_lichhen.Columns["Column5"].Width = 160;  // Cột Date có độ rộng 120
            dta_lichhen.Columns["Column6"].Width = 90;  // Cột Service có độ rộng 150
            dta_lichhen.Columns["Column7"].Width = 200;
        }
    }
}
