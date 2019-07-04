using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class UpdateDivisionRequest
    {
        public string DivisionId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public object Permissions { get; set; }
    }
}
