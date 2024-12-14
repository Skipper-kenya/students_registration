using System.ComponentModel.DataAnnotations.Schema;

namespace student_registration.Models
{
    public class Technology
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int? StudentId { get; set; }

        [ForeignKey("StudentId")]

        public Student? Student { get; set; }

    }
}
