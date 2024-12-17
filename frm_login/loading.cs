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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(guna2CircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                frm_saudangnhap frmSauDangNhap = new frm_saudangnhap(); 
                frmSauDangNhap.Show();
                this.Close(); 
            }    
           else
            {
                guna2CircleProgressBar1.Value += 4;
                lbl_numberload.Text = (Convert.ToInt32(lbl_numberload.Text) + 4).ToString();
            }
        }

        private void loading_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
