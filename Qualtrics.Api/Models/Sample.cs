using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class Sample
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ExternalDataReference { get; set; }
        public bool Unsubscribed { get; set; }
        public Dictionary<string, string> EmbeddedData { get; set; }
        public string Language { get; set; }
        public List<ResponseHistoryElement> ResponseHistory { get; set; }
        public List<EmailHistoryElement> RecipientEmailHistory { get; set; }
    }
}
