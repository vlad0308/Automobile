using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class Body
    {
        //public string model;
        //public string color;
        //public Condition sostoianie ;
        public Body(double kyzov)
        {
            if (kyzov < 20)
            {
                Console.WriteLine("Кузов в плохом состоянии, нужна замена.  ");
            }
            else if (kyzov > 20 || kyzov < 60)
            {
                Console.WriteLine("Кузов в плохом состоянии, скоро потребуется замена. ");
            }
            else if (kyzov > 60 || kyzov < 100)
            {
                Console.WriteLine("Кузов в хорошому состоянии. ");
            }
            else { Console.WriteLine("Ошибка"); }

        }

    }
}
