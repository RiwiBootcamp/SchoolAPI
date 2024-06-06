using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SchoolApi.Models
{
  public class Course
  {
    // A good part of models have ID
    [Key]
    public int Id {get; set;}

    [Required] 
    public string Name {get; set;}
    public string Description {get; set;}
    public string Schedule {get; set;}
    public string Duration {get; set;}

    [Required] 
    [Range(1, 1500)]
    public int Capacity {get; set;}

    [Required] 
    [Range(1, 1000)]
    public int IdTeacher {get; set;}

    // Model linkig
    [ForeignKey("IdTeacher")]
    public Teacher? Teacher {get; set;}

    [JsonIgnore]
    public List<Enrollment>? Enrollments {get; set;}
  }
}
