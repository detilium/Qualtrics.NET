using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class SurveyFlow
    {
        public List<FlowElement> Flow { get; set; }
        public string FlowId { get; set; }
        public object Properties { get; set; }
        public string Type { get; set; }
    }
}
