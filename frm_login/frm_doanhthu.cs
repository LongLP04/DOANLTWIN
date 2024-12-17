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

        private void frm_doanhthu_Load(object sender, EventArgs e)
        {
            // Kiểm tra và thêm cột nếu cần
            if (dta_doanhthu.Columns.Count < 3)
            {
                dta_doanhthu.Columns.Clear();
                dta_doanhthu.Columns.Add("Type", "Type");
                dta_doanhthu.Columns.Add("Date", "Date");
                dta_doanhthu.Columns.Add("Price", "Price");
            }

            // Thêm dữ liệu mẫu
            for (int i = 0; i < 10; i++)
            {
                dta_doanhthu.Rows.Add();
                dta_doanhthu.Rows[i].Cells[0].Value = "Service " + (i + 1); // Type
                dta_doanhthu.Rows[i].Cells[1].Value = DateTime.Now.AddDays(-i).ToString("dd-MM-yyyy"); // Date
                dta_doanhthu.Rows[i].Cells[2].Value = (1000 + i * 500).ToString("C2"); // Price
            }
        }
    }
}
