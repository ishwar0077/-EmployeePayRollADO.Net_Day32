namespace EmpPayroll_Day32
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee payroll");
            EmployeeModel employee = new EmployeeModel();
            EmployeeRepo repo = new EmployeeRepo();
            employee.EmployeeName = "Ishwar";
            employee.Phoneno = "9140402022";
            employee.Address = "tel";
            employee.Department = "mh";
            employee.Gender = 'm';
            employee.BasicPay = 10000;
            employee.Deduction = 1000;
            employee.TaxablePay = 2000.00;
            employee.Tax = 111;
            employee.NetPay = 1111;
            employee.StartDate = DateTime.Now;////////
            employee.City = "tel";
            employee.Country = "india";

            // repo.AddEmployee(employee);
            repo.GetAllEmployee();

        }
    }
}