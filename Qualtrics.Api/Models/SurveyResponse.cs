using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class SurveyResponse
    {
        public string ResponseId { get; set; }
        public ResponseValues Values { get; set; }
        public Dictionary<string, string> Labels { get; set; }
    }

    public class ResponseValues
    {
        public string DistributionChannel { get; set; }
        public int Duration { get; set; }
        public DateTime? EndDate { get; set; }
        public int Finished { get; set; }
        public string LocationLatitude { get; set; }
        public string LocationLongitude { get; set; }
        public int Progress { get; set; }
        public DateTime? RecordedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public int Status { get; set; }
    }
}
