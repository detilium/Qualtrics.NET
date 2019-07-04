using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class CreateBlockRequest
    {
        public string SurveyId { get; set; }
        public Block Block { get; set; }
    }
}
