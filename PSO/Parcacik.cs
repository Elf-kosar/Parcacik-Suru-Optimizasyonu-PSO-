using System;


namespace PSO
{
    internal class Parcacik
    {
        double altSinir;
        double ustSinir;

        public double x1;
        public double x2;

        public double uygunlukDegeri;

        public double v1;
        public double v2;

        public static readonly Object kilitlemeNesnesi = new Object();
        public static readonly Random rnd = new Random();

        public Parcacik(double altSinir, double ustSinir)
        {
            this.altSinir = altSinir;
            this.ustSinir = ustSinir;

            x1 = RandomSayi();
            x2 = RandomSayi();
            uygunlukDegeri = sixHumpCamel(x1, x2);

        }

        public double sixHumpCamel(double x1, double x2)
        {
            return (4 * Math.Pow(x1, 2)) - (2 * Math.Pow(x1, 4)) + ((1 / 3) * Math.Pow(x1, 6)) + (x1 * x2) - 4 * Math.Pow(x2, 2) + 4 * Math.Pow(x2, 4);
        }

        public double RandomSayi()
        {
            lock (kilitlemeNesnesi)
            {
                return rnd.NextDouble() * (ustSinir - altSinir) + altSinir;
            }
        }

        public double uygunlukDegeriHesapla(double x1, double x2)
        {
            return sixHumpCamel(x1, x2);
        }
    }
}
