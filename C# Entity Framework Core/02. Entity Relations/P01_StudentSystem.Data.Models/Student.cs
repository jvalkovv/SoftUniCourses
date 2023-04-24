using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models;

public class Student
{
    public Student()
    {
        this.StudentsCourses = new HashSet<StudentCourse>();
        this.Homeworks = new HashSet<Homework>();
    }
    [Key]
    public int StudentId { get; set; }

    [MaxLength(100)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "char(10)")]
    public string? PhoneNumber { get; set; }


    public DateTime RegisteredOn { get; set; }

    public string? Birthday { get; set; }

    public virtual ICollection<StudentCourse> StudentsCourses { get; set; }

    public virtual ICollection<Homework> Homeworks { get; set; } = null!;

}
