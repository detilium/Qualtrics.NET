using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class Subscription
    {
        public string Id { get; set; }
        public string Scope { get; set; }
        public string Topics { get; set; }
        public string PublicationUrl { get; set; }
        public bool Encrypted { get; set; }
        public int SuccessfulCalls { get; set; }
    }
}
