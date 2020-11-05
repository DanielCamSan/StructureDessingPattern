using StructureDeesignPattern.Subsystems;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructureDeesignPattern.Facade
{
    public class FlightFacade
    {
        private FlyArriving _arriving;
        private FlyFly _fly;
        private FlyBoarding _boarding;
        private FlyPreBoarding _preBoarding;
        private FlyCheckIn _checkIn;
        public FlightFacade()
        {
            _arriving = new FlyArriving();
            _fly = new FlyFly();
            _boarding = new FlyBoarding();
            _preBoarding = new FlyPreBoarding();
            _checkIn = new FlyCheckIn();
        }
        public decimal MakeFly(string name, int ci, decimal due)
        {
            Console.WriteLine("******** Doing Check in **********\n");
            _checkIn.Register(name, ci, due);
            Console.WriteLine("******** Doing Preboarding **********\n");
            _preBoarding.EnterRoom(name, ci);
            due+=_preBoarding.EatSnacks(name,5);
            Console.WriteLine("************ Boarding *************\n");
            _boarding.Board(name,ci);
            Console.WriteLine("************ Flying *************\n");
            _fly.Fly(name);
            due += _fly.EatSnacks(name, 2);
            Console.WriteLine("************ Arriving *************\n");
            _arriving.GetOffPlane(name,ci);

            Console.WriteLine("************ End of making fly *************\n");
            return due;
        }
    }
}
