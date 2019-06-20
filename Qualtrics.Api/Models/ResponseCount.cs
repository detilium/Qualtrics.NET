using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class ResponseCounts
    {
        public int Auditable { get; set; }
        public int Generated { get; set; }
        public int Deleted { get; set; }
    }
}
