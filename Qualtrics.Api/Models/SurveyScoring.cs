using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    //TODO: WHAT ARE THESE PROPERTIES!?
    public class SurveyScoring
    {
        public object[] ScoringCategories { get; set; }
        public object[] ScoringCategoryGroups { get; set; }
        public object ScoringSummaryCategory { get; set; }
        public int ScoringSummaryAfterQuestions { get; set; }
        public int ScoringSummaryAfterSurvey { get; set; }
        public object DefaultScoringCategory { get; set; }
        public object AutoScoringCategory { get; set; }
    }
}
