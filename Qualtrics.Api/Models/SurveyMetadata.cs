using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class SurveyMetadata
    {
        public string SurveyId { get; set; }
        public string SurveyName { get; set; }
        public string SurveyDescription { get; set; }
        public string SurveyOwnerId { get; set; }
        public string SurveyBrandId { get; set; }
        public string DivisionId { get; set; }
        public string SurveyLangauge { get; set; }
        public string SurveyActiveResponseSet { get; set; }
        public string SurveyStatus { get; set; }
        public DateTime? SurveyStartDate { get; set; }
        public DateTime? SurveyExpirationDate { get; set; }
        public DateTime SurveyCreationDate { get; set; }
        public string CreatorId { get; set; }
        public DateTime? LastModified { get; set; }
        public DateTime? LastAccessed { get; set; }
        public DateTime? LastActivated { get; set; }
        public bool Deleted { get; set; }
    }
}
