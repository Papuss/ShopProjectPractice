using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Tej tej1 = new Tej(12412421, 1, "szinva", DateTime.Now, 1.5, 349);
            Console.WriteLine(tej1.ToString()); 
            

            Console.ReadKey();
        }
    }
}
