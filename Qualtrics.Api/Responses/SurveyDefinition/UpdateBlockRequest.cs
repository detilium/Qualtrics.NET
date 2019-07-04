using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class UpdateBlockRequest
    {
        public string BlockId { get; set; }
        public string SurveyId { get; set; }
        public Block Block { get; set; }
    }
}
