


namespace StaffRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            bool exitLoop = false;
            while (!exitLoop)
            {
                Console.WriteLine("1: Enter new employee details");
                Console.WriteLine("2: View current employees");
                Console.WriteLine("3: Exit program");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        employees.Add(EmployeeCreator());
                        break;
                    case '2':
                        ViewEmployees(employees);
                        break;
                    case '3':
                        exitLoop = true;
                        break;
                    default:
                        Console.WriteLine("Wrong input. Press any key to try again");
                        Console.ReadKey(true);
                        break;
                }
                Console.Clear();
            }
        }


        private static Employee EmployeeCreator()
        {
            Console.Clear();
            Console.WriteLine("Enter first name");
            var firstName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Enter surname");
            var surName = Console.ReadLine();

            int salary = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter salary");
                if (int.TryParse(Console.ReadLine(), out salary))
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong input. Press a key to restart salary input");
                    Console.ReadKey();
                }
            }

            return new Employee(firstName, surName, salary);
        }

        private static void ViewEmployees(List<Employee> employees)
        {
            Console.Clear();
            if (employees.Count > 0)
            {
                Console.WriteLine("Employees:");
                Console.WriteLine();

                foreach (var employee in employees)
                {
                    Console.WriteLine("Name:    " + employee.Name);
                    Console.WriteLine("Salary:  " + employee.Salary);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("There are no employees registered");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Press any button to go back to the previous menu");
            Console.ReadKey(true);
        }

    }

}
