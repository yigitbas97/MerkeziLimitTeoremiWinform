using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerkeziLimitTeoremi
{
    class TumOrneklemler : Orneklem
    {
        public double OrtalamaHesapla()
        {
            double temp = 0;

            for (int i = 0; i < Orneklemler.Count; i++)
            {
                temp += Orneklemler[i].Ortalama;
            }

            return (temp / Orneklemler.Count);
        }

        public double StandartSapmaHesapla()
        {
            double temp = 0;

            for (int i = 0; i < Orneklemler.Count; i++)
            {
                temp += Orneklemler[i].StandartSapma;
            }

            return (temp / Orneklemler.Count);
        }

        public double VaryansHesaplaEksiUc()
        {
            double temp = 0;

            for (int i = 0; i < Orneklemler.Count; i++)
            {
                temp += Orneklemler[i].VaryansEksiUc;
            }

            return (temp / Orneklemler.Count);
        }

        public double VaryansHesaplaEksiIki()
        {
            double temp = 0;

            for (int i = 0; i < Orneklemler.Count; i++)
            {
                temp += Orneklemler[i].VaryansEksiIki;
            }

            return (temp / Orneklemler.Count);
        }

        public double VaryansHesaplaEksiBir()
        {
            double temp = 0;

            for (int i = 0; i < Orneklemler.Count; i++)
            {
                temp += Orneklemler[i].VaryansEksiBir;
            }

            return (temp / Orneklemler.Count);
        }

        public double VaryansHesaplaSifir()
        {
            double temp = 0;

            for (int i = 0; i < Orneklemler.Count; i++)
            {
                temp += Orneklemler[i].VaryansSifir;
            }

            return (temp / Orneklemler.Count);
        }

        public double VaryansHesaplaArtiBir()
        {
            double temp = 0;

            for (int i = 0; i < Orneklemler.Count; i++)
            {
                temp += Orneklemler[i].VaryansArtiBir;
            }

            return (temp / Orneklemler.Count);
        }

    }
}
