using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class DeleteSurveyResponse : BaseResponse
    {
        public DeleteSurvey Result { get; set; }
    }

    public class DeleteSurvey
    {
        public DateTime DeletedDate { get; set; }
    }
}
