using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SchoolApi.Models
{
  public class Student
  {
    // A good part of models have ID
    [Key]
    public int Id {get; set;}

    [Required]
    [Length(1, 100)]
    public string FullName {get; set;}
    public DateOnly BirthDate {get; set;}
    public string Address {get; set;}

    [Required]
    [EmailAddress]
    public string Email {get; set;}

    // Model linkig
    [JsonIgnore]
    public List<Enrollment>? Enrollments {get; set;}
  }
}
