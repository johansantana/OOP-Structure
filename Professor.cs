namespace Structure
{
    public abstract class Professor : Employee
    {

        public string? Subject { get; set; }
        public bool IsAdministrator = false;

        public override void Work()
        {
            // Professor work
        }
    }
}