namespace Bai_3_Chu_de_2
{
    partial class FrmSearchGV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchValueTBox = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.findingLabel = new System.Windows.Forms.Label();
            this.maGVRB = new System.Windows.Forms.RadioButton();
            this.sdtRB = new System.Windows.Forms.RadioButton();
            this.hoTenRB = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchValueTBox);
            this.groupBox1.Controls.Add(this.findBtn);
            this.groupBox1.Controls.Add(this.findingLabel);
            this.groupBox1.Controls.Add(this.maGVRB);
            this.groupBox1.Controls.Add(this.sdtRB);
            this.groupBox1.Controls.Add(this.hoTenRB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo";
            // 
            // searchValueTBox
            // 
            this.searchValueTBox.Location = new System.Drawing.Point(121, 76);
            this.searchValueTBox.Name = "searchValueTBox";
            this.searchValueTBox.Size = new System.Drawing.Size(340, 26);
            this.searchValueTBox.TabIndex = 5;
            // 
            // findBtn
            // 
            this.findBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.ForeColor = System.Drawing.Color.Blue;
            this.findBtn.Location = new System.Drawing.Point(501, 69);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(90, 40);
            this.findBtn.TabIndex = 4;
            this.findBtn.Text = "Tìm";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // findingLabel
            // 
            this.findingLabel.AutoSize = true;
            this.findingLabel.Location = new System.Drawing.Point(24, 76);
            this.findingLabel.Name = "findingLabel";
            this.findingLabel.Size = new System.Drawing.Size(57, 20);
            this.findingLabel.TabIndex = 3;
            this.findingLabel.Text = "Họ tên";
            // 
            // maGVRB
            // 
            this.maGVRB.AutoSize = true;
            this.maGVRB.Location = new System.Drawing.Point(492, 36);
            this.maGVRB.Name = "maGVRB";
            this.maGVRB.Size = new System.Drawing.Size(77, 24);
            this.maGVRB.TabIndex = 2;
            this.maGVRB.Text = "Mã GV";
            this.maGVRB.UseVisualStyleBackColor = true;
            this.maGVRB.CheckedChanged += new System.EventHandler(this.maGVRB_CheckedChanged);
            // 
            // sdtRB
            // 
            this.sdtRB.AutoSize = true;
            this.sdtRB.Location = new System.Drawing.Point(241, 36);
            this.sdtRB.Name = "sdtRB";
            this.sdtRB.Size = new System.Drawing.Size(120, 24);
            this.sdtRB.TabIndex = 1;
            this.sdtRB.Text = "Số điện thoại";
            this.sdtRB.UseVisualStyleBackColor = true;
            this.sdtRB.CheckedChanged += new System.EventHandler(this.sdtRB_CheckedChanged);
            // 
            // hoTenRB
            // 
            this.hoTenRB.AutoSize = true;
            this.hoTenRB.Checked = true;
            this.hoTenRB.Location = new System.Drawing.Point(28, 36);
            this.hoTenRB.Name = "hoTenRB";
            this.hoTenRB.Size = new System.Drawing.Size(75, 24);
            this.hoTenRB.TabIndex = 0;
            this.hoTenRB.TabStop = true;
            this.hoTenRB.Text = "Họ tên";
            this.hoTenRB.UseVisualStyleBackColor = true;
            this.hoTenRB.CheckedChanged += new System.EventHandler(this.hoTenRB_CheckedChanged);
            // 
            // FrmSearchGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 151);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSearchGV";
            this.Text = "FrmSearchGV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton maGVRB;
        private System.Windows.Forms.RadioButton sdtRB;
        private System.Windows.Forms.RadioButton hoTenRB;
        private System.Windows.Forms.TextBox searchValueTBox;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Label findingLabel;
    }
}