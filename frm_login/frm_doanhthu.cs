using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_DA;
using DAL_DA.Models;

namespace frm_login
{
    public partial class frm_doanhthu : Form
    {
        public frm_doanhthu()
        {
            InitializeComponent();
        }

        private readonly doanhthuService doanhThuServices = new doanhthuService();
        private void guna2HtmlLabel26_Click(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            try
            {
                // Giả sử bạn có dịch vụ hoặc lớp để lấy dữ liệu doanh thu
                List<DoanhThu> doanhThuList = doanhThuServices.GetAll();

                if (doanhThuList == null || !doanhThuList.Any())
                {
                    MessageBox.Show("Không có dữ liệu doanh thu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dta_doanhthu.AutoGenerateColumns = false; // Tắt tự động tạo cột
                dta_doanhthu.DataSource = doanhThuList;

                dta_doanhthu.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frm_doanhthu_Load(object sender, EventArgs e)
        {
            LoadData();

        }
    }
}
