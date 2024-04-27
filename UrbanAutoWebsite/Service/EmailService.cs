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

        //public void SendEmail(string recipient, string subject, string templatePath, string userName)
        //{
        //    string apiKey = "YOUR_API_KEY";
        //    var client = new RestClient("https://api.brevo.com/v3/emailCampaigns");

        //    var request = new RestRequest(Method.Post);
        //    request.AddHeader("api-key", apiKey);
        //    request.AddJsonBody(new
        //    {
        //        name = "Campaign sent via the API",
        //        subject,
        //        sender = new { name = "From name", email = "myfromemail@mycompany.com" },
        //        type = "classic",
        //        htmlContent = "Congratulations! You successfully sent this example campaign via the Brevo API.",
        //        recipients = new { listIds = new[] { 123, 456 } }, // Replace 123 and 456 with valid list identifiers
        //        scheduledAt = DateTime.Now,
        //    });

        //    var response = client.Execute(request);

        //    if (response.IsSuccessful)
        //    {
        //        Console.WriteLine("Campaign created successfully");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Failed to create campaign: {response.ErrorMessage}");
        //    }
        //}

    }
}
