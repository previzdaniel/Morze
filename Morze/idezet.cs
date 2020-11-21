using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morze
{
    class idezet
    {
        private string szerzo;

        public string Szerzo
        {
            get { return szerzo; }
        }

        private string szoveg;

        public string Szoveg
        {
            get { return szoveg; }
        }

        public idezet(string szerzo, string szoveg)
        {
            this.szerzo = szerzo;
            this.szoveg = szoveg;
        }
    }
}
