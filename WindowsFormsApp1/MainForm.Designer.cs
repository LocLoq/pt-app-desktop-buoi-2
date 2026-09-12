namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBHV = new System.Windows.Forms.ComboBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.dtDK = new System.Windows.Forms.DateTimePicker();
            this.cbTHA = new System.Windows.Forms.CheckBox();
            this.cbTHB = new System.Windows.Forms.CheckBox();
            this.cbTAA = new System.Windows.Forms.CheckBox();
            this.cbTAB = new System.Windows.Forms.CheckBox();
            this.lbTHA = new System.Windows.Forms.Label();
            this.TinhTienBtn = new System.Windows.Forms.Button();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.lbTAB = new System.Windows.Forms.Label();
            this.lbTAA = new System.Windows.Forms.Label();
            this.lbTHB = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.tbTong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Học Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Đăng Ký";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(63, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "TÍNH TIỀN HỌC TRUNG TÂM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giới tính ";
            // 
            // comboBHV
            // 
            this.comboBHV.FormattingEnabled = true;
            this.comboBHV.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005"});
            this.comboBHV.Location = new System.Drawing.Point(103, 74);
            this.comboBHV.Name = "comboBHV";
            this.comboBHV.Size = new System.Drawing.Size(121, 21);
            this.comboBHV.TabIndex = 0;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(103, 101);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(340, 20);
            this.tbTen.TabIndex = 3;
            // 
            // dtDK
            // 
            this.dtDK.Location = new System.Drawing.Point(103, 129);
            this.dtDK.Name = "dtDK";
            this.dtDK.Size = new System.Drawing.Size(200, 20);
            this.dtDK.TabIndex = 4;
            // 
            // cbTHA
            // 
            this.cbTHA.AutoSize = true;
            this.cbTHA.Location = new System.Drawing.Point(68, 165);
            this.cbTHA.Name = "cbTHA";
            this.cbTHA.Size = new System.Drawing.Size(72, 17);
            this.cbTHA.TabIndex = 5;
            this.cbTHA.Text = "Tin học A";
            this.cbTHA.UseVisualStyleBackColor = true;
            // 
            // cbTHB
            // 
            this.cbTHB.AutoSize = true;
            this.cbTHB.Location = new System.Drawing.Point(68, 188);
            this.cbTHB.Name = "cbTHB";
            this.cbTHB.Size = new System.Drawing.Size(72, 17);
            this.cbTHB.TabIndex = 6;
            this.cbTHB.Text = "Tin học B";
            this.cbTHB.UseVisualStyleBackColor = true;
            // 
            // cbTAA
            // 
            this.cbTAA.AutoSize = true;
            this.cbTAA.Location = new System.Drawing.Point(68, 211);
            this.cbTAA.Name = "cbTAA";
            this.cbTAA.Size = new System.Drawing.Size(85, 17);
            this.cbTAA.TabIndex = 7;
            this.cbTAA.Text = "Tiếng Anh A";
            this.cbTAA.UseVisualStyleBackColor = true;
            // 
            // cbTAB
            // 
            this.cbTAB.AutoSize = true;
            this.cbTAB.Location = new System.Drawing.Point(68, 234);
            this.cbTAB.Name = "cbTAB";
            this.cbTAB.Size = new System.Drawing.Size(85, 17);
            this.cbTAB.TabIndex = 8;
            this.cbTAB.Text = "Tiếng Anh B";
            this.cbTAB.UseVisualStyleBackColor = true;
            // 
            // lbTHA
            // 
            this.lbTHA.AutoSize = true;
            this.lbTHA.Location = new System.Drawing.Point(268, 169);
            this.lbTHA.Name = "lbTHA";
            this.lbTHA.Size = new System.Drawing.Size(74, 13);
            this.lbTHA.TabIndex = 2;
            this.lbTHA.Text = "300.000 đồng";
            // 
            // TinhTienBtn
            // 
            this.TinhTienBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhTienBtn.ForeColor = System.Drawing.Color.Blue;
            this.TinhTienBtn.Location = new System.Drawing.Point(68, 286);
            this.TinhTienBtn.Name = "TinhTienBtn";
            this.TinhTienBtn.Size = new System.Drawing.Size(98, 38);
            this.TinhTienBtn.TabIndex = 11;
            this.TinhTienBtn.Text = "Tính Tiền";
            this.TinhTienBtn.UseVisualStyleBackColor = true;
            this.TinhTienBtn.Click += new System.EventHandler(this.TinhTienBtn_Click);
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(315, 74);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 1;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(391, 74);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 2;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // lbTAB
            // 
            this.lbTAB.AutoSize = true;
            this.lbTAB.Location = new System.Drawing.Point(268, 238);
            this.lbTAB.Name = "lbTAB";
            this.lbTAB.Size = new System.Drawing.Size(74, 13);
            this.lbTAB.TabIndex = 2;
            this.lbTAB.Text = "600.000 đồng";
            // 
            // lbTAA
            // 
            this.lbTAA.AutoSize = true;
            this.lbTAA.Location = new System.Drawing.Point(268, 215);
            this.lbTAA.Name = "lbTAA";
            this.lbTAA.Size = new System.Drawing.Size(74, 13);
            this.lbTAA.TabIndex = 2;
            this.lbTAA.Text = "400.000 đồng";
            // 
            // lbTHB
            // 
            this.lbTHB.AutoSize = true;
            this.lbTHB.Location = new System.Drawing.Point(268, 192);
            this.lbTHB.Name = "lbTHB";
            this.lbTHB.Size = new System.Drawing.Size(74, 13);
            this.lbTHB.TabIndex = 2;
            this.lbTHB.Text = "500.000 đồng";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Blue;
            this.exitBtn.Location = new System.Drawing.Point(300, 285);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(62, 38);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBTN.ForeColor = System.Drawing.Color.Red;
            this.CancelBTN.Location = new System.Drawing.Point(182, 285);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(98, 38);
            this.CancelBTN.TabIndex = 10;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // tbTong
            // 
            this.tbTong.Location = new System.Drawing.Point(227, 254);
            this.tbTong.Name = "tbTong";
            this.tbTong.ReadOnly = true;
            this.tbTong.Size = new System.Drawing.Size(115, 20);
            this.tbTong.TabIndex = 9;
            this.tbTong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tổng Tiền";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 336);
            this.Controls.Add(this.tbTong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.lbTHB);
            this.Controls.Add(this.lbTAA);
            this.Controls.Add(this.lbTAB);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.TinhTienBtn);
            this.Controls.Add(this.lbTHA);
            this.Controls.Add(this.cbTAB);
            this.Controls.Add(this.cbTAA);
            this.Controls.Add(this.cbTHB);
            this.Controls.Add(this.cbTHA);
            this.Controls.Add(this.dtDK);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.comboBHV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBHV;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.DateTimePicker dtDK;
        private System.Windows.Forms.CheckBox cbTHA;
        private System.Windows.Forms.CheckBox cbTHB;
        private System.Windows.Forms.CheckBox cbTAA;
        private System.Windows.Forms.CheckBox cbTAB;
        private System.Windows.Forms.Label lbTHA;
        private System.Windows.Forms.Button TinhTienBtn;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.Label lbTAB;
        private System.Windows.Forms.Label lbTAA;
        private System.Windows.Forms.Label lbTHB;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.TextBox tbTong;
        private System.Windows.Forms.Label label6;
    }
}

