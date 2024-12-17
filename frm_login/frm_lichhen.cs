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

        private void frm_lichhen_Load(object sender, EventArgs e)
        {
            string filePath = "D:\\VISUAL STUDIO\\QLPKDa\\PICTURE\\THUOC.png";

            // Kiểm tra và thêm cột nếu cần
            if (dta_lichhen.Columns.Count < 6)
            {
                dta_lichhen.Columns.Clear();
                dta_lichhen.Columns.Add("STT", "STT");
                dta_lichhen.Columns.Add(new DataGridViewImageColumn() { HeaderText = "Hình Ảnh", Name = "imgColumn", ImageLayout = DataGridViewImageCellLayout.Zoom });
                dta_lichhen.Columns.Add("BasicInfo", "Basic Info");
                dta_lichhen.Columns.Add("Time", "Time");
                dta_lichhen.Columns.Add("Date", "Date");
                dta_lichhen.Columns.Add("Service", "Service");
                dta_lichhen.Columns.Add("Note", "Note");
            }

            // Thêm dữ liệu mẫu
            for (int i = 0; i < 10; i++)
            {
                dta_lichhen.Rows.Add();

                // Nạp hình ảnh từ tệp
                if (File.Exists(filePath))
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        dta_lichhen.Rows[i].Cells[1].Value = Image.FromStream(fs);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tệp hình ảnh tại đường dẫn: " + filePath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dta_lichhen.Rows[i].Cells[1].Value = null;
                }

                // Thêm các giá trị vào các cột khác
                dta_lichhen.Rows[i].Cells[0].Value = (i + 1).ToString(); // STT
                dta_lichhen.Rows[i].Cells[2].Value = "Patient " + (i + 1); // Basic Info
                dta_lichhen.Rows[i].Cells[3].Value = "10:00 AM"; // Time
                dta_lichhen.Rows[i].Cells[4].Value = "22-12-2024"; // Date
                dta_lichhen.Rows[i].Cells[5].Value = "Consultation"; // Service
                dta_lichhen.Rows[i].Cells[6].Value = "Follow-up required"; // Note
            }
        }
    }
}
