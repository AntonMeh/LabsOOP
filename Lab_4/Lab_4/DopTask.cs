using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Car :IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Автомобіль їде зі швидкістю 100 км/год.");
        }
    }
    internal class Bike :IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Велосипед їде зі швидкістю 20 км/год.");
        }
    }
    
}
