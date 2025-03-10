using System;
using System.IO;
using System.Text;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace libraryManagementSystem.GmailServices
{
    public class GmailServices
    {
        string[] Scopes = { GmailService.Scope.GmailSend };
        string ApplicationName = "LibraryManagementSystem";

        // Method to encode the email content to Base64URL
        private string Base64UrlEncode(string input)
        {
            var data = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(data)
                .Replace("+", "-")
                .Replace("/", "_")
                .Replace("=", "");
        }

        // Method to send notification emails with enhanced formatting
        public void SendNotificationDueBorrowDate(string email, string body)
        {
            string subject = "Library Borrowing Due Date Reminder";
            UserCredential credential;

            // Load credentials from the credentials.json file
            using (FileStream stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                    ".credentials/gmail-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            // Define the HTML content of the email
            string htmlContent = $@"
            <html>
            <head>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        line-height: 1.6;
                    }}
                    .container {{
                        width: 80%;
                        margin: auto;
                        padding: 20px;
                        border: 1px solid #ddd;
                        border-radius: 5px;
                        background-color: #f9f9f9;
                    }}
                    .header {{
                        background-color: #4CAF50;
                        color: white;
                        padding: 10px 0;
                        text-align: center;
                        border-radius: 5px 5px 0 0;
                    }}
                    .content {{
                        margin: 20px 0;
                    }}
                    .footer {{
                        font-size: 0.9em;
                        color: #555;
                        text-align: center;
                        margin-top: 20px;
                    }}
                </style>
            </head>
            <body>
                <div class='container'>
                    <div class='header'>
                        <h1>Library Borrowing Due Date Reminder</h1>
                    </div>
                    <div class='content'>
                        {body}
                    </div>
                    <div class='footer'>
                        <p>Please return the borrowed items by the due date to avoid any late fees.</p>
                        <p>Thank you for using our library services!</p>
                    </div>
                </div>
            </body>
            </html>";

            // Construct the email message
            string message = $"To: {email}\r\n" +
                             $"Subject: {subject}\r\n" +
                             "Content-Type: text/html; charset=utf-8\r\n\r\n" +
                             htmlContent;

            // Initialize the Gmail API service
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Encode the message and send it
            var msg = new Google.Apis.Gmail.v1.Data.Message
            {
                Raw = Base64UrlEncode(message)
            };
            service.Users.Messages.Send(msg, "me").Execute();

            Console.WriteLine("Your email has been successfully sent!");
        }
    }
}
