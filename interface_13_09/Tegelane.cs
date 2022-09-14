using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_13_09
{
    internal class Tegelane : IUksus, IComparable<Tegelane>
    {
        private string nimi;

        List<Ese> nimekiri;
        protected double m_value = 0.0;

        public Tegelane(string nimi)
        {
            this.nimi = nimi;
        }

        public void lisaEse(Ese uusEse)
        {
            nimekiri.Add(uusEse);
            Console.WriteLine(nimekiri);
        }
        public int punktideArv()
        {
            int sum = 0;
            foreach(Ese uusEse in nimekiri)
            {
                sum+=uusEse.punktideArv();
            }
            return sum;
        }
        public string info()
        {
            string tegelase_info;
            tegelase_info = nimi + ", " + nimekiri.Count() + ", " + punktideArv();
            return tegelase_info;
        }
        public void väljastaEsemed()
        {
            int x=0;
            foreach(Ese uusEse in nimekiri)
            {
                Console.WriteLine(uusEse.info());
            }
        }
        public int CompareTo(Tegelane? other)
        {
            if (other == null) return 1;
            return this.nimekiri.Count - other.EseKogus();
        }
        private int EseKogus()
        {
            return this.nimekiri.Count;
        }
    }
}
