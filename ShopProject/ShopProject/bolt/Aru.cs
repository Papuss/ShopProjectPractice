using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    class Aru
    {
        private long vonalkod;
        private string gyarto;

        protected long Vonalkod
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

        public Aru(long vonalkod, string gyarto)
        {
            this.Vonalkod = vonalkod;
            this.Gyarto = gyarto;
        }
    }
}
