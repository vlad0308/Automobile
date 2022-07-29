using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class Automobile
    {
        string name;
        string type;
        string model;
        double weight;
        double cost;
        //public Shassis shasi;
        
        //public Engine motor;
        //public Body kyzov;

        public  Automobile(string name1, string type1, string model1, double weight1, double cost1)
        {
            this.name = name1;
            this.type = type1;
            this.model = model1;
            this.weight = weight1;
            this.cost = cost1;

            Console.WriteLine($"авто : {name},тип : {type},модель : {model},вага : {weight}, цена : {cost} ");
        }
        double shasi;
        double motor;
        double kyzov;


        public void Ezdit()
        {
            double firstDisShasi = 1000000;
            double firstDisKyzov = 500000;
            double firstDisMotor = 400000;
            Console.Write("Какую дистанцию проехал автомобиль (км) ? : ");
            double distanse = Convert.ToDouble(Console.ReadLine());

              shasi = ((firstDisShasi - distanse) * 100) / firstDisShasi;
              motor = ((firstDisMotor - distanse) * 100) / firstDisMotor;
              kyzov = ((firstDisKyzov - distanse) * 100) / firstDisKyzov;


            
        }
        public void Osmotr()
        {
            Console.WriteLine($"Износ шаси = {100 - shasi }%" );
            Console.WriteLine($"Износ мотора  = { 100 - motor}%");
            Console.WriteLine($"Износ кузова = {100 - kyzov}%");

            Shassis shassis = new Shassis(shasi);
            Engine engine = new Engine(motor);
            Body body = new Body(kyzov);
            
            Condition condition = new Condition();
            condition.Show(shasi,motor,kyzov);

        }

    }
}
