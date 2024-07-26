using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        string connection;
        public Form1()
        {
            this.Opacity = 0.8;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sql connectinon baðlantýsý tanýmladým
            this.connection = @"Server=localhost;Database=eczane;Trusted_Connection=True;";

            if (textBox1.Text!="" || textBox2.Text!="")
            {
                using (var baglan = new SqlConnection(this.connection))
                {
                    string kullaniciadý = textBox1.Text;
                    //kullanýcý adýný textboxdan alýp sql sorgusunda sorgulattým
                    using (var komut = new SqlCommand($"SELECT kullaniciSifre FROM kullanicilar WHERE kullaniciAd = '{kullaniciadý}' ", baglan))
                    {
                        if (baglan.State == ConnectionState.Closed)
                        {
                            baglan.Open();
                        }
                        SqlDataReader datareader = komut.ExecuteReader();
                        if (datareader.Read())
                        {
                            try
                            {
                                //kullanýcý adýnýn satýrýndaki þifre deðeri þifre textboxýna girilen deðer ile eþleþirse kullanýcý giriþini onayladým
                                if (textBox2.Text==datareader.GetString(0))
                                {
                                    MessageBox.Show("Baþarýlý þekilde giriþ yapýldý");
                                    this.Hide();
                                    Form2 form2 = new Form2();
                                    form2.Show();
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Kullanýcý bilgileri eþleþmiyor. Giriþ bilgilerinizi kontrol ediniz.");
                                }

                            }
                            catch (Exception hata)
                            {
                                MessageBox.Show("Hata Mesajý:" + hata.ToString(), "Hata:" + hata.Message);
                            }
                        }
                        if (baglan.State == ConnectionState.Open)
                        {
                            baglan.Close();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Lütfen Kullanýcý adýnýzý veya þifrenizi giriniz.");
            }
        }
    }
}
