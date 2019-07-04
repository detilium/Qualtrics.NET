using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class ContactHistory
    {
        public string DistributionId { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Result { get; set; }
        public string SurveyId { get; set; }
        public bool Read { get; set; }
    }
}
