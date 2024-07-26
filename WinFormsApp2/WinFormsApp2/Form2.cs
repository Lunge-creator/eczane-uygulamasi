using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        string connection;
        public Form2()
        {
            this.connection = @"Server=localhost;Database=eczane;Trusted_Connection=True;";
            InitializeComponent();
            this.Opacity = 0.8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textbox'a girilen değer ile databaseden stok adedi verisini getirdim
            string barkod = textBoxBarkod.Text.ToString();
            using (var baglan = new SqlConnection(this.connection))
            {
                using (var komut = new SqlCommand($"SELECT urunStok FROM ilac where barkod = '{barkod}'", baglan))
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
                            textBoxStok.Text = "Stok adedi: " + datareader[0].ToString();
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show("Hata Mesajı:" + hata.ToString(), "Hata:" + hata.Message);
                        }
                    }
                    if (baglan.State == ConnectionState.Open)
                    {
                        baglan.Close();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //görüntüle butonuna basıldığında ilaç verilerini datagridwiev'e aktardım
            using (var baglan = new SqlConnection(this.connection))
            {
                using (var komut = new SqlDataAdapter("SELECT * FROM ilac", baglan))
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }
                    try
                    {
                        var Builder = new SqlCommandBuilder(komut);
                        var myDataSet = new DataSet();
                        komut.Fill(myDataSet);
                        dataGridView1.DataSource = myDataSet.Tables[0];
                        dataGridView1.Columns[0].Width = 50; dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Hata Mesajı:" + hata.ToString(), "Hata:" + hata.Message);
                    }
                    if (baglan.State == ConnectionState.Open)
                    {
                        baglan.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ekle butonuna basıldığına girilen verileri database'e aktardım
            if (textBoxad.Text != "" || textBoxtur.Text != "" || textBoxFiyat.Text != "" || textBoxSt.Text != "" || textBoxBark.Text != "")
            {
                using (var baglan = new SqlConnection(this.connection))
                {
                    using (var komut = new SqlCommand($"insert into ilac(urunAd,urunTur,urunFiyat,urunStok,urungecer,urunKayıt,barkod) values(@urunAd,@urunTur,@urunFiyat,@urunStok,@urungecer,@urunKayıt,@barkod)", baglan))
                    {
                        if (baglan.State == ConnectionState.Closed)
                        {
                            baglan.Open();
                        }
                        try
                        {
                            komut.CommandType = CommandType.Text;
                            komut.Parameters.AddWithValue("@urunAd", textBoxad.Text);
                            komut.Parameters.AddWithValue("@urunTur", textBoxtur.Text);
                            komut.Parameters.AddWithValue("@urunFiyat", textBoxFiyat.Text);
                            komut.Parameters.AddWithValue("@urunStok", textBoxSt.Text);
                            komut.Parameters.AddWithValue("@barkod", textBoxBark.Text);
                            komut.Parameters.AddWithValue("@urungecer", dateTimePicker1.Value);
                            komut.Parameters.AddWithValue("@urunKayıt", dateTimePicker2.Value);

                            komut.ExecuteNonQuery();
                            MessageBox.Show("Başarılı bir şekilde ilac eklendi.");

                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show("Hata Mesajı:" + hata.ToString(), "Hata:" + hata.Message);
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
                MessageBox.Show("Bütün bilgileri girmelisiniz.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview'de herhangi bir satıra tıklandığında verileri textoxlara aktardım
            dataGridView1.CurrentRow.Selected = true;
            textBoxad.Text = dataGridView1.Rows[e.RowIndex].Cells["urunAd"].Value.ToString();
            textBoxtur.Text = dataGridView1.Rows[e.RowIndex].Cells["urunTur"].Value.ToString();
            textBoxFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells["urunFiyat"].Value.ToString();
            textBoxSt.Text = dataGridView1.Rows[e.RowIndex].Cells["urunStok"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["urungecer"].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells["urunKayıt"].Value.ToString();
            textBoxBark.Text = dataGridView1.Rows[e.RowIndex].Cells["barkod"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textboxdaki barkod numarasına göre sql tablosundaki verileri sildirttim
            using (var baglan = new SqlConnection(this.connection))
            {
                if (textBoxBark.Text != "")
                {
                    string silinecek = textBoxBark.Text.ToString();

                    using (var komut = new SqlCommand($"SELECT barkod FROM ilac where barkod ='{silinecek}'", baglan))
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
                                if (textBoxBark.Text == datareader.GetString(0))
                                {
                                    datareader.Close();

                                    using (var komut2 = new SqlCommand($"DELETE FROM ilac WHERE barkod='{silinecek}'", baglan))
                                    {
                                        if (baglan.State == ConnectionState.Closed)
                                        {
                                            baglan.Open();
                                        }
                                        try
                                        {
                                            komut2.ExecuteNonQuery();
                                            MessageBox.Show("İlaç başarıyla silinmiştir.");
                                        }
                                        catch (Exception hata)
                                        {
                                            MessageBox.Show("Hata Mesajı:" + hata.ToString(), "Hata:" + hata.Message);
                                        }
                                        if (baglan.State == ConnectionState.Open)
                                        {
                                            baglan.Close();
                                        }
                                    }
                                }
                                
                            }
                            catch (Exception hata)
                            {
                                MessageBox.Show("Hata Mesajı:" + hata.ToString(), "Hata:" + hata.Message);
                            }
                            if (baglan.State == ConnectionState.Open)
                            {
                                baglan.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bu barkoda ait bir ilaç yoktur!!!");
                        }
                    }

                    
                }
                else
                {
                    MessageBox.Show("İlaç Silmek için barkod kodu girmelisiniz ");
                }
            }
        }
    }
}
