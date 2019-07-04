using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class CreateDivisionRequest
    {
        public string Name { get; set; }
        public List<string> DivisionAdmins { get; set; }
        public object Permissions { get; set; }
    }
}
