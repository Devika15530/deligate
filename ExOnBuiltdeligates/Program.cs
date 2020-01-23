using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExOnBuiltdeligates
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> f1 = (r => 3.14 * r * r);
            double area = f1(14);
            Console.WriteLine(area);

            Action<string> act = (z => Console.WriteLine(z));
           act("welcome");

            Predicate<string> pt = (y => y.Length > 3);
            int[] array = new int[] { 1, 3, 4, 5 };
            List<string> names = new List<string>();
            names.Add("dev");
            names.Add("ria");
            names.Add("maya");

            int x = array.Count(x1=> x1> 2);
            Console.WriteLine(x);

            List<string> sn = names.FindAll(y => y.Contains('y'));
            foreach(string  n in sn)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine(pt("cts"));
          Console.ReadKey();

        }
    }
}
