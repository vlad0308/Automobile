using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class Engine
    {
        //public string type;

        //public string model;
        //public Condition sostoianie;
        public Engine(double motor)
        {
            if (motor < 20)
            {
                Console.WriteLine("Мотор  в плохом состоянии, нужна замена.  ");
            }
            else if (motor > 20 || motor < 60)
            {
                Console.WriteLine("Мотор в плохом состоянии, скоро потребуется замена. ");
            }
            else if (motor > 60 || motor < 100)
            {
                Console.WriteLine("Мотор  в хорошому состоянии. ");
            }
            else { Console.WriteLine("Ошибка"); }



        }
    }
}
