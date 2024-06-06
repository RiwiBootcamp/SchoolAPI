using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SchoolApi.Models
{
  public class Teacher
  {
    // A good part of models have ID
    [Key]
    public int Id {get; set;}

    [Required]
    public string FullName {get; set;}

    [Required]
    public string Speciality {get; set;}

    public string? Phone {get; set;}

    [Required]
    public string Email {get; set;}
    
    [Required]
    [Range(1, 80)]
    public int YearsExperience {get; set;}

    // Model linkig
    [JsonIgnore]
    public List<Course>? Courses {get; set;}
  }
}
