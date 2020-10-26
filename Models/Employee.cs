namespace Emp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public Department Department { get; set; }
        public int DId { get; set; }
    }
}