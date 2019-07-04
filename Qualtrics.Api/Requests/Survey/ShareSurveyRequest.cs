using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class ShareSurveyRequest
    {
        public string SurveyId { get; set; }
        public string UserId { get; set; }
        public object Permissions { get; set; }
    }
}
