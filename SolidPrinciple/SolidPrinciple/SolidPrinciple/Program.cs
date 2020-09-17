using System;

namespace SolidPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            // Single Responsibility Principle

            //var journal = new SingleResponsibilityPrinciple();
            //journal.AddEntry("I cried today");
            //journal.AddEntry("I ate a bug");
            //Console.WriteLine(journal);

            //var p = new Persistence();
            //var filename = @"c:\temp\journal.txt";
            //p.Save(journal, filename, true);
            //Process.Start(new ProcessStartInfo(filename) { UseShellExecute = true });


            // Open Closed Principle
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Huge);

            Product[] products = { apple, tree, house };
            var pf = new ProductFilter();
            Console.WriteLine("Green products (old):");
            foreach (var p in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

            var bf = new BetterFilter();
            Console.WriteLine("Green products (new):");

            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

            Console.WriteLine("Large blue Items:");

            foreach (var p in bf.Filter(products, new AndSpecification<Product>(
                new ColorSpecification(Color.Blue),
                new SizeSpecification(Size.Huge)
            )))
            {
                Console.WriteLine($" - {p.Name} is blue and huge");
            }
        }
    }
}
