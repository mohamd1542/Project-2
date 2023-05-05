using Amazon_Data;
using Amazon_Domain;

namespace Amazon_MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //using (AmazonDBContext context = new AmazonDBContext())
            //{
            //    context.Database.EnsureCreated();
            //}
            ////////Reading from DB/////////
            GetEmployees();

            //////////Writing to DB//////////////
            AddEmployee();

            GetEmployees();

        }

        private static void AddEmployee()
        {
            using (var context = new AmazonDBContext())
            {
                var ahmad = new Employee() { FirstName = "Ahmad", LastName = "Saloum" };
                context.Employees.Add(ahmad);
                context.SaveChanges();
            }
        }

        private static void GetEmployees()
        {
            using(var context = new AmazonDBContext())
            {
                var Employees = context.Employees.ToList();
                foreach (var employee in Employees)
                {
                    Console.WriteLine(employee.FirstName + " " +employee.LastName);
                }
            }
        }
    }
}