using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class UpdateGroupRequest
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string DivisionId { get; set; }
        public string Name { get; set; }
    }
}
