using System;
using System.Collections.Generic;
using System.Text;

namespace StructureDeesignPattern.Subsystems
{
    public class FlyBoarding
    {
        public void Board(string name, int ci)
        {
           
            Console.WriteLine($"Mr/Ms {name}, with ci {ci} please approach gate 5 to board the flight\n");
        }
    }
}
