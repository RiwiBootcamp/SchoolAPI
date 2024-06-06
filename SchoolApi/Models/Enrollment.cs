using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApi.Models
{
  public class Enrollment
  {
    // A good part of models have ID
    [Key]
    public int Id {get; set;}
    public DateOnly Date {get; set;}

    [Required]
    [AllowedValues(["Paid", "Not Paid", "Canceled"])]
    public string Status {get; set;}

    [Required]
    public int IdStudent {get; set;}

    [Required]
    public int IdCourse {get; set;}

    // Model linkig
    [ForeignKey("IdStudent")]
    public Student? Student {get; set;}

    [ForeignKey("IdCourse")]
    public Course? Course {get; set;}
  }
}
