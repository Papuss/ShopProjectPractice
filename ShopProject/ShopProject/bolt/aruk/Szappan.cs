using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject.bolt.aruk
{
    class Szappan : Aru
    {
        private long vonalkod;
        private string gyarto;

        public Szappan(long vonalkod, string gyarto) : base(vonalkod,gyarto)
        {
            this.vonalkod = vonalkod;
            this.gyarto = gyarto; 
        }

        protected long Vonalkod1
        {
            get
            {
                return vonalkod;
            }

            set
            {
                vonalkod = value;
            }
        }

        protected string Gyarto
        {
            get
            {
                return gyarto;
            }

            set
            {
                gyarto = value;
            }
        }

     
    }
}
