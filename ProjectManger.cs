using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlificsManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] project = new string[100];
            string[] emp = new string[100];
            string[] role = new string[100];
            int Project1 = 0;
            int Emp1 = 0;
            int Role1 = 0;
            int i;

            void Project_add()   //Function to Add Project
            {
                Console.Write("Number of Projects you want to Add: ");
                int Project = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Project name: ");
                for (i = 1; i <= Project; i++)
                {
                    project[Project1++] = Console.ReadLine();
                }
                Console.WriteLine("Added Successfully");
            }
            void Project_view()  //Function to View Project
            {
                Console.Write("Added projects are: ");
                for (i = 0; i <= Project1; i++)
                {
                    Console.WriteLine(project[i]);
                }
            }
            void Employee_add()  //Function to Add Employee
            {
                Console.Write("Employees you want to Add: ");
                int Emp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name of Employee: ");
                for (i = 1; i <= Emp; i++)
                {
                    emp[Emp1++] = Console.ReadLine();
                }
                Console.WriteLine("Project Added Successfully");
            }
            void Employee_view()  //Function to View Employee
            {
                Console.Write("Added Employees are: ");
                for (i = 0; i <= Emp1; i++)
                {
                    Console.WriteLine(emp[i]);
                }
            }
            void Role_add()  //Function to Add Role
            {
                Console.Write("Number of Role you want to add: ");
                int Role = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name of Roles: ");
                for (i = 1; i <= Role; i++)
                {
                    role[Role1++] = Console.ReadLine();
                }
                Console.WriteLine("Roles Added Successfully");
            }
            void Role_view()     //Function to View Role
            {
                Console.Write("Added Roles are: ");
                for (i = 0; i <= Role1; i++)
                {
                    Console.WriteLine(role[i]);
                }
            }
            while (true)
            {
                Console.WriteLine(" 1) Add Project ");
                Console.WriteLine(" 2) View Project ");
                Console.WriteLine(" 3) Add Employee");
                Console.WriteLine(" 4) view Employee");
                Console.WriteLine(" 5) Add Role");
                Console.WriteLine(" 6) View Role");
                Console.WriteLine(" 7) Exit");
                Console.Write("Select any one option: ");

                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Project_add();
                        break;
                    case 2:
                        Project_view();
                        break;
                    case 3:
                        Employee_add();
                        break;
                    case 4:
                        Employee_view();
                        break;
                    case 5:
                        Role_add();
                        break;
                    case 6:
                        Role_view();
                        break;
                    case 7:
                        return;
                }
            }


        }
    }
}
        
   

