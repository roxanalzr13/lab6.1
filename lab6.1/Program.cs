using System;

namespace lab6._1
{
    
    
        class Paralelipiped
        {
            static int GetLatime()
            {
                int lat;
                do
                {
                    Console.WriteLine("Introduceti latimea");
                    lat = int.Parse(Console.ReadLine());
                }
                while (lat < 0);
                return lat;

            }

            static int GetLungime()
            {
                int Lung;
                do
                {
                    Console.WriteLine("Introduceti Lungimea");
                    Lung = int.Parse(Console.ReadLine());
                }
                while (Lung < 0);
                return Lung;
            }
            static int GetInaltime()
            {
                int Inal;
                do
                {
                    Console.WriteLine("Introduceti Inatimea");
                    Inal = int.Parse(Console.ReadLine());
                }
                while (Inal < 0);
                return Inal;

            }
            static double Volum(int latime, int lungime, int inaltime)
            {
                return lungime * latime * inaltime;
            }
            static void VolumParalelipiped()
            {
                int latime;
                int lungime;
                int inaltime;
                double volum;
                Console.WriteLine("Introduceti dimensiunile paralelipipedului");
                inaltime = GetInaltime();
                latime = GetLatime();
                lungime = GetLungime();
                volum = Volum(lungime, latime, inaltime);
                Console.WriteLine("Volum:{0:F}", volum);
            }
            static void Main()
            {
                VolumParalelipiped();
                Console.WriteLine();

            }
        }
    }








