using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class CreateNewResponseRequest
    {
        public string SurveyId { get; set; }
        public Dictionary<string, string> Values { get; set; }
        public string IdempotencyKey { get; set; }
    }
}
