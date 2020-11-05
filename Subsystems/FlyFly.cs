using System;
using System.Collections.Generic;
using System.Text;

namespace StructureDeesignPattern.Subsystems
{
    public class FlyFly
    {
        private decimal _price = 15.5m;
        public void Fly(string name)
        {
            Console.WriteLine($"Mr/Ms {name} thank you for choosing us enjoy your fly\n");
        }
        public decimal EatSnacks(string name,int quantitySnacks)
        {
            Console.WriteLine($"Dear Mr/s {name}, you have eaten {quantitySnacks} snacks at price {_price} \n");
            decimal due = quantitySnacks * _price;
            return due;
        }
    }
}
