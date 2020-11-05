using System;
using System.Collections.Generic;
using System.Text;

namespace StructureDeesignPattern.Subsystems
{
    public class FlyPreBoarding
    {
        private decimal _price = 15.5m;
        public void EnterRoom(string name,int ci)
        {
            Console.WriteLine($"Dear Mr/s {name}, with ci {ci} please enter at waiting room\n");
        }
        public decimal EatSnacks(string name,int quantitySnacks)
        {
            decimal due = quantitySnacks * _price;
            Console.WriteLine($"Dear Mr/s {name}, you have eaten {quantitySnacks} snacks at price {_price} \n");
            return due;
        }
    }
}
