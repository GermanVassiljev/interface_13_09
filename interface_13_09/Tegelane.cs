using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_13_09
{
    internal class Tegelane
    {
        private string nimi;

        List<string> nimekiri=new List<string>();

        public Tegelane(string nimi)
        {
            this.nimi = nimi;
        }

        public void lisaEse( string uusEse, List<string> nimekiri)
        {
            nimekiri.Add(uusEse);
        }
        public int punktideArv()
        {
            return 
        }
    }
}
