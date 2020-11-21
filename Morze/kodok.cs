using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morze
{
    class kod
    {
        private char betu;

        public char Betu
        {
            get { return betu; }
        }

        private string morzejel;

        public string Morzejel
        {
            get { return morzejel; }
        }



        public kod(char betu, string morzejel)
        {
            this.betu = betu;
            this.morzejel = morzejel;
        }
    }
}
