namespace QuanLyNhaSach.View
{
    partial class TacGiaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Label1 = new MaterialSkin.Controls.MaterialLabel();
            this.Label2 = new MaterialSkin.Controls.MaterialLabel();
            this.TextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new MaterialSkin.Controls.MaterialLabel();
            this.Label4 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Button1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.Button2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.Button3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.CheckBox2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // TextField1
            // 
            this.TextField1.Depth = 0;
            this.TextField1.Hint = "";
            this.TextField1.Location = new System.Drawing.Point(464, 111);
            this.TextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextField1.Name = "TextField1";
            this.TextField1.PasswordChar = '\0';
            this.TextField1.SelectedText = "";
            this.TextField1.SelectionLength = 0;
            this.TextField1.SelectionStart = 0;
            this.TextField1.Size = new System.Drawing.Size(170, 23);
            this.TextField1.TabIndex = 1;
            this.TextField1.UseSystemPasswordChar = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Depth = 0;
            this.Label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label1.Location = new System.Drawing.Point(461, 82);
            this.Label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 19);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Tên Tác Giả";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Depth = 0;
            this.Label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label2.Location = new System.Drawing.Point(461, 285);
            this.Label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 19);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Quê Quán";
            // 
            // TextField2
            // 
            this.TextField2.Depth = 0;
            this.TextField2.Hint = "";
            this.TextField2.Location = new System.Drawing.Point(462, 319);
            this.TextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextField2.Name = "TextField2";
            this.TextField2.PasswordChar = '\0';
            this.TextField2.SelectedText = "";
            this.TextField2.SelectionLength = 0;
            this.TextField2.SelectionStart = 0;
            this.TextField2.Size = new System.Drawing.Size(170, 23);
            this.TextField2.TabIndex = 4;
            this.TextField2.UseSystemPasswordChar = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(464, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Depth = 0;
            this.Label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label3.Location = new System.Drawing.Point(461, 145);
            this.Label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(76, 19);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Ngày Sinh";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Depth = 0;
            this.Label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label4.Location = new System.Drawing.Point(461, 220);
            this.Label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(73, 19);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Ngày Mất";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(464, 252);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // Button1
            // 
            this.Button1.AutoSize = true;
            this.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button1.Depth = 0;
            this.Button1.Location = new System.Drawing.Point(642, 74);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button1.Name = "Button1";
            this.Button1.Primary = false;
            this.Button1.Size = new System.Drawing.Size(50, 36);
            this.Button1.TabIndex = 10;
            this.Button1.Text = "Thêm";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.AutoSize = true;
            this.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button2.Depth = 0;
            this.Button2.Location = new System.Drawing.Point(707, 74);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button2.Name = "Button2";
            this.Button2.Primary = false;
            this.Button2.Size = new System.Drawing.Size(39, 36);
            this.Button2.TabIndex = 11;
            this.Button2.Text = "Sửa";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.AutoSize = true;
            this.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button3.Depth = 0;
            this.Button3.Location = new System.Drawing.Point(642, 118);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button3.Name = "Button3";
            this.Button3.Primary = false;
            this.Button3.Size = new System.Drawing.Size(39, 36);
            this.Button3.TabIndex = 12;
            this.Button3.Text = "xóa";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Depth = 0;
            this.CheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckBox1.Location = new System.Drawing.Point(641, 182);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Ripple = true;
            this.CheckBox1.Size = new System.Drawing.Size(79, 30);
            this.CheckBox1.TabIndex = 13;
            this.CheckBox1.Text = "Chưa rõ ";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Depth = 0;
            this.CheckBox2.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckBox2.Location = new System.Drawing.Point(641, 250);
            this.CheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Ripple = true;
            this.CheckBox2.Size = new System.Drawing.Size(79, 30);
            this.CheckBox2.TabIndex = 14;
            this.CheckBox2.Text = "Chưa rõ";
            this.CheckBox2.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(689, 118);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(57, 36);
            this.materialFlatButton1.TabIndex = 15;
            this.materialFlatButton1.Text = "Thoát";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // TacGiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 394);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.CheckBox2);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextField2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextField1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TacGiaForm";
            this.Text = "Thông Tin Tác Giả";
            this.Load += new System.EventHandler(this.TacGiaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextField1;
        private MaterialSkin.Controls.MaterialLabel Label1;
        private MaterialSkin.Controls.MaterialLabel Label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextField2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel Label3;
        private MaterialSkin.Controls.MaterialLabel Label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MaterialSkin.Controls.MaterialFlatButton Button1;
        private MaterialSkin.Controls.MaterialFlatButton Button2;
        private MaterialSkin.Controls.MaterialFlatButton Button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialCheckBox CheckBox2;
        private MaterialSkin.Controls.MaterialCheckBox CheckBox1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}