using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class SessionRequest
    {
        public string SurveyId { get; set; }
        public string Language { get; set; }
        public bool Advance { get; set; }
        public object EmbeddedData { get; set; }
        public string RecipientId { get; set; }
        public string DistributionId { get; set; }
        public object Responses { get; set; }
    }
}
