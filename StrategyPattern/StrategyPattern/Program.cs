using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //WalkBehavior walkBehavior = 
            //FlyBehvaior flyBehavior = ;
            //Duck wildDuck = new Duck(new WildWalking(), new WildFlying());
            //Duck cityDuck = new Duck(new CalmWalking(), new CalmFlying());
            //Duck mountainDuck = new Duck(new CalmWalking(), new HighAltitudeFlying());
            //Duck cloudDuck = new Duck(new NoWalking(), new HighAltitudeFlying());

            List<Duck> ducks = new List<Duck>() {
                new Duck("WildDuck" ,  new WildWalking(), new WildFlying()), // Wild
                new Duck("CityDuck" ,  new CalmWalking(), new CalmFlying()), // City
                new Duck("MountainDuck" ,  new CalmWalking(), new HighAltitudeFlying()), // mountain
                new Duck("CloudDuck" ,  new NoWalking(), new HighAltitudeFlying()) //
             };

            //Console.WriteLine("Walking: " + wildDuck.Walk());
            //Console.WriteLine("Flying: " + wildDuck.Fly());
            foreach(Duck d in ducks)
            {
                Console.WriteLine();
                Console.WriteLine("Fly: "+ d.Name() + " -> " + d.Fly());
                Console.WriteLine("Walk: " + d.Name() + " -> " + d.Walk());
            }
        }

    }
    //public interface Duck
    //{
    //    string Walk();
    //    string Fly();
    //}

    class Duck
    {
        private readonly string name;
        private readonly IWalkBehavior walkBehavior;
        private readonly IFlyBehavior flyBehvaior;

        public Duck(string name, IWalkBehavior wb, IFlyBehavior fb)
        {
            this.name = name;
            this.walkBehavior = wb;
            this.flyBehvaior = fb;
        }
        public string Name()
        {
            return this.name;
        }
        public string Fly()
        {
            return this.flyBehvaior.Fly();
        }

        public string Walk()
        {
            return this.walkBehavior.Walk();
        }
    }

    //class WildDuck : Duck
    //{
    //    private readonly WalkBehavior walkBehavior;
    //    private readonly FlyBehvaior flyBehvaior;

    //    public WildDuck(WalkBehavior wb, FlyBehvaior fb)
    //    {
    //        this.walkBehavior = wb;
    //        this.flyBehvaior = fb;
    //    }

    //    public string Fly()
    //    {
    //        return this.flyBehvaior.Fly();
    //    }

    //    public string Walk()
    //    {
    //       return this.walkBehavior.Walk();
    //    }
    //}

    //class CityDuck : Duck
    //{
    //    public string Fly()
    //    {
    //        return "High-Intensity flying";
    //    }

    //    public string Walk()
    //    {
    //        return "Walking carefully";
    //    }
    //}
    //class MountainDuck : Duck
    //{
    //    public string Fly()
    //    {
    //        return "High-altitude flying";
    //    }

    //    public string Walk()
    //    {
    //        return "Walking carefully";
    //    }
    //}
    //class CloudDuck : Duck
    //{
    //    public string Fly()
    //    {
    //        return "High-altitude flying";
    //    }

    //    public string Walk()
    //    {
    //        return "No Walking";
    //    }
    //}

}

