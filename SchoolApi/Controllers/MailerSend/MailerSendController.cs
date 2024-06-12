
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Helpers;
using SchoolApi.Models.MailerSend;

namespace SchoolApi.Controllers
{
  [Route("api/emails")]
  [ApiController]
  public class MailerSendController: ControllerBase
  {
      [HttpGet]
      public async Task<string> GetAll()
      {
        // var options = new EmailClientOptions
        // {
        //   ApiToken = "mlsn.ea53d2d62c5b62333be9a2106064e6922bf3658c9769db63f9d48b5d94afe71b",
        //   ApiUrl = "https://api.mailersend.com/v1/email"
        // };

        Email newEmail = new Email
        {
          From = new Recipent{Email = "dannyKentala22@trial-z86org8o1d04ew13.mlsender.net"},
          To = 
          [
            new Recipent{Email = "handres41@outlook.com"}
          ],
          Subject = "Email from backend",
          Html = "This is an email generate from backend, backend i'm loving it"
        };

        MailerSendClient mailerSendClient = new MailerSendClient();
        string emailInfo = await mailerSendClient.SendEmail(newEmail);
        return emailInfo;
      }
  }
}