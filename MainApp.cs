using StructureDeesignPattern.Facade;
using System;

namespace StructureDeesignPattern
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string name = "Daniel";
            int ci = 5918928;
            decimal initialFlightCost = 500.5m;
            Client firstClient = new Client(name, ci, initialFlightCost);
            decimal due = firstClient.MakeFly();
            Console.WriteLine($"Dear Mr/s {name} you have to pay {due} for the flight service Thank you!\n");
        }
    }
}
