namespace QuanLyNhaSach.View.NhatKiNhapSach
{
    partial class NhatKiNhapSachForm
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.Button3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.Button2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.Button1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.Label3 = new MaterialSkin.Controls.MaterialLabel();
            this.Label1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(514, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 37;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(514, 132);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(106, 20);
            this.numericUpDown1.TabIndex = 36;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(408, 176);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 19);
            this.materialLabel1.TabIndex = 35;
            this.materialLabel1.Text = "Ngày Nhập";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(440, 262);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(57, 36);
            this.materialFlatButton1.TabIndex = 34;
            this.materialFlatButton1.Text = "Thoát";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Button3
            // 
            this.Button3.AutoSize = true;
            this.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button3.Depth = 0;
            this.Button3.Location = new System.Drawing.Point(387, 262);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button3.Name = "Button3";
            this.Button3.Primary = false;
            this.Button3.Size = new System.Drawing.Size(39, 36);
            this.Button3.TabIndex = 33;
            this.Button3.Text = "xóa";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.AutoSize = true;
            this.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button2.Depth = 0;
            this.Button2.Location = new System.Drawing.Point(458, 214);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button2.Name = "Button2";
            this.Button2.Primary = false;
            this.Button2.Size = new System.Drawing.Size(39, 36);
            this.Button2.TabIndex = 32;
            this.Button2.Text = "Sửa";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.AutoSize = true;
            this.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button1.Depth = 0;
            this.Button1.Location = new System.Drawing.Point(387, 214);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button1.Name = "Button1";
            this.Button1.Primary = false;
            this.Button1.Size = new System.Drawing.Size(50, 36);
            this.Button1.TabIndex = 31;
            this.Button1.Text = "Thêm";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Depth = 0;
            this.Label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label3.Location = new System.Drawing.Point(408, 132);
            this.Label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 19);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "Số lượng";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Depth = 0;
            this.Label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label1.Location = new System.Drawing.Point(408, 83);
            this.Label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(67, 19);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "Mã Sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(364, 308);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(514, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 20);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // NhatKiNhapSachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 409);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NhatKiNhapSachForm";
            this.Text = "NhatKiNhapSachForm";
            this.Load += new System.EventHandler(this.NhatKiNhapSachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton Button3;
        private MaterialSkin.Controls.MaterialFlatButton Button2;
        private MaterialSkin.Controls.MaterialFlatButton Button1;
        private MaterialSkin.Controls.MaterialLabel Label3;
        private MaterialSkin.Controls.MaterialLabel Label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}