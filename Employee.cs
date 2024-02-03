namespace Structure
{
    public class Employee : CommunityMember
    {
        public string? Role { get; set; }
        public string? Department { get; set; }
        public float Salary { get; set; }
        public DateTime HireDate { get; set; }

        public virtual void Work()
        {
            // General method for employees
        }
    }
}