namespace Amazon_Domain
{
    public class Employee
    {
        public Employee() 
        {
            Tasks = new List<Task>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Task> Tasks { get; set; }
    }
}