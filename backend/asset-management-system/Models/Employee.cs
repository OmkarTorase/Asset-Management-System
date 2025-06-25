namespace asset_management_system.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }

        public ICollection<AssetAssignment> Assignments { get; set; }
    }
}
