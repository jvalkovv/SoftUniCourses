using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;
using P01_StudentSystem.Data.Models.Enums;

namespace P01_StudentSystem.Data.Models;
public class Resource
{
    public int ResourceId { get; set; }


    [MaxLength(50)]
    public string Name { get; set; } 

    [Column(TypeName = "varchar(2048)")]
    public string Url { get; set; }

    public ResourcesType ResourceType { get; set; }

    public int CourseId { get; set; }

    public Course Course { get; set; } 

}

