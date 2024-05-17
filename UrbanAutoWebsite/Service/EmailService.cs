using Microsoft.Extensions.Configuration;
using RestSharp;
using System.Net;
using System.Net.Mail;

namespace UrbanAutoWebsite.Service
{
    public class EmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        //string apiKey = "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";

        public void SendEmail(string recipient, string subject, string templatePath, string userName)
        {
            string apiKey = "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";

            // Create REST client
            var client = new RestClient("https://api.brevo.com");
            var request = new RestRequest("/send-email", Method.Post);
            request.AddHeader("x-api-key", apiKey);
            request.AddParameter("recipient", recipient);
            request.AddParameter("subject", subject);
            request.AddParameter("templatePath", templatePath);
            request.AddParameter("userName", userName);

            try
            {
                // Execute request
                var response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    Console.WriteLine("Email sent successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to send email: " + response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to send email: " + ex.Message);
            }
        }

    }
}
