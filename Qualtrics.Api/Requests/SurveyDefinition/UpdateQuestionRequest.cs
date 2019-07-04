using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class UpdateQuestionRequest
    {
        public string QuestionId { get; set; }
        public string SurveyId { get; set; }
        public Question Question { get; set; }
    }
}
