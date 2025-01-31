namespace student_registration.Models
{
    public class Location
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? StudentId {  get; set; }

        public Student? Student { get; set; }
    }
}
