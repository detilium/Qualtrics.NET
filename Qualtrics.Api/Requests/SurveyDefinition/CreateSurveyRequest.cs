using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class CreateSurveyRequest
    {
        public string SurveyName { get; set; }
        public string Language { get; set; }
        public string ProjectCategory { get; set; }
    }
}
