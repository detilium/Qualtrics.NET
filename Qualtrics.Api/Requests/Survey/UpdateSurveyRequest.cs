using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class UpdateSurveyRequest
    {
        public string SurveyId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public ExpirationSpan Expiration { get; set; }
    }
}
