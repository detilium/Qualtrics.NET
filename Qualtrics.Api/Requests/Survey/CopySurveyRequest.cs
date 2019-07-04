using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class CopySurveyRequest
    {
        public string ProjectName { get; set; }
        public string SurveyId { get; set; }
        public string UserId { get; set; }
    }
}
