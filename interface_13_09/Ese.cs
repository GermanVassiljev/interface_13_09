using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_13_09
{
    internal class Ese
    {
        private string nimetus;
        private int punktide_arv;

        public Ese(string nimetus, int punktide_arv)
        {
            this.nimetus = nimetus;
            this.punktide_arv = punktide_arv;
        }
        public int punktideArv()
        {
            return punktide_arv;
        }
        public string info()
        {
            return nimetus;
        }
    }
}
