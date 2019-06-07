using System;
using System.Collections.Generic;
using System.IO;

namespace StrategyPatternRealLife
{
    class Program
    {
        static void Main(string[] args)
        { 
            //IWriter writer = new ConsoleWriter();
            //IWriter fileWriter = new FileWriter("output.txt");
            //Simulation sim = new Simulation(writer);
            //Simulation sim2 = new Simulation(fileWriter);
            //ICollection<string> result = sim.Run();

            // Simulation Example 
            new Simulation(10,1, new ConsoleWriter()).Run();
            // Billing Example
            //Prepare strategies
            IBillingStrategy normalStrategy = new NormalStrategy();
            IBillingStrategy happyHourStrategy = new HappyHourStrategy();
            Customer firstCustomer = new Customer(normalStrategy);
            //Normal billing
            firstCustomer.Add(1.0,1);

            // Start Happy Hour
            firstCustomer.Strategy = happyHourStrategy;
            firstCustomer.Add(1.0,2);

            // New Customer
            Customer secondCustomer = new Customer(happyHourStrategy);
            secondCustomer.Add(0.8,1);

            // The Customers pays
            firstCustomer.PrintBill();

            // End Happy Hour
            secondCustomer.Strategy = normalStrategy; 
            secondCustomer.Add(1.3,2);
            secondCustomer.Add(2.5,1);
            secondCustomer.PrintBill();

            //foreach (string s in result)
            //{
            //    Console.WriteLine(s);
            //}
            //sim.Run();
            //sim2.Run();

        }
    }

    class Simulation
    {
        private readonly int _n;
        private readonly IWriter _writer;
        private readonly Random _rnd ;

        public Simulation(int n, int seed , IWriter writer)
        {
            _n = n;
            this._rnd =  new Random(seed);
            _writer = writer;
        }
        public void Run()
        {   // flip a coin and return head s 50% and tails 50%
            for(int i = 0; i<10; i++) {
                var result = this._rnd.NextDouble() <= 0.5 ? "Heads" : "Tails";
                this._writer.Write(result);
            }
        }

        //public ICollection<string> Run()
        //{   // flip a coin and return heads 50% and tails 50%
        //    List<string> results = new List<string>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        results.Add( this._rnd.NextDouble() <= 0.5 ? "Heads" : "Tails");
        //    }
        //    return results;
        //}
    }

    internal interface IWriter
    {
        void Write(string result);
    }

    class ConsoleWriter : IWriter
    {
        public void Write(string result)
        {
           Console.WriteLine(result);
        }
    }

    class FileWriter : IWriter
    {
        private readonly string _path;

        public FileWriter(string path)
        {
            _path = path;
        }
        public void Write(string result)
        {
            Console.WriteLine("Writing " + result + " to "+ _path);
            // write "result" to path
        }
    }
}
