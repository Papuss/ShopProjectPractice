using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    class Elelmiszerbolt
    {
        private string nev;
        private string cim;
        private string tulajdonos;
        private List<Elelmiszer> elelmiszerpult;

        
        public Elelmiszerbolt(string nev, string cim, string tulajdonos, List<Elelmiszer> tejpult)
        {
            this.nev = nev;
            this.cim = cim;
            this.tulajdonos = tulajdonos;
            this.elelmiszerpult = tejpult;
        }

        public Elelmiszerbolt(string nev, string cim, string tulajdonos)
        {
            this.nev = nev;
            this.cim = cim;
            this.tulajdonos = tulajdonos;
        }

        public string getNev()
        {
            return nev;
        }

        public string getCim()
        {
            return cim;
        }

        public string getTulajdonos()
        {
            return tulajdonos;
        }

        public bool vanMegTej()
        {
            if (elelmiszerpult.Equals(null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool vanMegAdottAru(Elelmiszer o)
        {
            if (elelmiszerpult.Contains(o))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool vanMegSajt()
        {
            if (elelmiszerpult.Equals(null))
            {
                return false;
            }
            else
            {
                return true;

            }
        }

        public Elelmiszer vasarolTej(Elelmiszer m)
        {
            if (elelmiszerpult.Contains(m))
            {
                elelmiszerpult.Remove(m);
                return m;
            }
            return null;
        }

        public void feltoltElelmiszerrel(long vonalKod, long mennyiseg)
        {

            foreach (Elelmiszer item in elelmiszerpult)
            {
                if (item.getVonalkod().Equals(vonalKod))
                {
                    for (int i = 0; i < mennyiseg; i++)
                    {
                        elelmiszerpult.Add(item);
                    }
                }
            }

            
        }

        public void feltoltUjElelmiszerrel(Elelmiszer e, long mennyiseg, long ar)
        {
            for(int i = 0; i < mennyiseg; i++)
            {
                elelmiszerpult.Add(e);
            }
            
        }

        public void torolElelmiszert(long vonalkdo)
        {
            foreach (Elelmiszer item in elelmiszerpult)
            {
                if (item.getVonalkod().Equals(vonalkdo))
                {
                    elelmiszerpult.Remove(item);
                }
            }
        }

        public void vasarolElelmiszert(long vonalkod, long mennyiseg) 
        {
            foreach (Elelmiszer item in elelmiszerpult)
            {
                if (item.getVonalkod().Equals(vonalkod))
                {
                    for (int i = 0; i < mennyiseg; i++)
                    {
                        elelmiszerpult.Remove(item);
                    }
                    
                }
            }
        }
    }
}
