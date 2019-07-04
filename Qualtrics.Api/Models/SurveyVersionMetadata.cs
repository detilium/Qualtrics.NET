using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class SurveyVersionMetadata
    {
        public string SurveyId { get; set; }
        public string VersionId { get; set; }
        public int VersionNumber { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Published { get; set; }
        public bool WasPublished { get; set; }
        public List<PublishEvent> PublishEvents { get; set; }
    }
}
