using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class ResponseImportResponse : BaseResponse
    {
        public StartImportResponse Result { get; set; }
    }

    public class StartImportResponse
    {
        public string ProgressId { get; set; }
        public float PercentComplete { get; set; }
        public string Status { get; set; }
    }
}
