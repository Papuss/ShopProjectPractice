using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    class BoltBejegyzes
    {
        private Elelmiszer e;
        private long mennyiseg;
        private long ar;

        internal Elelmiszer E
        {
            get
            {
                return e;
            }

            set
            {
                e = value;
            }
        }

        public long Mennyiseg
        {
            get
            {
                return mennyiseg;
            }

            set
            {
                mennyiseg = value;
            }
        }

        public long Ar
        {
            get
            {
                return ar;
            }

            set
            {
                ar = value;
            }
        }

        public BoltBejegyzes(Elelmiszer e, long mennyiseg, long ar)
        {
            this.E = e;
            this.Mennyiseg = mennyiseg;
            this.Ar = ar;
        }

        public void addMennyiseg(int mennyiseg)
        {
            mennyiseg += mennyiseg;
        }
       
        public void levonMennyiseg(int mennyiseg)
        {
            mennyiseg -= mennyiseg;
        }

    }
}
