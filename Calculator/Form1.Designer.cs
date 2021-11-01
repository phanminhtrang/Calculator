
namespace Calculator
{
    partial class Form1
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
            this.label5 = new System.Windows.Forms.Label();
            this.byQuaySo = new System.Windows.Forms.Button();
            this.btChoiLai = new System.Windows.Forms.Button();
            this.lbDiem = new System.Windows.Forms.Label();
            this.rad11 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSo3 = new System.Windows.Forms.Label();
            this.lbSo2 = new System.Windows.Forms.Label();
            this.lbSo1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(561, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "Điểm: ";
            // 
            // byQuaySo
            // 
            this.byQuaySo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.byQuaySo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.byQuaySo.Location = new System.Drawing.Point(295, 460);
            this.byQuaySo.Name = "byQuaySo";
            this.byQuaySo.Size = new System.Drawing.Size(201, 64);
            this.byQuaySo.TabIndex = 11;
            this.byQuaySo.Text = "Quay sô";
            this.byQuaySo.UseVisualStyleBackColor = false;
            this.byQuaySo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btChoiLai
            // 
            this.btChoiLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btChoiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btChoiLai.Location = new System.Drawing.Point(52, 460);
            this.btChoiLai.Name = "btChoiLai";
            this.btChoiLai.Size = new System.Drawing.Size(201, 64);
            this.btChoiLai.TabIndex = 12;
            this.btChoiLai.Text = "Chơi lại";
            this.btChoiLai.UseVisualStyleBackColor = false;
            this.btChoiLai.Click += new System.EventHandler(this.btChoiLai_Click);
            // 
            // lbDiem
            // 
            this.lbDiem.BackColor = System.Drawing.Color.Crimson;
            this.lbDiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiem.Location = new System.Drawing.Point(685, 460);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(160, 64);
            this.lbDiem.TabIndex = 6;
            this.lbDiem.Text = "00";
            this.lbDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rad11
            // 
            this.rad11.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad11.BackColor = System.Drawing.Color.SpringGreen;
            this.rad11.Location = new System.Drawing.Point(478, 58);
            this.rad11.Name = "rad11";
            this.rad11.Size = new System.Drawing.Size(216, 54);
            this.rad11.TabIndex = 0;
            this.rad11.TabStop = true;
            this.rad11.Text = "11 - 18";
            this.rad11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rad11.UseVisualStyleBackColor = false;
            this.rad11.CheckedChanged += new System.EventHandler(this.rad11_CheckedChanged);
            // 
            // rad3
            // 
            this.rad3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad3.BackColor = System.Drawing.Color.SpringGreen;
            this.rad3.Location = new System.Drawing.Point(141, 58);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(216, 54);
            this.rad3.TabIndex = 0;
            this.rad3.TabStop = true;
            this.rad3.Text = "3 - 10";
            this.rad3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rad3.UseVisualStyleBackColor = false;
            this.rad3.CheckedChanged += new System.EventHandler(this.rad3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad11);
            this.groupBox1.Controls.Add(this.rad3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(42, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 151);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // lbSo3
            // 
            this.lbSo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbSo3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSo3.Location = new System.Drawing.Point(634, 89);
            this.lbSo3.Name = "lbSo3";
            this.lbSo3.Size = new System.Drawing.Size(143, 176);
            this.lbSo3.TabIndex = 7;
            this.lbSo3.Text = "0";
            this.lbSo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSo2
            // 
            this.lbSo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbSo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSo2.Location = new System.Drawing.Point(370, 89);
            this.lbSo2.Name = "lbSo2";
            this.lbSo2.Size = new System.Drawing.Size(143, 176);
            this.lbSo2.TabIndex = 8;
            this.lbSo2.Text = "0";
            this.lbSo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSo1
            // 
            this.lbSo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbSo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSo1.Location = new System.Drawing.Point(110, 89);
            this.lbSo1.Name = "lbSo1";
            this.lbSo1.Size = new System.Drawing.Size(143, 176);
            this.lbSo1.TabIndex = 9;
            this.lbSo1.Text = "0";
            this.lbSo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(239, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "ỨNG DỤNG ĐOÁN SỐ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(893, 553);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.byQuaySo);
            this.Controls.Add(this.btChoiLai);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbSo3);
            this.Controls.Add(this.lbSo2);
            this.Controls.Add(this.lbSo1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button byQuaySo;
        private System.Windows.Forms.Button btChoiLai;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.RadioButton rad11;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSo3;
        private System.Windows.Forms.Label lbSo2;
        private System.Windows.Forms.Label lbSo1;
        private System.Windows.Forms.Label label1;
    }
}

