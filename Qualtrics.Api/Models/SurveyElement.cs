using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class SurveyElement
    {
        public string SurveyId { get; set; }
        public string Element { get; set; }
        public string PrimaryAttribute { get; set; }
        public string SecondaryAttribute { get; set; }
        public string TertiaryAttribute { get; set; }
        public List<object> Payload { get; set; }
    }
}
