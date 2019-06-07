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

            new Simulation(10,1, new ConsoleWriter()).Run();

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
