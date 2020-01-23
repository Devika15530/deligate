using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExonObjectDeligate
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> el = new List<Employee>();
            el.Add(new Employee("dev", 1111, 20000));
            el.Add(new Employee("devi", 3111, 31000));
            el.Add(new Employee("devika", 2111, 1000));

            List<Employee> highpay = el.FindAll(e => e.sal > 12000);

            foreach (Employee e in highpay)

            {
                Console.WriteLine(e.ToString());

            }
            Console.ReadKey();
        }
    }
}
