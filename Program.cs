namespace EmpPayroll_Day32
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee payroll");
            EmployeeModel employee = new EmployeeModel();
            EmployeeRepo repo = new EmployeeRepo();
            employee.EmployeeName = "sudhanshu";
            employee.Phoneno = "789891212";
            employee.Address = "bsp";
            employee.Department = "hr";
            employee.Gender = 'm';
            employee.BasicPay = 10000;
            employee.Deduction = 1000;
            employee.TaxablePay = 2000;
            employee.Tax = 111;
            employee.NetPay = 1111;
            employee.StartDate = DateTime.Now;////////
            employee.City = "bsp";
            employee.Country = "india";

            repo.AddEmployee(employee);
        }
    }
}