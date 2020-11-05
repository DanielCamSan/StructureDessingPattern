using System;
using System.Collections.Generic;
using System.Text;

namespace StructureDeesignPattern.Subsystems
{
    public class FlyArriving
    {
        public void GetOffPlane(string name, int ci)
        {
            Console.WriteLine($"Dear Mr/s {name}, with ci {ci} you just arrived at your destination\n");
        }
    }
}
