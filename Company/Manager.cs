using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Manager : Employee
    {
        public List<Employee> Employees { get; set; }
        public Manager(int id, string name, string lastname, int salary, Departament dep, List<Employee> employees)            
            :base(id,name,lastname,salary,dep)
        {        
            this.Employees = employees;
        }
       
        // Verdarcnum e string vortex pahvac e ay employee-neri anunnery voronc xekavarum e Managery
        public string GetEmployees()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Under His/Her Control \n");
            for (int i = 0; i < Employees.Count; i++)
            {
                sb.Append($"{Employees[i].FirstName},{Employees[i].LastName}\n");
            }               
            return sb.ToString();
        }
        // Grvum e masnagitutynuy,kanchvum e cnoxi Tostring() function-y  ev tpvum e GetEmployees() i veradarcrac arjeqy
        public override string ToString()
        {
            return "Manager " + base.ToString() + GetEmployees();
        }
        

    }
}
