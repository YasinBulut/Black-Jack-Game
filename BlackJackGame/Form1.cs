using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            button5.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac==1)
            {
                int a1, a2, toplam;
                a1 = rastgele.Next(1, 11);
                a2 = rastgele.Next(1, 11);
                toplam = a1 + a2;

                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                lbloyuncu.Text = toplam.ToString();
            }
            if (sayac==2)
            {
                int a3, toplam;
                a3 = rastgele.Next(1,11);
                label3.Text = a3.ToString();

                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + a3;
                lbloyuncu.Text = toplam.ToString();
              
            }
            if (sayac==3)
            {
                int a4, toplam;
                a4 = rastgele.Next(1,11);
                label4.Text = a4.ToString();

                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + a4;
                lbloyuncu.Text = toplam.ToString();
            }
            //1.resim
            if (label1.Text=="1")
            {
                pictureBox2.ImageLocation =@"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\A.png";
            }
            if (label1.Text == "2")
            {
                pictureBox2.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\2.png";
            }
            if (label1.Text == "3")
            {
                pictureBox2.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\3.png";
            }
            if (label1.Text == "4")
            {
                pictureBox2.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\4.png";
            }
            if (label1.Text == "5")
            {
                pictureBox2.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\5.png";
            }
            if (label1.Text == "6")
            {
                pictureBox2.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\6.png";
            }
            if (label1.Text == "7")
            {
                pictureBox2.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\7.png";
            }
            if (label1.Text == "8")
            {
                pictureBox2.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\8.png";
            }
            if (label1.Text == "9")
            {
                pictureBox2.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\9.png";
            }
            if (label1.Text == "10")
            {
                pictureBox2.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\j.png";
            }
            //2.resim
            if (label2.Text == "1")
            {
                pictureBox3.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\A.png";
            }
            if (label2.Text == "2")
            {
                pictureBox3.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\2.png";
            }
            if (label2.Text == "3")
            {
                pictureBox3.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\3.png";
            }
            if (label2.Text == "4")
            {
                pictureBox3.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\4.png";
            }
            if (label2.Text == "5")
            {
                pictureBox3.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\5.png";
            }
            if (label2.Text == "6")
            {
                pictureBox3.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\6.png";
            }
            if (label2.Text == "7")
            {
                pictureBox3.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\7.png";
            }
            if (label2.Text == "8")
            {
                pictureBox3.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\8.png";
            }
            if (label2.Text == "9")
            {
                pictureBox3.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\9.png";
            }
            if (label2.Text == "10")
            {
                pictureBox3.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\j.png";
            }
            //3.kart
            if (label3.Text == "1")
            {
                pictureBox4.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\A.png";
            }
            if (label3.Text == "2")
            {
                pictureBox4.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\2.png";
            }
            if (label3.Text == "3")
            {
                pictureBox4.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\3.png";
            }
            if (label3.Text == "4")
            {
                pictureBox4.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\4.png";
            }
            if (label3.Text == "5")
            {
                pictureBox4.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\5.png";
            }
            if (label3.Text == "6")
            {
                pictureBox4.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\6.png";
            }
            if (label3.Text == "7")
            {
                pictureBox4.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\7.png";
            }
            if (label3.Text == "8")
            {
                pictureBox4.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\8.png";
            }
            if (label3.Text == "9")
            {
                pictureBox4.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\9.png";
            }
            if (label3.Text == "10")
            {
                pictureBox4.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\j.png";
            }
            //4.çek
            if (label4.Text == "1")
            {
                pictureBox5.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\A.png";
            }
            if (label4.Text == "2")
            {
                pictureBox5.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\2.png";
            }
            if (label4.Text == "3")
            {
                pictureBox5.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\3.png";
            }
            if (label4.Text == "4")
            {
                pictureBox5.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\4.png";
            }
            if (label4.Text == "5")
            {
                pictureBox5.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\5.png";
            }
            if (label4.Text == "6")
            {
                pictureBox5.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\6.png";
            }
            if (label4.Text == "7")
            {
                pictureBox5.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\7.png";
            }
            if (label4.Text == "8")
            {
                pictureBox5.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\8.png";
            }
            if (label4.Text == "9")
            {
                pictureBox5.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\9.png";
            }
            if (label4.Text == "10")
            {
                pictureBox5.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\j.png";
            }
           
            button5.Enabled = true;
        }

        private void btnpc_Click(object sender, EventArgs e)
        {
                int b1, b2, toplam;
                b1 = rastgele.Next(1, 11);
                b2 = rastgele.Next(1, 11);
                toplam = b1 + b2;

                label5.Text = b1.ToString();
                label6.Text = b2.ToString();
                lblpc.Text = toplam.ToString();

            if (toplam < 160)
            {
                int b3;
                b3 = rastgele.Next(1,11);
                label7.Text = b3.ToString();

                toplam = toplam + b3;
                lblpc.Text = toplam.ToString();
            }
            if (toplam < 160)
            {
                int b4;
                b4 = rastgele.Next(1, 11);
                label8.Text = b4.ToString();

                toplam = toplam + b4;
                lblpc.Text = toplam.ToString();
            }
            //5.kart
            if (label5.Text == "1")
            {
                pictureBox6.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\A.png";
            }
            if (label5.Text == "2")
            {
                pictureBox6.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\2.png";
            }
            if (label5.Text == "3")
            {
                pictureBox6.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\3.png";
            }
            if (label5.Text == "4")
            {
                pictureBox6.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\4.png";
            }
            if (label5.Text == "5")
            {
                pictureBox6.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\5.png";
            }
            if (label5.Text == "6")
            {
                pictureBox6.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\6.png";
            }
            if (label5.Text == "7")
            {
                pictureBox6.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\7.png";
            }
            if (label5.Text == "8")
            {
                pictureBox6.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\8.png";
            }
            if (label5.Text == "9")
            {
                pictureBox6.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\9.png";
            }
            if (label5.Text == "10")
            {
                pictureBox6.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\j.png";
            }
            //6.kart
            if (label6.Text == "1")
            {
                pictureBox7.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\A.png";
            }
            if (label6.Text == "2")
            {
                pictureBox7.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\2.png";
            }
            if (label6.Text == "3")
            {
                pictureBox7.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\3.png";
            }
            if (label6.Text == "4")
            {
                pictureBox7.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\4.png";
            }
            if (label6.Text == "5")
            {
                pictureBox7.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\5.png";
            }
            if (label6.Text == "6")
            {
                pictureBox7.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\6.png";
            }
            if (label6.Text == "7")
            {
                pictureBox7.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\7.png";
            }
            if (label6.Text == "8")
            {
                pictureBox7.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\8.png";
            }
            if (label6.Text == "9")
            {
                pictureBox7.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\9.png";
            }
            if (label6.Text == "10")
            {
                pictureBox7.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\j.png";
            }
            //7.kart
            if (label7.Text == "1")
            {
                pictureBox8.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\A.png";
            }
            if (label7.Text == "2")
            {
                pictureBox8.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\2.png";
            }
            if (label7.Text == "3")
            {
                pictureBox8.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\3.png";
            }
            if (label7.Text == "4")
            {
                pictureBox8.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\4.png";
            }
            if (label7.Text == "5")
            {
                pictureBox8.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\5.png";
            }
            if (label7.Text == "6")
            {
                pictureBox8.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\6.png";
            }
            if (label7.Text == "7")
            {
                pictureBox8.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\7.png";
            }
            if (label7.Text == "8")
            {
                pictureBox8.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\8.png";
            }
            if (label7.Text == "9")
            {
                pictureBox8.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\9.png";
            }
            if (label7.Text == "10")
            {
                pictureBox8.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\j.png";
            }
            //8.kar
            if (label8.Text == "1")
            {
                pictureBox9.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\A.png";
            }
            if (label8.Text == "2")
            {
                pictureBox9.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\2.png";
            }
            if (label8.Text == "3")
            {
                pictureBox9.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\3.png";
            }
            if (label8.Text == "4")
            {
                pictureBox9.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\4.png";
            }
            if (label8.Text == "5")
            {
                pictureBox9.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\5.png";
            }
            if (label8.Text == "6")
            {
                pictureBox9.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\6.png";
            }
            if (label8.Text == "7")
            {
                pictureBox9.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\7.png";
            }
            if (label8.Text == "8")
            {
                pictureBox9.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\8.png";
            }
            if (label8.Text == "9")
            {
                pictureBox9.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\9.png";
            }
            if (label8.Text == "10")
            {
                pictureBox9.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\j.png";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int otoplam, pctoplam;
            otoplam = Convert.ToInt32(lbloyuncu.Text);
            pctoplam = Convert.ToInt32(lblpc.Text);
            if (otoplam>pctoplam)
            {
                MessageBox.Show("KAZANDINIZ TEBRİKLER","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (otoplam == pctoplam)
            {
                MessageBox.Show("BERABERE... ÜCRETSİZ BİR OYUN HAKKI KAZANDINIZ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("KAYBETTİNİZ...","BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sayac = 0;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            lbloyuncu.Text = "";
            lblpc.Text = "";
            pictureBox2.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\arka2.jpg";
            pictureBox3.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\arka2.jpg";
            pictureBox4.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\arka2.jpg";
            pictureBox5.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\arka2.jpg";
            pictureBox6.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\arka2.jpg";
            pictureBox7.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\arka2.jpg";
            pictureBox8.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\arka2.jpg";
            pictureBox9.ImageLocation = @"D:\Eğitimlerim\Youtube -MURAT YÜCEDAĞ\100 Ders 1 ve 2 Projeler\BlackJackGame\BlackJackGame\images\arka2.jpg";
        }
    }
}
