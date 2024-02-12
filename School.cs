using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_project_6_1._13.Model
{
    [Table("uischooldb")]
    public class School
    {

        [Key]
        public int RollNo { get; set; }
        public int SchoolId { get; set; }
        public int marks { get; set; }
        public string Student { get; set; }
        public string Subject { get; set; }

    }
}
