using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExonObjectDeligate
{
    class Employee
    {
         string name;
         int empid;
        public int sal;
        public Employee()
        {

        }
        public Employee(string name,int id,int sal)
        {
            this.name = name;
            this.empid = id;
            this.sal = sal;

        }

        public override string ToString()
        {
            return this.name + "\n" + this.empid + "\n" + this.sal;
        }

        //public override bool Equals(object obj)
        //{
        //    Employee temp = (Employee)obj;
        //    if (this.empid == temp.empid && this.name == temp.name)

        //        return true;
        //    else
        //        return false;

        //}
    }
}
