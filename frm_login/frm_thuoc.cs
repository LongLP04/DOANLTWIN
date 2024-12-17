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

        private void frm_thuoc_Load(object sender, EventArgs e)
        {
            string filePath = "D:\\VISUAL STUDIO\\QLPKDa\\PICTURE\\THUOC.png";

            // Kiểm tra và thêm cột nếu cần
            if (dta_thuoc.Columns.Count < 6)
            {
                dta_thuoc.Columns.Clear();
                dta_thuoc.Columns.Add("STT", "STT");
                dta_thuoc.Columns.Add(new DataGridViewImageColumn() { HeaderText = "Hình Ảnh", Name = "imgColumn", ImageLayout = DataGridViewImageCellLayout.Zoom });
                dta_thuoc.Columns.Add("BasicInfo", "Basic Info");
                dta_thuoc.Columns.Add("Appointment", "Appointment");
                dta_thuoc.Columns.Add("Service", "Service");
                dta_thuoc.Columns.Add("Medicine", "Medicine");
                dta_thuoc.Columns.Add("Price", "Price");
            }

            // Thêm dữ liệu mẫu
            for (int i = 0; i < 10; i++)
            {
                dta_thuoc.Rows.Add();

                // Nạp hình ảnh từ tệp
                if (File.Exists(filePath))
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        dta_thuoc.Rows[i].Cells[1].Value = Image.FromStream(fs);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tệp hình ảnh tại đường dẫn: " + filePath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dta_thuoc.Rows[i].Cells[1].Value = null;
                }

                // Thêm các giá trị vào các cột khác
                dta_thuoc.Rows[i].Cells[0].Value = (i + 1).ToString(); // STT
                dta_thuoc.Rows[i].Cells[2].Value = "John Doe"; // Basic Info
                dta_thuoc.Rows[i].Cells[3].Value = "22-12-2024"; // Appointment
                dta_thuoc.Rows[i].Cells[4].Value = "Consultation"; // Service
                dta_thuoc.Rows[i].Cells[5].Value = "Paracetamol"; // Medicine
                dta_thuoc.Rows[i].Cells[6].Value = "$15"; // Price
            }
        }
    }
}
