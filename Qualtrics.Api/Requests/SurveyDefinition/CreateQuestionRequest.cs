using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class CreateQuestionRequest
    {
        public string SurveyId { get; set; }
        public string BlockId { get; set; }
        public Question Question { get; set; }
    }
}
