using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class CreateSubscriptionRequest
    {
        public string PublicationUrl { get; set; }
        public string Topics { get; set; }
        public bool Encrypt { get; set; }
        public string SharedKey { get; set; }
    }
}
