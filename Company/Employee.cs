using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    enum Departament
    {
        Production,
        Accounting,
        Sales,
        Marketing
    }
    abstract class Employee : IPerson
    {
        public int Salary { get; set; }
        public Departament Departament { get; set; }
        public int ID { get ; set ; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(int id, string name, string lastname, int salary, Departament dep)            
        {
            this.ID = id;
            this.FirstName = name;
            this.LastName = lastname;
            this.Departament = dep;
            this.Salary = salary;
        }
        public override string ToString()
        {
            return $" \nID:{this.ID} \nFirstName:{this.FirstName} \nLastName:{this.LastName} \nSalary:{this.Salary} \nDepartament:{this.Departament.ToString()} \n";
        }

    }
}
