using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class CreateSurveyResponse : BaseResponse
    {
        public CreateSurveyResult Result { get; set; }
    }

    public class CreateSurveyResult
    {
        public string SurveyId { get; set; }
        public string DefaultBlockId { get; set; }
    }
}
