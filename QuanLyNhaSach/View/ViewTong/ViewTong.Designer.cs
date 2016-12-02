namespace QuanLyNhaSach.View.ViewTong
{
    partial class ViewTong
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
            this.sachControlForm1 = new QuanLyNhaSach.View.Sach.SachControlForm();
            this.SuspendLayout();
            // 
            // sachControlForm1
            // 
            this.sachControlForm1.getListLinhVuc = null;
            this.sachControlForm1.getListLoaiSach = null;
            this.sachControlForm1.getListSach = null;
            this.sachControlForm1.getListTacGia = null;
            this.sachControlForm1.GIAMUA = 0;
            this.sachControlForm1.Location = new System.Drawing.Point(12, 70);
            this.sachControlForm1.MALINHVUC = "";
            this.sachControlForm1.MALOAISACH = "";
            this.sachControlForm1.MASACH = "";
            this.sachControlForm1.Name = "sachControlForm1";
            this.sachControlForm1.Size = new System.Drawing.Size(792, 386);
            this.sachControlForm1.TabIndex = 0;
            this.sachControlForm1.TENSACH = "";
            // 
            // ViewTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 468);
            this.Controls.Add(this.sachControlForm1);
            this.Name = "ViewTong";
            this.Text = "ViewTong";
            this.ResumeLayout(false);

        }

        #endregion

        private Sach.SachControlForm sachControlForm1;
    }
}