
/* name = gurmandeep singh
 * Question number 2
 * student id = 30008833
 * */
 
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string emp_name, reply;
            double annual_gross_salary, tax_rate, net_sal;
            do
            {
                Console.Clear();
                Console.Write("\n\nWelcome to\n");
                Console.Write("The Rotorua Thermal Holiday park\n");
                Console.Write("EMPLOYEE'S PAYROLL SYSTEM");
                Console.Write("\n\n");
                Console.Write("Enter Employee's Name: ");   //user to input 
                emp_name = Console.ReadLine();
                Console.Write("Enter Annual Gross Salary: ");
                annual_gross_salary = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Tax Rate: ");
                tax_rate = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n\n");
                Console.Write("\n\n");
                Console.Write("===== AFTER DEDUCTION NET SALARY IS =====");
                Console.Write("\n\n");
                Console.WriteLine("Employee's Name: {0}.", emp_name);
                Console.WriteLine("Annual Gross Salary: {0}.", annual_gross_salary);
                Console.WriteLine("Tax Rate: {0}.", tax_rate);
                Employee emp1 = new Employee();
                emp1.Employee_Name = emp_name;
                emp1.Annual_Salary = annual_gross_salary;
                emp1.Tax_Rate = tax_rate;
                net_sal=emp1.CalcNet();         // net salary
                Console.WriteLine("NET Salary is :  {0:0.00}.", net_sal);
                Console.Write("\n\n");
                Console.Write("Do You Want To Continue? Y/N : ");
                reply = Console.ReadLine();
                if (reply == "y" || reply == "Y")
                {
                    continue;
                }
                else if (reply == "n" || reply == "N")
                {
                    Console.Write("\n\n");
                    Console.Write("Thank You For Using This Software.");
                    Console.Write("\n\n");
                    break;
                }
            } while (reply!="n");
            Console.ReadLine();
        }
    }
    class Employee
    {
        private string employee_name ="";
        private double annual_salary = 0.0;
        private double tax_rate = 0.0;
        public Employee()   //"Employee record created"
        {
            Console.WriteLine("Employee record created");
        }
        public string Employee_Name   //variable
        {
            get
            {
                return employee_name;
            }
            set
            {
                employee_name = value;
            }
        }
        public double Annual_Salary //annual gross salary 
        {
            get
            {
                return annual_salary;
            }
            set
            {
                annual_salary = value;
            }
        }
        public double Tax_Rate      // tax rate instance 
        {
            get
            {
                return tax_rate;
            }
            set
            {
                tax_rate = value;
            }
        }
        
        public double CalcNet()     //Method to calculate net salary
        {
            double annual_gross_salary = Annual_Salary - (Tax_Rate * Annual_Salary / 100);
            return annual_gross_salary;
        }
    }
}
