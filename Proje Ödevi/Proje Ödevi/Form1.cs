namespace Proje_Ödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] kullaniciadi = new string[2];
        string[] sifre = new string[2];
        Form2 girisislemi = new Form2();
       
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            kullaniciadi[0] = "demhat";
            sifre[0] = "1905";
            kullaniciadi[1] = "muhammed";
            sifre[1] = "1905";
              
           
        }
        private void button1_Click(object sender, EventArgs e) 
        {
            try
            {

            
            for (int i = 0; i <= kullaniciadi.Length; i++)
            {
                if (kullaniciadi[i] == textBox1.Text)
                {
                    if (sifre[i].ToString() == textBox2.Text)
                    {

                        MessageBox.Show("giriş işleminiz başarı ile sağlandı");
                        girisislemi.Show();
                        girisislemi.index2 = i;
                        break;
                    }
                    else if (sifre[i].ToString() != textBox2.Text)
                    {
                        MessageBox.Show("kullanıcı adı veya şifre hatalı ");
                        break;
                    }
                }



            }
            }
            catch (Exception)
            {
                MessageBox.Show("Giriş Bilgilerinizi Tekrar Kontrol Ediniz");
                textBox1.Clear();
                textBox2.Clear();
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                
                textBox2.PasswordChar = '\0';
            }
            
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}