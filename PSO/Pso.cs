using System;
using System.Collections.Generic;


namespace PSO
{
    internal class Pso
    {
        Parcacik[] eniyikonum;
        Parcacik eniyicozum;

        double parcacikSayisi;
        double jenerasyonSayisi;
        double c1;
        double c2;

        public List<double> uygunlukDegerleri = new List<double>();

        public static readonly Object kilitlemeNesnesi = new Object();
        public static readonly Random rnd = new Random();

        int altSinir = -5;
        int ustSinir = 5;

        Parcacik[] parcacik;

        public Pso(double parcacikSayisi, double jenerasyonSayisi, double c1, double c2)
        {
            this.parcacikSayisi = parcacikSayisi;
            this.jenerasyonSayisi = jenerasyonSayisi;
            this.c1 = c1;
            this.c2 = c2;

            parcacik = new Parcacik[(int)parcacikSayisi];

            for (int i = 0; i < parcacikSayisi; i++)
            {
                parcacik[i] = new Parcacik(altSinir, ustSinir);
            }

            eniyikonum = new Parcacik[(int)parcacikSayisi];

            for (int i = 0; i < parcacikSayisi; i++)
            {
                eniyikonum[i] = parcacik[i];
            }

            eniyicozum = parcacik[0];
            uygunlukDegerleri.Add(eniyicozum.uygunlukDegeri);

            for (int i = 0; i < jenerasyonSayisi; i++)
            {
                for (int j = 0; j < parcacikSayisi; j++)
                {
                    if (Math.Abs(parcacik[j].uygunlukDegeri) < Math.Abs(eniyikonum[j].uygunlukDegeri))
                    {
                        eniyikonum[j].x1 = parcacik[j].x1;
                        eniyikonum[j].x2 = parcacik[j].x2;
                        eniyikonum[j].v1 = parcacik[j].v1;
                        eniyikonum[j].v2 = parcacik[j].v2;
                    }
                }

                for (int j = 0; j < eniyikonum.Length; j++)
                {
                    if (Math.Abs(eniyicozum.uygunlukDegeri) > Math.Abs(eniyikonum[j].uygunlukDegeri))
                    {
                        eniyicozum.x1 = eniyikonum[j].x1;
                        eniyicozum.x2 = eniyikonum[j].x2;
                        eniyicozum.v1 = eniyikonum[j].v1;
                        eniyicozum.v2 = eniyikonum[j].v2;
                        eniyicozum.uygunlukDegeri = eniyikonum[j].uygunlukDegeri;
                    }
                }
                uygunlukDegerleri.Add(eniyicozum.uygunlukDegeri);


                double randomSayi1 = RandomSayi(0, 1);
                double randomSayi2 = RandomSayi(0, 1);

                for (int j = 0; j < parcacikSayisi; j++)
                {

                    parcacik[j].v1 = parcacik[j].v1 +
                                    c1 * randomSayi1 * (eniyikonum[j].x1 - parcacik[j].x1)
                                    + c2 * randomSayi2 * (eniyicozum.x1 - parcacik[j].x1);

                   

                    parcacik[j].v2 = parcacik[j].v2 +
                                    c1 * randomSayi1 * (eniyikonum[j].x2 - parcacik[j].x2)
                                    + c2 * randomSayi2 * (eniyicozum.x2 - parcacik[j].x2);

                    parcacik[j].x1 += parcacik[j].v1;
                    parcacik[j].x2 += parcacik[j].v2;

                    parcacik[j].uygunlukDegeri = parcacik[j].uygunlukDegeriHesapla(parcacik[j].x1, parcacik[j].x2);
                }

            }
        }

        public double RandomSayi()
        {
            lock (kilitlemeNesnesi)
            {
                return rnd.NextDouble() * (ustSinir - altSinir) + altSinir;
            }
        }

        public double RandomSayi(double xUst, double yAlt)
        {
            lock (kilitlemeNesnesi)
            {
                return rnd.NextDouble() * (xUst - yAlt) + yAlt;
            }
        }
    }
}
