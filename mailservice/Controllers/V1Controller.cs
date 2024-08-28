using Aspose.Email;
using Aspose.Email.Clients.Exchange;
using Aspose.Email.Clients.Exchange.WebService;
using HEKOutlookCheckerServiceGroup;
using mailservice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Tsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace mailservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class V1Controller : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private Timer _timer;
        private HashSet<string> _processedEmails;
        private readonly string _mailboxUri;
        private readonly string _domain;
        private readonly string _username;
        private readonly string _password;

        
        public V1Controller(IConfiguration configuration)
        {
            _configuration = configuration;
            _processedEmails = new HashSet<string>();
            _timer = new Timer(CheckEmails, null, TimeSpan.Zero, TimeSpan.FromMinutes(10));

            _mailboxUri = _configuration.GetValue<string>("EmailSettings:MailboxUri");
            _domain = _configuration.GetValue<string>("EmailSettings:Domain");
            _username = _configuration.GetValue<string>("EmailSettings:Username");
            _password = _configuration.GetValue<string>("EmailSettings:Password");
        }

        [HttpGet]
        public void CheckEmails(object state)
        
        {
            using (var hEKOutlookCheckerServiceClient = new HEKOutlookCheckerServiceClient())
            {
                try
                {
                    CallContext cc = new CallContext();
                    string AttachmentsPathResponse = hEKOutlookCheckerServiceClient.getSetupTable(cc);
                    if (AttachmentsPathResponse == "")
                    {
                        //error
                    }
                    NetworkCredential credentials = new NetworkCredential(_username, _password, _domain);
                    IEWSClient client = EWSClient.GetEWSClient(_mailboxUri, credentials);

                    ExchangeMessageInfoCollection msgCollection = client.ListMessages(client.MailboxInfo.DeletedItemsUri);
                    IEnumerable<ExchangeMessageInfo> lastHundred = msgCollection.OrderByDescending(m => m.Date).Take(1);
                     
                    foreach (ExchangeMessageInfo msgInfo in lastHundred)
                    {
                        if (_processedEmails.Contains(msgInfo.UniqueUri))
                        {
                            continue;
                        }

                        string originalString = client.FetchMessage(msgInfo.UniqueUri).Body;
                        string _body = FilterAsposeEvaluationMessage(originalString);
                        string htmlDocument = GenerateHTMLDocument(_body);

                        string _subject = msgInfo.Subject;
                        string _from = msgInfo.From.ToString();
                        string _to = msgInfo.To.ToString();
                        string _cc = msgInfo.CC.ToString();

                        string reqId = hEKOutlookCheckerServiceClient.insertItem(cc, _subject, _from, _to, _cc, htmlDocument);

                        foreach (Attachment attachment in client.FetchMessage(msgInfo.UniqueUri).Attachments)
                        {
                            MemoryStream attachmentStream = new MemoryStream();
                            attachment.Save(attachmentStream);

                            string uniqueAttachmentName = $"{Path.GetFileNameWithoutExtension(attachment.Name)}_{reqId}{Path.GetExtension(attachment.Name)}";
                            string savePath = Path.Combine(AttachmentsPathResponse, uniqueAttachmentName);
                            using (FileStream fs = new FileStream(savePath, FileMode.Create))
                            {
                                attachmentStream.Seek(0, SeekOrigin.Begin);
                                attachmentStream.CopyTo(fs);
                            }
                            attachmentStream.Close();
                        }

                        _processedEmails.Add(msgInfo.UniqueUri);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private string FilterAsposeEvaluationMessage(string originalString)
        {
            string[] lines = originalString.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            var filteredLines = lines
                .Where(line => !line.Contains("EVALUATION ONLY") && !line.Contains("http://www.aspose.com/corporate/purchase/end-user-license-agreement.aspx: View EULA Online"))
                .ToArray();

            var filteredString = string.Join("\r\n", filteredLines);

            return filteredString;
        }

        static string GenerateHTMLDocument(string content)
        {
            StringBuilder htmlBuilder = new StringBuilder();
            
            htmlBuilder.AppendLine("<!DOCTYPE html>");
            htmlBuilder.AppendLine("<html>");
            htmlBuilder.AppendLine("<head>");
            htmlBuilder.AppendLine("<title></title>");
            htmlBuilder.AppendLine("</head>");
            htmlBuilder.AppendLine("<body>");
            htmlBuilder.AppendLine("<p>" + content + "</p>");
            htmlBuilder.AppendLine("</body>");
            htmlBuilder.AppendLine("</html>");
           
            return htmlBuilder.ToString();
        }

    }
} 