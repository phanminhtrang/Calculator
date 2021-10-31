using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Biến toàn cục
        int diem;
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
            int so1, so2, so3;
            int tong;
            Random rand = new Random();

            if (rad11.Checked || rad3.Checked)
            {
                //random ra số
                so1 = rand.Next(1, 7); //0-6
                so2 = rand.Next(1, 7);
                so3 = rand.Next(1, 7);
                tong = so1 + so2 + so3;

                //Hiển thị ra form
                lbSo1.Text = so1.ToString();
                lbSo2.Text = so2.ToString();
                lbSo3.Text = so3.ToString();

                //Kiểm tra lựa chọn của người chơi
                if (rad3.Checked) //Chọn 3 - 10
                {
                    if (tong >= 3 && tong <= 10) //Đúng
                    {
                        diem += 10;
                    }
                    else //Sai
                    {
                        diem -= 10;
                    }

                }
                else //Chọn 11 - 18
                {
                    if (tong >= 11 && tong <= 18) //Đúng
                    {
                        diem += 10;
                    }
                    else //Sai
                    {
                        diem -= 10;
                    }

                }
                //Hiển thị điểm ra form
                lbDiem.Text = diem.ToString();
            }
            else
            {
                MessageBox.Show("Phải chọn 1 trong 2 đáp án!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diem = 0;
            rad3.Checked = false;
            rad11.Checked = false;
            rad3.BackColor = rad11.BackColor = Color.LightSeaGreen;
        }

        private void btChoiLai_Click(object sender, EventArgs e)
        {
            diem = 0;
            lbDiem.Text = lbSo1.Text = lbSo2.Text = lbSo3.Text = "";
            rad3.Checked = false;
            rad11.Checked = false;
            rad3.BackColor = rad11.BackColor = Color.LightSeaGreen;
        }

        private void rad3_CheckedChanged(object sender, EventArgs e)
        {
            //Rad nào được chọn -> Đổi BackColor
            RadioButton rad = (RadioButton)sender;
            if (rad.Checked)
            {
                rad.BackColor = Color.BlueViolet;
            }
            else
            {
                rad.BackColor = Color.DeepPink;
            }
        }

        private void rad11_CheckedChanged(object sender, EventArgs e)
        {
            //Rad nào được chọn -> Đổi BackColor
            RadioButton rad = (RadioButton)sender;
            if (rad.Checked)
            {
                rad.BackColor = Color.BlueViolet;
            }
            else
            {
                rad.BackColor = Color.DeepPink;
            }
        }
    }
}
