using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerkeziLimitTeoremi
{
    class Populasyon
    {
        public List<int> Degerler { get; set; }

        public double Ortalama { get; set; }

        public double StandartSapma { get; set; }

        public double Varyans { get; set; }


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
                adim1 += Math.Pow((Degerler[i] - this.Ortalama),2); //Ortalama ile elemanların farkının kareleri toplamı
            }

            adim2 = Math.Sqrt(adim1 / Degerler.Count);


            return adim2; //standart sapma
        }

        public double VaryansHesapla()
        {
            return Math.Pow(this.StandartSapma, 2); //Popülasyon Varyansı standart sapmanın karesine eşittir
        }
    }
}
