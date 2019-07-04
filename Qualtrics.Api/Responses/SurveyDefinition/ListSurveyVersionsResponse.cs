using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class ListSurveyVersionsResponse : BaseResponse
    {
        public ListSurveyVersions Result { get; set; }
    }

    public class ListSurveyVersions
    {
        public List<SurveyVersionMetadata> Elements { get; set; }
    }
}
