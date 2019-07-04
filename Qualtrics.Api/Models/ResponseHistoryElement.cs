using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class ResponseHistoryElement
    {
        public string ResponseId { get; set; }
        public string SurveyId { get; set; }
        public DateTime Date { get; set; }
        public string EmailDistributionId { get; set; }
        public bool FinishedSurvey { get; set; }
    }
}
