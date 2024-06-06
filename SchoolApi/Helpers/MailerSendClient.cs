using System.Text;
using System.Text.Json;
using SchoolApi.Helpers.Interfaces;
using SchoolApi.Models.MailerSend;

namespace SchoolApi.Helpers
{
  public class MailerSendClient: IEmailClient
  {
    private readonly HttpClient _httpClient = new HttpClient();
    private readonly EmailClientOptions _options;

    public MailerSendClient (EmailClientOptions options = default)
    {
      if(options == default)
      {
        _options = new EmailClientOptions()
        {
          ApiToken= "mlsn.ea53d2d62c5b62333be9a2106064e6922bf3658c9769db63f9d48b5d94afe71b",
          ApiUrl= "https://api.mailersend.com/v1/email"
        };
      } 
      else
      {
        _options = options;
      }
    }

    public async Task<string> SendEmail(Email data)
    {
      using HttpResponseMessage response = await PostEmail(data);
      return await response.Content.ReadAsStringAsync();
    }

    private async Task<HttpResponseMessage> PostEmail (Email data)
    {
      // Serialize email information
      StringContent content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
        
      _httpClient.DefaultRequestHeaders.Add("ContentType", "application/json");

      // Add Token
      _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_options.ApiToken}");

      HttpResponseMessage response = await _httpClient.PostAsync(_options.ApiUrl, content);

      response.EnsureSuccessStatusCode();

      return response;
    }
  }
}