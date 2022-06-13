using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace Proje_Ödevi
{
    public partial class Form2 : Form
    {
        public int index2;
        int[] cuzdan = new int[2];
        int islem;


        public Form2()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e) // Çıkış
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)  // Para Yatırma
        {
            button5onayla.Enabled = true;
            button6temizle.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            button7gonder.Enabled = false;
            islem = 1;
        }

        private void button2_Click(object sender, EventArgs e)  // Para Çekme
        {
            button5onayla.Enabled = true;
            button6temizle.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled=false;
            button7gonder.Enabled=false;
            islem = 2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button5onayla.Enabled = false;
            button6temizle.Enabled = false;
            button7gonder.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            label3.Text = "0";
            
        }

        private void button4_Click(object sender, EventArgs e) // Bakiye Öğrenme
        {

            label3.Text = cuzdan[index2].ToString();
        }

        private void button5_Click(object sender, EventArgs e) // Onayla
        {
            try
            {
            DialogResult tamam = MessageBox.Show("Emin misiniz?", "Uyarı!!!", MessageBoxButtons.YesNo);
            if (tamam == DialogResult.Yes)
            {
                if (islem == 1)
                {
                    cuzdan[index2] = cuzdan[index2] + Convert.ToInt32(textBox1.Text);
                    MessageBox.Show("İşlem başarı ile tamamlandı.");

                }
                else if (islem == 2)
                {
                    cuzdan[index2] = cuzdan[index2] - Convert.ToInt32(textBox1.Text);
                    MessageBox.Show("İşlem başarı ile tamamlandı.");
                }
                textBox1.Clear();
                button5onayla.Enabled = false;
                button6temizle.Enabled = false;
                textBox1.Enabled = false;

            }
            else if (tamam == DialogResult.No)
            {
                MessageBox.Show("işlem iptal edildi");
            }
            }
            catch (Exception)
            {
                textBox1.Clear();
                MessageBox.Show("Lütfen Girdiğiniz Tutarı Kontrol Ediniz ");
                
            }
        }

        private void button6_Click(object sender, EventArgs e)  // Temizle
        {
            textBox1.Clear();
        }

        private void button7_Click(object sender, EventArgs e) // Gönder
        {
            try
            {

            
            int id = Convert.ToInt32(textBox2.Text);
            if (index2 == id)
            {
                MessageBox.Show("kendinize para gönderemezsiniz!!");
            }
            else if (index2 != id)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("gonderilecek tutar giriniz");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("id giriniz");
                }
                else if (textBox1.Text != "" && textBox2.Text != "")
                {
                    int tutar = Convert.ToInt32(textBox1.Text);
                    cuzdan[index2] = cuzdan[index2] - tutar;
                    cuzdan[id] = cuzdan[id] + tutar;
                    textBox2.Enabled = false;
                    textBox1.Enabled = false;
                    button7gonder.Enabled = false;
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show("işlem tamamlandı");
                }

               
        }
            }
            catch (Exception)
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Giridiğiniz id ve Tutarı Kontrol Ediniz");
                
            }
            
            
        }

        private void button8_Click(object sender, EventArgs e) // Para Gönderme
        {  
            button6temizle.Enabled = true;
            button5onayla.Enabled = false;
            button7gonder.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            MessageBox.Show("Lütfen Gönderilecek Kişinin ID numarasını giriniz... (0)demhat (1)muhammed");
        }
        
      }
    }
