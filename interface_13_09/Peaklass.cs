using interface_13_09;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    internal static class Peaklass
    {
        public static List<Ese> LoeEsemed()
        {
            List<Ese> nimekiri = new List<Ese>();
            using (StreamReader sr=new StreamReader(@"../../../Andmed.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] rida = sr.ReadLine().Split(";");
                    Ese uusEse=new Ese(rida[0].ToString(), Int32.Parse(rida[1]));
                    nimekiri.Add(uusEse);
                }
            }
            return nimekiri;
        }

        static Tegelane[] Mangijad(int tegelasekogus)
        {
            if (tegelasekogus < 2) throw new Exception();
            Tegelane[] mangijad = new Tegelane[tegelasekogus];
            for (int i = 0; i < tegelasekogus; i++)
            {
                Tegelane mangija = new Tegelane(Mangijate_loetelu());
                mangija[i] = mangija;
            }
            List<Ese> nimekiri = LoeEsemed();
            if (nimekiri.Count <= 0) throw new ArgumentOutOfRangeException();
            foreach (Tegelane m in mangijad)
            {
                Shuffle(nimekiri);
                int nimekiri_kogus = rnd.Next(2, 10);
                for (int i = 0; i< nimekiri_kogus; i++)
                {
                    m.lisaEse(nimekiri[i]);
                }

            }
            return mangijad;
        }
        static public void Uus_mang(int kogus)
        {
            Tegelane[] mangijad = Mangijad(kogus);
            Mang mang = new Mang(mangijad);
            foreach (Tegelane v in mang.SuurimaEsemeteArvuga())
            {
                Console.WriteLine(v.info());
            }
            Tegelane voitja = mang.suurimaPunktideArvuga();
            Console.WriteLine(voitja.info());
            Console.WriteLine("Mängijal olid järgmised esed: ");
            voitja.väljastaEsemed();

        }
    }
}
