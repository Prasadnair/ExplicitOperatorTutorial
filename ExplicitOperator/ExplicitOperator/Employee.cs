using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitOperator
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static explicit operator Employee(Manager manager)
        {
            return new Employee { Name = manager.Name, Age = manager.Age };
        }
    }
}
