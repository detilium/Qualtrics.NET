using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class GetFlowResponse : BaseResponse
    {
        public SurveyFlow Result { get; set; }
    }

    public class GetFlowResponse<T> : BaseResponse
    {
        public GetFlow<T> Result { get; set; }
    }

    public class GetFlow<T>
    {
        public List<FlowElement> Flow { get; set; }
        public string FlowId { get; set; }
        public T Properties { get; set; }
        public string Type { get; set; }
    }
}
