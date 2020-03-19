using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Property_Management.Services
{
    // using SendGrid's C# Library
    // https://github.com/sendgrid/sendgrid-csharp
    using SendGrid;
    using SendGrid.Helpers.Mail;
    using System;
    using System.Threading.Tasks;

    namespace SendGridMinimum
    {
        internal class SendGrid
        {
            private static void Send()
            {
                Execute().Wait();
            }

            static async Task Execute()
            {
                var apiKey = Environment.GetEnvironmentVariable("Property Management");
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress("dorianhaley1992@gmail.com", "Dorian Haley");
                var subject = "Account Verification";
                var to = new EmailAddress("test@example.com", "Example User");
                var plainTextContent = "";
                var htmlContent = "<strong></strong>";
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = await client.SendEmailAsync(msg);
            }
        }
    }
}
