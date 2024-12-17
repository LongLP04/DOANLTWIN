
namespace frm_login
{
    partial class frm_lichhen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_lichhen));
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.btn_addLichHen = new System.Windows.Forms.Button();
            this.txt_Find = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thaotac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeSlot,
            this.Name,
            this.Phone,
            this.Address,
            this.Doctor,
            this.Status,
            this.Content,
            this.thaotac});
            this.dataGridViewAppointments.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(5, 128);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.RowHeadersWidth = 51;
            this.dataGridViewAppointments.RowTemplate.Height = 24;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(1050, 514);
            this.dataGridViewAppointments.TabIndex = 0;
            this.dataGridViewAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppointments_CellContentClick);
            // 
            // btn_addLichHen
            // 
            this.btn_addLichHen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addLichHen.Location = new System.Drawing.Point(890, 57);
            this.btn_addLichHen.Name = "btn_addLichHen";
            this.btn_addLichHen.Size = new System.Drawing.Size(165, 54);
            this.btn_addLichHen.TabIndex = 1;
            this.btn_addLichHen.Text = "Thêm Lịch Hẹn";
            this.btn_addLichHen.UseVisualStyleBackColor = false;
            // 
            // txt_Find
            // 
            this.txt_Find.AutoRoundedCorners = true;
            this.txt_Find.BorderRadius = 16;
            this.txt_Find.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Find.DefaultText = " Tìm Theo mã hồ sơ , Số Điện Thoại , Họ Tên";
            this.txt_Find.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Find.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Find.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Find.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Find.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Find.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Find.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Find.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_Find.IconLeft")));
            this.txt_Find.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_Find.Location = new System.Drawing.Point(5, 76);
            this.txt_Find.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.PasswordChar = '\0';
            this.txt_Find.PlaceholderText = "Tìm kiếm";
            this.txt_Find.SelectedText = "";
            this.txt_Find.Size = new System.Drawing.Size(380, 35);
            this.txt_Find.TabIndex = 4;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2Button2.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.Location = new System.Drawing.Point(408, 74);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(63, 37);
            this.guna2Button2.TabIndex = 7;
            this.guna2Button2.Text = "Lọc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danh sách lịch hẹn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TimeSlot
            // 
            this.TimeSlot.HeaderText = "Khung Giờ";
            this.TimeSlot.MinimumWidth = 6;
            this.TimeSlot.Name = "TimeSlot";
            this.TimeSlot.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Họ Tên";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Số Điện Thoại";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // Doctor
            // 
            this.Doctor.HeaderText = "Bác Sĩ ";
            this.Doctor.MinimumWidth = 6;
            this.Doctor.Name = "Doctor";
            this.Doctor.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Trạng Thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // Content
            // 
            this.Content.HeaderText = "Nội Dung";
            this.Content.MinimumWidth = 6;
            this.Content.Name = "Content";
            this.Content.Width = 125;
            // 
            // thaotac
            // 
            this.thaotac.HeaderText = "Thao tác";
            this.thaotac.MinimumWidth = 6;
            this.thaotac.Name = "thaotac";
            this.thaotac.Width = 125;
            // 
            // frm_lichhen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1394, 689);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.txt_Find);
            this.Controls.Add(this.btn_addLichHen);
            //this.Name = "frm_lichhen";
            this.Load += new System.EventHandler(this.frm_lichhen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Button btn_addLichHen;
        private Guna.UI2.WinForms.Guna2TextBox txt_Find;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn thaotac;
    }
}