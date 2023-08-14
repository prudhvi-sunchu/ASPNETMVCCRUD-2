namespace ASPNETMVCCRUD.Models
{
    public class UpdateEmployeeViewmodel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
    }
}
