using SchoolApi.Helpers;
using SchoolApi.Models;
using SchoolApi.Models.MailerSend;

namespace SchoolApi.Services.EnrollmentsRepository
{
  public static class SendEnrollmentEmailStudent 
  {
    public static async Task<string> SendEmail(Student studentInfo)
    {
      Email newEmail = new Email
      {
        From = new Recipent{Email = "dannyKentala@trial-pq3enl60en8l2vwr.mlsender.net"},
        To = 
        [
          new Recipent{Email = "gidigabej.hugobepoc@jollyfree.com"},
          new Recipent{Email = studentInfo.Email}
        ],
        Subject = "Confirmation email",
        Html = $"Congratulations {studentInfo.FullName} your are now enrolled in the course"
      };

      MailerSendClient mailerSendClient = new MailerSendClient();
      string emailInfo = await mailerSendClient.SendEmail(newEmail);

      return emailInfo;
    }
  }
}