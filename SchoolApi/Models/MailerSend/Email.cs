using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SchoolApi.Models.MailerSend
{
  public class Email
  {
    // Say to copiler that this field most be parse as "from"
    [Required]
    [JsonPropertyName("from")]
    public Recipent? From {get; set;}

    [Required]
    [JsonPropertyName("to")]
    public Recipent[] To {get; set;}

    [Required]
    [JsonPropertyName("subject")]
    public string Subject {get; set;}

    [JsonPropertyName("text")]
    public string? Text {get; set;}

    [JsonPropertyName("html")]
    public string? Html {get; set;}
  }
}