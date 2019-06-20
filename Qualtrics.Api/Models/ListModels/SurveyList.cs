using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class SurveyList
    {
        public IEnumerable<Survey> Elements { get; set; }
        public string NextPage { get; set; }
    }
}
