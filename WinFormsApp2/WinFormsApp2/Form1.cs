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
            //sql connectinon ba�lant�s� tan�mlad�m
            this.connection = @"Server=localhost;Database=eczane;Trusted_Connection=True;";

            if (textBox1.Text!="" || textBox2.Text!="")
            {
                using (var baglan = new SqlConnection(this.connection))
                {
                    string kullaniciad� = textBox1.Text;
                    //kullan�c� ad�n� textboxdan al�p sql sorgusunda sorgulatt�m
                    using (var komut = new SqlCommand($"SELECT kullaniciSifre FROM kullanicilar WHERE kullaniciAd = '{kullaniciad�}' ", baglan))
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
                                //kullan�c� ad�n�n sat�r�ndaki �ifre de�eri �ifre textbox�na girilen de�er ile e�le�irse kullan�c� giri�ini onaylad�m
                                if (textBox2.Text==datareader.GetString(0))
                                {
                                    MessageBox.Show("Ba�ar�l� �ekilde giri� yap�ld�");
                                    this.Hide();
                                    Form2 form2 = new Form2();
                                    form2.Show();
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Kullan�c� bilgileri e�le�miyor. Giri� bilgilerinizi kontrol ediniz.");
                                }

                            }
                            catch (Exception hata)
                            {
                                MessageBox.Show("Hata Mesaj�:" + hata.ToString(), "Hata:" + hata.Message);
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
                MessageBox.Show("L�tfen Kullan�c� ad�n�z� veya �ifrenizi giriniz.");
            }
        }
    }
}
