namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        int secim=0;
        double sayi1, sayi2, sonuc;
       

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
          


        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            sayi2 =double.Parse(textBox1.Text);
            if(secim==1)
            {
                sonuc = sayi1 + sayi2;
                textBox1.Text = sonuc.ToString();
            }
            else if(secim==2)
            {
                sonuc = sayi1 - sayi2;
                textBox1.Text = sonuc.ToString();
            }
            else if(secim==3)
            {
                sonuc = sayi1 * sayi2;
                textBox1.Text = sonuc.ToString();
            }
            else if(secim==4)
            {
                sonuc = sayi1 / sayi2;
                textBox1.Text = sonuc.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.IndexOf(",")<1)
            {
                textBox1.Text += ",";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sayi1=double.Parse(textBox1.Text);  
            secim = 1;
            textBox1.Text = "0";    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            secim = 4;
            textBox1.Text = "0";
        }

        private void iki_Click(object sender, EventArgs e)
        {
            
        }

        private void Butonlar(object sender, EventArgs e)
        {
            if(textBox1.Text=="0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + ((Button)sender).Text; //Button sender burada==butonlarýn üzerindeki sayýlarýn ekrana yazýlmasýnda yardýmcý oldu

        }

        private void btncýkartma_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            secim = 2;
            textBox1.Text = "0";
        }

        private void btncarpma_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            secim = 3;
            textBox1.Text = "0";
        }

        private void btnters_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = (-1 * double.Parse(textBox1.Text)).ToString();

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
                 
        }
    }
}