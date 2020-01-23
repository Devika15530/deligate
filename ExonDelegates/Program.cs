using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExonDelegates
{
    public delegate void deligatePointer();
    public delegate double calAreaPointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Program p = new Program();

            deligatePointer mydel = p.print;
            mydel += p.display;//multicast deligate
            mydel();
            mydel -= p.print;
            mydel();

            
            calAreaPointer cptr = Calci.calArea;
           


            cptr += Calci.caldistance;//multicast delegate having returntype primitive datatype
            double area = cptr(20);
            Console.WriteLine(area);//it will retu-rn last value;

            Console.ReadKey();
        }

        public void print()
        {
            Console.WriteLine("welcome to deligate");
        }
        public void display()
        {
            Console.WriteLine("welcome to hi deligate");
        }
    }
}
