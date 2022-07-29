using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class Condition
    {
        //public string opisanie;
        public double procentIznoshenosti;
        //public string sostoianie;
        public void Show(double shasi,double motor,double kyzov)
        {
            procentIznoshenosti = (motor + kyzov + shasi) / 3;
            Console.WriteLine($"Состояние авто = {procentIznoshenosti}");

            

            
        }
    }
}
