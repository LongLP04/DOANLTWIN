    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using DAL_DA.Models;

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
            private void frm_lichhen_Load(object sender, EventArgs e)
            {
              LoadData();

            }
        private void LoadData()
        {
            // Xóa phần try-catch nếu bạn không gặp lỗi khi tải dữ liệu
            using (var db = new Model1())
            {
                dta_lichhen.AutoGenerateColumns = false;

                // Truy vấn dữ liệu từ cơ sở dữ liệu
                var data = (from lh in db.LichHens
                            join bn in db.BenhNhans on lh.MaBenhNhan equals bn.MaBenhNhan
                            join hd in db.HoaDons on lh.MaBenhNhan equals hd.MaBenhNhan into hdJoin
                            from hd in hdJoin.DefaultIfEmpty()
                            join dv in db.DichVus on hd.MaDichVu equals dv.MaDichVu into dvJoin
                            from dv in dvJoin.DefaultIfEmpty()
                            select new
                            {
                                lh.MaLichHen,
                                Avatar = bn.Avatar,  // Đảm bảo Avatar có dữ liệu
                                TenBenhNhan = bn.TenBenhNhan,
                                NgayHenTT = lh.NgayHenTT,
                                NgayHenGN = lh.NgayHenGN,
                                TenDichVu = dv != null ? dv.TenDichVu : "Không có dịch vụ",
                                lh.Ghichu
                            }).ToList();

                // Gán dữ liệu vào DataGridView
                dta_lichhen.DataSource = data;

                // Sau khi gán dữ liệu vào DataGridView, xử lý hình ảnh
                ProcessAvatarImages();
            }
        }
        private void ProcessAvatarImages()
        {
            // Xử lý hiển thị hình ảnh cho mỗi dòng
            foreach (DataGridViewRow row in dta_lichhen.Rows)
            {
                if (row.Cells[1] != null && row.Cells[1].Value != null)
                {
                    byte[] imageBytes = row.Cells[1].Value as byte[];

                    // Kiểm tra nếu byte[] hợp lệ
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                // Kiểm tra nếu byte[] có phải là hình ảnh hợp lệ
                                Image img = Image.FromStream(ms);
                                row.Cells[1].Value = img;
                            }
                        }
                        catch (Exception ex)
                        {
                            // Nếu có lỗi khi chuyển đổi byte[] thành hình ảnh
                            MessageBox.Show($"Lỗi khi xử lý hình ảnh cho MaLichHen {row.Cells["MaLichHen"].Value}: {ex.Message}",
                                "Lỗi Hình Ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Gán hình ảnh mặc định nếu có lỗi
                            row.Cells[1].Value = Properties.Resources.THUOC; // Hình ảnh mặc định
                        }
                    }
                    else
                    {

                        row.Cells[1].Value = Properties.Resources.THUOC; // Hình ảnh mặc định
                    }
                }
            }
        }



        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
            {

            }


        }
    }
