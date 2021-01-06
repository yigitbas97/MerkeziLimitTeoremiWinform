using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerkeziLimitTeoremi
{
    class Orneklem : Populasyon
    {

        public List<Orneklem> Orneklemler { get; set; }
        public double VaryansEksiUc { get; set; }
        public double VaryansEksiIki { get; set; }
        public double VaryansEksiBir { get; set; }
        public double VaryansSifir { get; set; }
        public double VaryansArtiBir { get; set; }

        public double OrtalamaHesapla()
        {
            double toplam = 0;

            for (int i = 0; i < Degerler.Count; i++)
            {
                toplam += Degerler[i];
            }

            return (toplam / Degerler.Count); //ortalama
        }

        public double StandartSapmaHesapla()
        {
            double adim1 = 0;
            double adim2 = 0;

            for (int i = 0; i < Degerler.Count; i++)
            {
                adim1 += Math.Pow((Degerler[i] - this.Ortalama), 2); //Ortalama ile elemanların farkının kareleri toplamı
            }

            adim2 = Math.Sqrt(adim1 / (Degerler.Count - 1));


            return adim2; //standart sapma
        }

        public double VaryansHesaplaEksiUc()
        {
            double adim1 = 0;
            double adim2 = 0;

            for (int i = 0; i < Degerler.Count; i++)
            {
                adim1 += Math.Pow((Degerler[i] - this.Ortalama), 2); //Ortalama ile elemanların farkının kareleri toplamı
            }

            adim2 = adim1 / (Degerler.Count - 3);


            return adim2; // a=-3 icin varyans
        }

        public double VaryansHesaplaEksiIki()
        {
            double adim1 = 0;
            double adim2 = 0;

            for (int i = 0; i < Degerler.Count; i++)
            {
                adim1 += Math.Pow((Degerler[i] - this.Ortalama), 2); //Ortalama ile elemanların farkının kareleri toplamı
            }

            adim2 = adim1 / (Degerler.Count - 2);


            return adim2; // a=-2 icin varyans
        }

        public double VaryansHesaplaEksiBir()
        {
            double adim1 = 0;
            double adim2 = 0;

            for (int i = 0; i < Degerler.Count; i++)
            {
                adim1 += Math.Pow((Degerler[i] - this.Ortalama), 2); //Ortalama ile elemanların farkının kareleri toplamı
            }

            adim2 = adim1 / (Degerler.Count - 1);


            return adim2; // a=-1icin varyans
        }

        public double VaryansHesaplaSifir()
        {
            double adim1 = 0;
            double adim2 = 0;

            for (int i = 0; i < Degerler.Count; i++)
            {
                adim1 += Math.Pow((Degerler[i] - this.Ortalama), 2); //Ortalama ile elemanların farkının kareleri toplamı
            }

            adim2 = adim1 / (Degerler.Count);


            return adim2; // a=0 icin varyans
        }

        public double VaryansHesaplaArtiBir()
        {
            double adim1 = 0;
            double adim2 = 0;

            for (int i = 0; i < Degerler.Count; i++)
            {
                adim1 += Math.Pow((Degerler[i] - this.Ortalama), 2); //Ortalama ile elemanların farkının kareleri toplamı
            }

            adim2 = adim1 / (Degerler.Count + 1);


            return adim2; // a=+1 icin varyans
        }
    }
}
