using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Models
{
  public class Teacher
  {
    // A good part of models have ID
    [Key]
    public int Id {get; set;}
    public string FullName {get; set;}
    public string Speciality {get; set;}
    public string Phone {get; set;}
    public string Email {get; set;}
    public int YearsExperience {get; set;}
  }
}
