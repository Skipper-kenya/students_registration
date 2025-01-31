namespace student_registration.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Registration { get; set; }

        public int IdNo { get; set; }

        public int Phone { get; set; }

        public string School { get; set; }

        public int? TechnologyId { get; set; }

        public Technology? Technology { get; set; }

        public int? LocationId { get; set; }

        public List<Location>? Locations { get; set; }


    }
}
