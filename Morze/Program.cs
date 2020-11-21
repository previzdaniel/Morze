using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace Morze
{
    class Program
    {
        static List<kod> kodok = new List<kod>();
        static List<idezet> idezetek = new List<idezet>();

        static void beolvasKodok()
        {
            StreamReader be = new StreamReader("morzeabc.txt");

            be.ReadLine();
            while (!be.EndOfStream)
            {
                string[] adat = be.ReadLine().Split('\t');
                kodok.Add(new kod(Convert.ToChar(adat[0]), adat[1]));
            }
            be.Close();
        }
        
        static void beolvasIdezet()
        {
            StreamReader be = new StreamReader("morze.txt");

            while (!be.EndOfStream)
            {
                string[] adat = be.ReadLine().Split(';');
                idezetek.Add(new idezet(adat[0], adat[1]));
            }

            be.Close();
        }

        static void feladat3()
        {
            Console.WriteLine("3. feladat: A morze abc {0} db karakter kódját tartalmazza.", kodok.Count);
        }
        static void feladat4()
        {
            Console.Write("4. feladat: Kérek egy karaktert: ");
            char bekert = Convert.ToChar(Console.ReadLine());

            int i = 0;
            while (i < kodok.Count && kodok[i].Betu != bekert)
            {
                i++;
            }

            if (i < kodok.Count)
            {
                Console.WriteLine($"\t    A {bekert} karakter morze kódja: {kodok[i].Morzejel}");
            }
            else
            {
                Console.WriteLine("\t    Nem található a kódtárban ilyen karakter!");
            }
        }

        static string Morze2Szoveg(string kodolt)
        {
            StringBuilder sb = new StringBuilder();
            string kodolatlan = "";
            
            for (int x = 0; x < kodolt.Length; x++)
            {
                if (kodolt.Contains("   "))
                {
                    kodolt.Replace("   ", " ");
                }
            }
            
            for (int j = 0; j < kodolt.Length; j++)
            {
                string[] adat = kodolt.Split(' ');
                if (adat[j] == " ")
                {
                    sb.Append("");
                }
                else
                {
                    int i = 0;
                    while (i < kodok.Count && adat[j] != kodok[i].Morzejel)
                    {
                        i++;
                    }
                    sb.Append(kodok[i].Betu);
                }    
            }

            kodolatlan = Convert.ToString(sb);
            return kodolatlan;
        }

        static void Main(string[] args)
        {
            beolvasKodok();
            beolvasIdezet();

            feladat3();
            feladat4();

            Morze2Szoveg(".-   .--.-   ..   ...   --..   -   ---   -   .   .-..   ..-..   ...   --..   ");

            

            Console.ReadKey();
        }
    }
}
