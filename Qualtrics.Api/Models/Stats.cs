using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class Stats
    {
        public ResponseCounts ResponseCounts { get; set; }
        public SurveyCounts SurveyCounts { get; set; }
        public LoginActivity LoginActivity { get; set; }
    }
}
