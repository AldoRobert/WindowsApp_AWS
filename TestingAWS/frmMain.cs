using Amazon.Runtime;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.SQS;
using Amazon.SQS.Model;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System.Text.Json.Serialization;
using TestingAWS.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestingAWS
{
    public partial class frmMain : Form
    {
        private string url = "https://api.dailyquotes.dev/api/quotes/motivational";
        public frmMain()
        {
            InitializeComponent();
        }

        private async void btnSendSNS_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                var _quote = await GetQuotes();

                await Send_SNS(_quote);
            }
        }
        private async Task<Quote> GetQuotes()
        {
            var apiKey = Program.Configuration["AppSettings:APIKey"];


            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);

            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            var quote = JsonSerializer.Deserialize<Quote>(content);

            return quote;
        }

        private async Task Send_SNS(Quote quote)
        {

            var accessKey = Program.Configuration["AppSettings:AccessKeySNS"];
            var secret = Program.Configuration["AppSettings:SecretSNS"];


            var credentials = new BasicAWSCredentials(accessKey, secret);

            var client = new AmazonSimpleNotificationServiceClient(credentials, Amazon.RegionEndpoint.USEast2);

            var request = new PublishRequest()
            {
                TopicArn = "arn:aws:sns:us-east-2:050752614353:testing-sns",
                Message = JsonSerializer.Serialize(quote),
                Subject = "Quote"
            };

            var response = await client.PublishAsync(request);
        }
        private async Task Send_SQS(Quote quote)
        {
            var accessKey = Program.Configuration["AppSettings:AccessKeySQS"];
            var secret = Program.Configuration["AppSettings:SecretSQS"];

            var awsaccount = Program.Configuration["AppSettings:AWSAccount"];


            var credentials = new BasicAWSCredentials(accessKey, secret);


            var client = new AmazonSQSClient(credentials, Amazon.RegionEndpoint.USEast2);

            var request = new SendMessageRequest()
            {
                QueueUrl = "https://sqs.us-east-2.amazonaws.com/"+ awsaccount + "/quotes-sqs",
                MessageBody = JsonSerializer.Serialize(quote)
            };

            var response = await client.SendMessageAsync(request);
        }
        private async void btnSendSQS_Click(object sender, EventArgs e)
        {
            var _quote = await GetQuotes();

            await Send_SQS(_quote);
        }
    }
}
