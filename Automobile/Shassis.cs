using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class Shassis
    {
        //public string model;
        //public Condition sostoianie;
        public Shassis(double shasi)
        {
            if (shasi < 20)
            {
                Console.WriteLine("Шаси в плохом состоянии, нужна замена.  ");
            }
            else if (shasi > 20 || shasi < 60 )
            {
                Console.WriteLine("Шаси в плохом состоянии, скоро потребуется замена. ");
            }
            else if (shasi >60 || shasi <100)
            {
                Console.WriteLine("Шаси в хорошому состоянии. ");
            }
            else { Console.WriteLine("Ошибка"); }

        }

    }
}
