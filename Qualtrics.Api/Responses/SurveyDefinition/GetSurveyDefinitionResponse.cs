using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class GetSurveyDefinitionResponse : BaseResponse
    {
        public SurveyDefinition Result { get; set; }
    }
}
