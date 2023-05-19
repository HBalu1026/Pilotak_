using System;
using System.IO;
using ConsoleApp7;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("pilotak.csv");
            List<Pilota> PilotaList = new List<Pilota>();
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] sorok = sr.ReadLine().Split(";");
                if (sorok[3] == "")
                {
                    Pilota sor = new Pilota(sorok[0], sorok[1], sorok[2], int.MaxValue);
                    PilotaList.Add(sor);
                }
                else
                {
                    Pilota sor = new Pilota(sorok[0], sorok[1], sorok[2], Convert.ToInt32(sorok[3]));
                    PilotaList.Add(sor);
                }
            }

            //3.
            Console.WriteLine("3 Feladat: " + PilotaList.Count());

            //4.
            Console.WriteLine("4 Feladat: " + PilotaList[PilotaList.Count() - 1].Nev);

            //5
            for (int i = 0; i < PilotaList.Count(); i++)
            {
                if (Convert.ToInt32(PilotaList[i].Datum.Split(".")[0]) < 1901)
                {
                    Console.WriteLine("\t" + PilotaList[i].Nev + "(" + PilotaList[i].Datum + ")");
                }
            }






            sr.Close();
        }
    }
}