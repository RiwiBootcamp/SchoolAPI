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
          /* Try to use a real email 
            also work with this temporal email generator
            https://temp-mail.org/en/view/
          */

          new Recipent{Email = studentInfo.Email}
        ],
        Subject = "Confirmation email",
        Html = $"Congratulations your are now enrolled in the course: Good"
      };

      MailerSendClient mailerSendClient = new MailerSendClient();
      string emailInfo = await mailerSendClient.SendEmail(newEmail);

      return emailInfo;
    }
  }
}