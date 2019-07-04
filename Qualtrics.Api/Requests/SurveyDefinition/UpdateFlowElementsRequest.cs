using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class UpdateFlowElementsRequest
    {
        public string FlowId { get; set; }
        public string SurveyId { get; set; }
        public object FlowElement { get; set; }
    }
}
