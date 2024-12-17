namespace frm_login
{
    partial class frm_doanhhthu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ballotType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderRecipient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addMoi = new System.Windows.Forms.Button();
            this.cbb_ThangNay = new System.Windows.Forms.ComboBox();
            this.cbb_LoaiPhieu = new System.Windows.Forms.ComboBox();
            this.cbb_Nhom = new System.Windows.Forms.ComboBox();
            this.cbb_DanhMuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ballotType,
            this.creationDate,
            this.amount,
            this.Method,
            this.SenderRecipient,
            this.Creator,
            this.Content,
            this.operation});
            this.dataGridView1.Location = new System.Drawing.Point(6, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // ballotType
            // 
            this.ballotType.HeaderText = "Loại Phiếu";
            this.ballotType.MinimumWidth = 6;
            this.ballotType.Name = "ballotType";
            this.ballotType.Width = 125;
            // 
            // creationDate
            // 
            this.creationDate.HeaderText = "Ngày Tạo";
            this.creationDate.MinimumWidth = 6;
            this.creationDate.Name = "creationDate";
            this.creationDate.Width = 125;
            // 
            // amount
            // 
            this.amount.HeaderText = "Số Tiền";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.Width = 125;
            // 
            // Method
            // 
            this.Method.HeaderText = "Phương Thức";
            this.Method.MinimumWidth = 6;
            this.Method.Name = "Method";
            this.Method.Width = 125;
            // 
            // SenderRecipient
            // 
            this.SenderRecipient.HeaderText = "Người Nộp/Người Nhận";
            this.SenderRecipient.MinimumWidth = 6;
            this.SenderRecipient.Name = "SenderRecipient";
            this.SenderRecipient.Width = 125;
            // 
            // Creator
            // 
            this.Creator.HeaderText = "Người Tạo";
            this.Creator.MinimumWidth = 6;
            this.Creator.Name = "Creator";
            this.Creator.Width = 125;
            // 
            // Content
            // 
            this.Content.HeaderText = "Nội Dung";
            this.Content.MinimumWidth = 6;
            this.Content.Name = "Content";
            this.Content.Width = 125;
            // 
            // operation
            // 
            this.operation.HeaderText = "Thao Tác";
            this.operation.MinimumWidth = 6;
            this.operation.Name = "operation";
            this.operation.Width = 125;
            // 
            // btn_addMoi
            // 
            this.btn_addMoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addMoi.Location = new System.Drawing.Point(818, 47);
            this.btn_addMoi.Name = "btn_addMoi";
            this.btn_addMoi.Size = new System.Drawing.Size(165, 54);
            this.btn_addMoi.TabIndex = 2;
            this.btn_addMoi.Text = "Thêm Mới";
            this.btn_addMoi.UseVisualStyleBackColor = false;
            // 
            // cbb_ThangNay
            // 
            this.cbb_ThangNay.FormattingEnabled = true;
            this.cbb_ThangNay.Location = new System.Drawing.Point(9, 77);
            this.cbb_ThangNay.Name = "cbb_ThangNay";
            this.cbb_ThangNay.Size = new System.Drawing.Size(121, 24);
            this.cbb_ThangNay.TabIndex = 3;
            // 
            // cbb_LoaiPhieu
            // 
            this.cbb_LoaiPhieu.FormattingEnabled = true;
            this.cbb_LoaiPhieu.Location = new System.Drawing.Point(136, 77);
            this.cbb_LoaiPhieu.Name = "cbb_LoaiPhieu";
            this.cbb_LoaiPhieu.Size = new System.Drawing.Size(121, 24);
            this.cbb_LoaiPhieu.TabIndex = 4;
            // 
            // cbb_Nhom
            // 
            this.cbb_Nhom.FormattingEnabled = true;
            this.cbb_Nhom.Location = new System.Drawing.Point(263, 77);
            this.cbb_Nhom.Name = "cbb_Nhom";
            this.cbb_Nhom.Size = new System.Drawing.Size(121, 24);
            this.cbb_Nhom.TabIndex = 5;
            // 
            // cbb_DanhMuc
            // 
            this.cbb_DanhMuc.FormattingEnabled = true;
            this.cbb_DanhMuc.Location = new System.Drawing.Point(390, 77);
            this.cbb_DanhMuc.Name = "cbb_DanhMuc";
            this.cbb_DanhMuc.Size = new System.Drawing.Size(121, 24);
            this.cbb_DanhMuc.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản Lý Doanh Thu";
            // 
            // frm_doanhhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1051, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_DanhMuc);
            this.Controls.Add(this.cbb_Nhom);
            this.Controls.Add(this.cbb_LoaiPhieu);
            this.Controls.Add(this.cbb_ThangNay);
            this.Controls.Add(this.btn_addMoi);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_doanhhthu";
            this.Text = "frm_doanhthu";
            this.Load += new System.EventHandler(this.frm_doanhhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_addMoi;
        private System.Windows.Forms.ComboBox cbb_ThangNay;
        private System.Windows.Forms.ComboBox cbb_LoaiPhieu;
        private System.Windows.Forms.ComboBox cbb_Nhom;
        private System.Windows.Forms.ComboBox cbb_DanhMuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ballotType;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderRecipient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn operation;
    }
}