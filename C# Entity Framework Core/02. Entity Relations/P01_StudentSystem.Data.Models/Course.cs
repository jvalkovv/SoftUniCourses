using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using P01_StudentSystem;

namespace P01_StudentSystem.Data.Models;
public class Course
{
    public Course()
    {
        Homeworks = new HashSet<Homework>();
        Resources = new HashSet<Resource>();
        StudentsCourses = new HashSet<StudentCourse>();
    }

    public int CourseId { get; set; }

    [MaxLength(80)]
    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal Price { get; set; }

    public virtual ICollection<StudentCourse> StudentsCourses { get; set; }

    public virtual ICollection<Resource> Resources { get; set; }

    public virtual ICollection<Homework> Homeworks { get; set; }
}

