using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    //TODO: What are these properties?!
    public class ProjectInfo
    {
        public string SurveyId { get; set; }
        public string ProjectCategory { get; set; }
        public string ProjectType { get; set; }
        public string CompositionType { get; set; }
        public object ContentBundle { get; set; }
    }
}
