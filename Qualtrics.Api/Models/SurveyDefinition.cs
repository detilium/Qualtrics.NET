using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class SurveyDefinition
    {
        public string SurveyId { get; set; }
        public string SurveyName { get; set; }
        public string SurveyStatus { get; set; }
        public DateTime? LastModified { get; set; }
        public string BrandId { get; set; }
        public string OwnerId { get; set; }
        public DateTime? LastAccessed { get; set; }
        public string CreateorId { get; set; }
        public Dictionary<string, Block> Blocks { get; set; }
        public Dictionary<string, string> ResponseSets { get; set; }
        public SurveyFlow SurveyFlow { get; set; }
        public SurveyScoring Scoring { get; set; }
        public ProjectInfo ProjectInfo { get; set; }
        public string BrandBaseUrl { get; set; }
        public List<Question> Questions { get; set; }

        public Options SurveyOptions { get; set; }
    }
}
