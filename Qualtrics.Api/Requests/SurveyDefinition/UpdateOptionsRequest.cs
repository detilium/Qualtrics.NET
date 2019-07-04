using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class UpdateOptionsRequest
    {
        public string SurveyId { get; set; }
        public Options Options { get; set; }
    }
}
