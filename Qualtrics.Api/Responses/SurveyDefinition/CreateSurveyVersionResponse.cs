using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class CreateSurveyVersionResponse : BaseResponse
    {
        public CreateSurveyVersion Result { get; set; }
    }

    public class CreateSurveyVersion
    {
        public SurveyVersionMetadata Metadata { get; set; }
    }    
}
