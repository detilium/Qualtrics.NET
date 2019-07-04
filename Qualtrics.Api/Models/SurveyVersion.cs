using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class SurveyVersion
    {
        public int QuestionCount { get; set; }
        public Options SurveyOptions { get; set; }
        public string SurveyId { get; set; }
        public string SurveyName { get; set; }
        public DateTime? LastModified { get; set; }
        public string BranId { get; set; }
        public string OwnerId { get; set; }
        public DateTime? LastAccessed { get; set; }
        public string CreatorId { get; set; }
        public DateTime? LastActivated { get; set; }
        public List<Question> Question { get; set; }
        public Dictionary<string, Block> Blocks { get; set; }
        public object ResponseSets { get; set; }
        public SurveyFlow SurveyFlow { get; set; }
        public SurveyScoring Scoring { get; set; }
        public ProjectInfo ProjectInfo { get; set; }
        public SurveyVersionMetadata VersionMetadata { get; set; }
        public string BrandBaseUrl { get; set; }
    }
}
