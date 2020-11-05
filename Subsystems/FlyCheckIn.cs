using System;
using System.Collections.Generic;
using System.Text;

namespace StructureDeesignPattern.Subsystems
{
    public class FlyCheckIn
    {
        public void Register(string name, int ci,decimal price)
        {
            Console.WriteLine($"Helllo {name}, with ci {ci} thank you for your registration, your flight has the price of {price}\n");
        }
    }
}
