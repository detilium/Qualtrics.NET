using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class SurveyQuota
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int Quota { get; set; }
        public string LogicType { get; set; }
    }
}
