namespace Structure
{
    public abstract class CommunityMember
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        public DateTime BirthDate { set; get; }
        public string? Cedula { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public virtual void EditInfo()
        {
            // Edit member basic information
        }
    }
}

