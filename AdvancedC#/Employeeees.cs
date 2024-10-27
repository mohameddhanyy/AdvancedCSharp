using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_
{
   
    class Employeeees : IComparable<Employeeees>
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public Employeeees(int id, string name, int salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}";
        }

        //public int CompareTo(object? obj)
        //{
        //    Employeeees e = obj as Employeeees;
        //    if (e != null)
        //    {
        //        return this.Salary.CompareTo(e.Salary);
        //    }
        //    else return 1;
        //}

        public int CompareTo(Employeeees? e)
        {
            if (e != null)
            {
                return this.Salary.CompareTo(e.Salary);
            }
            else return 1;
        }
    }
}
