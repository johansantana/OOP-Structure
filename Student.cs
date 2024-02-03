namespace Structure
{
    public class Student : CommunityMember
    {
        public string? Career { get; set; }
        public DateTime EnrollDate { get; set; }
        public float GPA { get; set; }

        public void GetGradesHistory()
        {
            // Method to get the grades history
        }
    }
}