using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class CreateResponseExtportRequest
    {
        public Formats Format { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Limit { get; set; }
        public bool UseLabels { get; set; }
        public int SeenUnansweredRecode { get; set; }
        public int MultiselectSeenUnansweredRecode { get; set; }
        public bool IncludeDisplayOrder { get; set; }
        public bool FormatDecimalAsComma { get; set; }
        public TimeZones TimeZone { get; set; }
        public string NweLineReplacement { get; set; }
        public string[] QuestionIds { get; set; }
        public string[] EmbeddedDataIds { get; set; }
        public string[] SurveyMetadataIds { get; set; }
        public bool Compress { get; set; }
        public bool ExportResponseInProgress { get; set; }
    }
}