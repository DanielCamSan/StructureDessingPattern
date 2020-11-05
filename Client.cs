using StructureDeesignPattern.Facade;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructureDeesignPattern
{
    public class Client
    {
        public string Name { get; set; }
        public int Ci { get; set; }
        public decimal Due { get; set; }
        public FlightFacade Facade { get; set; }
        public Client(string name, int ci, decimal due)
        {
            Name = name;
            Ci = ci;
            Due = due;
            Facade = new FlightFacade();
        }

        public decimal MakeFly()
        {
            return Facade.MakeFly(Name,Ci,Due);
        }
    }
}
