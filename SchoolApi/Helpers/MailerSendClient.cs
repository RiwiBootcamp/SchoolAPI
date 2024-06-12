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

    public MailerSendClient (EmailClientOptions options = null)
    {
      if(options == null)
      {
        _options = new EmailClientOptions()
        {
          ApiToken= "mlsn.fbffcfd83e0d0d1fdae55c63061cd045168ea43b1f70e7b0717d43cee6abddf1",
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