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
using DAL_DA.Models;
using static System.Net.Mime.MediaTypeNames;
using BUS_DA;
using System.Data.Entity;
using DrawingImage = System.Drawing.Image;
namespace frm_login
{
    public partial class frm_danhsachbenhnhan : Form
    {
        private readonly benhnhanService benhnhanServices = new benhnhanService();
        public frm_danhsachbenhnhan()
        {
            InitializeComponent();
        }
        private void frm_danhsachbenhnhan_Load(object sender, EventArgs e)
        {
            Loaddata();


        }
        public void  Loaddata()
        {
            try
            {
                // Tắt tự động tạo cột
                dta_dsbenhnhan.AutoGenerateColumns = false;

                // Lấy danh sách bệnh nhân từ dịch vụ
                List<BenhNhan> benhNhans = benhnhanServices.GetAll();

                // Kiểm tra nếu danh sách rỗng hoặc null
                if (benhNhans == null || !benhNhans.Any())
                {
                    MessageBox.Show("Không có dữ liệu bệnh nhân để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Gán dữ liệu cho DataGridView
                dta_dsbenhnhan.DataSource = benhNhans;

                // Duyệt từng hàng để thiết lập dữ liệu vào các cột
                foreach (DataGridViewRow row in dta_dsbenhnhan.Rows)
                {
                    if (row.DataBoundItem is BenhNhan benhNhan)
                    {
                        // Gán mã bệnh nhân
                        if (dta_dsbenhnhan.Columns.Contains("ID"))
                            row.Cells["ID"].Value = benhNhan.MaBenhNhan;

                        // Xử lý Avatar
                        if (dta_dsbenhnhan.Columns.Contains("Avatar"))
                        {
                            row.Cells["Avatar"].Value = benhNhan.Avatar != null && benhNhan.Avatar.Length > 0
                                ? ConvertByteArrayToImage(benhNhan.Avatar)
                                : Properties.Resources.THUOC; // Ảnh mặc định
                        }

                        // Gán thông tin cơ bản
                        if (dta_dsbenhnhan.Columns.Contains("BasicInfo"))
                            row.Cells["BasicInfo"].Value = benhNhan.TenBenhNhan;

                        if (dta_dsbenhnhan.Columns.Contains("Phone"))
                            row.Cells["Phone"].Value = benhNhan.SoDienThoai;

                        if (dta_dsbenhnhan.Columns.Contains("Address"))
                            row.Cells["Address"].Value = benhNhan.DiaChi;
                    }
                }

                // Ẩn các cột không cần thiết
                if (dta_dsbenhnhan.Columns.Contains("ColumnHoaDon"))
                    dta_dsbenhnhan.Columns["ColumnHoaDon"].Visible = false;

                if (dta_dsbenhnhan.Columns.Contains("ColumnDichVu"))
                    dta_dsbenhnhan.Columns["ColumnDichVu"].Visible = false;

                // Làm mới DataGridView
                dta_dsbenhnhan.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private System.Drawing.Image ConvertByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }

        private void dta_dsbenhnhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
