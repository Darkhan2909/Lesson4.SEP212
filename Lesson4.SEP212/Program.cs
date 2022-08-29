using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.SEP212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.DetailCars = "panel";
            Console.WriteLine(car.DetailCars);
        }
    }
    internal class Car
    {

        public string DetailCars { get; set; }
        public Car()
        {

        }
        public Car(string detailCars)
        {
            this.DetailCars = detailCars;
        }

    }
}
