using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerkeziLimitTeoremi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        Populasyon populasyon = new Populasyon();
        List<Orneklem> orneklemlistesi = new List<Orneklem>();
        TumOrneklemler tum_orneklemler = new TumOrneklemler();

        int populasyonsayisi = 0;
        int orneklemelemansayisi = 0;

        private void PopulasyonUret_Click(object sender, EventArgs e)
        {
            try
            {
                populasyonsayisi = Convert.ToInt32(textBox1.Text);

                if (populasyonsayisi > 0)
                {
                    List<int> liste = new List<int>();

                    for (int i = 0; i < populasyonsayisi; i++)
                    {
                        liste.Add(random.Next(0, 101));
                    }
                    populasyon.Degerler = liste;
                    populasyon.Ortalama = populasyon.OrtalamaHesapla();
                    populasyon.StandartSapma = populasyon.StandartSapmaHesapla();
                    populasyon.Varyans = populasyon.VaryansHesapla();

                    label26.Text = populasyonsayisi.ToString();
                    label27.Text = populasyon.Ortalama.ToString("0.##");
                    label28.Text = populasyon.StandartSapma.ToString("0.##");
                    label29.Text = populasyon.Varyans.ToString("0.##");
                }

                else
                {
                    MessageBox.Show("Popülasyon Sayısı Belirtilmemiş");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void OrneklemUret_Click(object sender, EventArgs e)
        {
            try
            {
                if (populasyonsayisi > 0)
                {
                    orneklemelemansayisi = Convert.ToInt32(textBox2.Text);

                    if (orneklemelemansayisi > 0)
                    {
                        Orneklem guncel_orneklem = new Orneklem();
                        List<int> liste = new List<int>();
                        

                        for (int i = 0; i < orneklemelemansayisi; i++)
                        {
                            liste.Add(populasyon.Degerler[random.Next(0, populasyonsayisi)]);
                        }

                        guncel_orneklem.Degerler = liste;
                        guncel_orneklem.Ortalama = guncel_orneklem.OrtalamaHesapla();
                        guncel_orneklem.StandartSapma = guncel_orneklem.StandartSapmaHesapla();
                        guncel_orneklem.VaryansEksiUc = guncel_orneklem.VaryansHesaplaEksiUc();
                        guncel_orneklem.VaryansEksiIki = guncel_orneklem.VaryansHesaplaEksiIki();
                        guncel_orneklem.VaryansEksiBir = guncel_orneklem.VaryansHesaplaEksiBir();
                        guncel_orneklem.VaryansSifir = guncel_orneklem.VaryansHesaplaSifir();
                        guncel_orneklem.VaryansArtiBir = guncel_orneklem.VaryansHesaplaArtiBir();

                        label30.Text = orneklemelemansayisi.ToString();
                        label31.Text = guncel_orneklem.Ortalama.ToString("0.##");
                        label32.Text = guncel_orneklem.StandartSapma.ToString("0.##");
                        label33.Text = guncel_orneklem.VaryansEksiUc.ToString("0.##");
                        label34.Text = guncel_orneklem.VaryansEksiIki.ToString("0.##");
                        label35.Text = guncel_orneklem.VaryansEksiBir.ToString("0.##");
                        label36.Text = guncel_orneklem.VaryansSifir.ToString("0.##");
                        label37.Text = guncel_orneklem.VaryansArtiBir.ToString("0.##");

                        orneklemlistesi.Add(guncel_orneklem);
                        tum_orneklemler.Orneklemler = orneklemlistesi;
                        tum_orneklemler.Ortalama = tum_orneklemler.OrtalamaHesapla();
                        tum_orneklemler.StandartSapma = tum_orneklemler.StandartSapmaHesapla();
                        tum_orneklemler.VaryansEksiUc = tum_orneklemler.VaryansHesaplaEksiUc();
                        tum_orneklemler.VaryansEksiIki = tum_orneklemler.VaryansHesaplaEksiIki();
                        tum_orneklemler.VaryansEksiBir = tum_orneklemler.VaryansHesaplaEksiBir();
                        tum_orneklemler.VaryansSifir = tum_orneklemler.VaryansHesaplaSifir();
                        tum_orneklemler.VaryansArtiBir = tum_orneklemler.VaryansHesaplaArtiBir();

                        label38.Text = tum_orneklemler.Orneklemler.Count.ToString();
                        label39.Text = tum_orneklemler.Ortalama.ToString("0.##");
                        label40.Text = tum_orneklemler.StandartSapma.ToString("0.##");
                        label41.Text = tum_orneklemler.VaryansEksiUc.ToString("0.##");
                        label42.Text = tum_orneklemler.VaryansEksiIki.ToString("0.##");
                        label43.Text = tum_orneklemler.VaryansEksiBir.ToString("0.##");
                        label44.Text = tum_orneklemler.VaryansSifir.ToString("0.##");
                        label45.Text = tum_orneklemler.VaryansArtiBir.ToString("0.##");
                    }

                    else
                    {
                        MessageBox.Show("Örneklem Sayısı Belirtilmemiş");
                    }
                }
                else
                {
                    MessageBox.Show("Populasyon Sayısı Belirtilmemiş");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Tümünü temizle
        private void button3_Click(object sender, EventArgs e)
        {
            populasyonsayisi = 0;
            orneklemelemansayisi = 0;
            populasyon = new Populasyon();
            orneklemlistesi = new List<Orneklem>();
            tum_orneklemler = new TumOrneklemler();

            label26.Text = populasyonsayisi.ToString();
            label27.Text = "";
            label28.Text = "";
            label29.Text = "";

            label30.Text = orneklemelemansayisi.ToString();
            label31.Text = "";
            label32.Text = "";
            label33.Text = "";
            label34.Text = "";
            label35.Text = "";
            label36.Text = "";
            label37.Text = "";

            label38.Text = "";
            label39.Text = "";
            label40.Text = "";
            label41.Text = "";
            label42.Text = "";
            label43.Text = "";
            label44.Text = "";
            label45.Text = "";

            textBox1.Clear();
            textBox2.Clear();

        }
    }
}
