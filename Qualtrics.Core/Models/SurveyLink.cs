using System;

namespace Qualtrics.Core.Models
{
    public class SurveyLink
    {
        public string SurveyId { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Type { get; set; } = "Individual";
    }
}
