using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class ImportSurveyDefinitionResponse : BaseResponse
    {
        public ImportSurveyDefinition Result { get; set; }
    }

    public class ImportSurveyDefinition
    {
        public string SurveyId { get; set; }
    }
}
