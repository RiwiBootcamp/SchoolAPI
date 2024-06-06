using SchoolApi.Models.MailerSend;

namespace SchoolApi.Helpers.Interfaces
{
  public interface IEmailClient
  {
    Task<string> SendEmail (Email data);
  }
}