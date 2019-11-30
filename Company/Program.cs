using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Developer dev = new Developer(1551, "John", "developer1", 100000, Departament.Production, new List<Project>()
            {
                new Project(projectName:"Project1",startDate:DateTime.Today,details:"details about project",projectState:State.Open),
                new Project(projectName:"Project2",startDate:DateTime.Parse("1/10/2018"),details:"details about project",projectState:State.Closed)
                
            });
            Developer dev2 = new Developer(1552, "Bob", "developer2", 200000, Departament.Production, new List<Project>()
            {
                new Project(projectName:"Project3",startDate:DateTime.Now,details:"details about project",projectState:State.Open),
                new Project(projectName:"Project4",startDate:DateTime.Parse("2/2/2018 "),details:"details about project",projectState:State.Closed)
            });
            Developer dev3 = new Developer(1553, "Anna", "developer3", 300000, Departament.Production, new List<Project>()
            {
                 new Project(projectName:"Project5",startDate:DateTime.Parse("3/2/2018"),details:"details about project",projectState:State.Open),
                new Project(projectName:"Project6",startDate:DateTime.Parse("2/2/2017"),details:"details about project",projectState:State.Closed)
            });

            SalesEmployee emp = new SalesEmployee(1220, "Jack", "SalesEmployee1", 150000, Departament.Sales, new List<Product>()
            {
                 new Product(price: 10000, productName: "Product1", date: 25)
            });
            SalesEmployee emp1 = new SalesEmployee(1221, "Boris", "SalesEmployee2", 250000, Departament.Sales, new List<Product>()
            {
            new Product(price: 20000, productName: "Product2", date: 30)
            });
            SalesEmployee emp2 = new SalesEmployee(1222, "Annabel", "SalesEmployee3", 350000, Departament.Sales, new List<Product>()
            {
                new Product(price: 25000, productName: "Product3", date: 40)
            });

            Manager manager1 = new Manager(1112, "Hakob", "Manager1", 200000, Departament.Accounting, new List<Employee>() { dev, dev2, emp1 });
            Manager manager2 = new Manager(1113, "Vazgen", "Manager2", 300000, Departament.Marketing, new List<Employee>() { emp, emp2, dev3 });


            List<Employee> Employees = new List<Employee>()
            {
                dev,dev2,dev3,
                emp,emp1,emp2,
                manager1,manager2
            };

            foreach (var employee in Employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }




            Console.ReadKey();
        }
    }
}
