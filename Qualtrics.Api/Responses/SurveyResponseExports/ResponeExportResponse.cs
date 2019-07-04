using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class ResponseExportResponse : BaseResponse
    {
        public ResponseExport Result { get; set; }
    }

    public class ResponseExport
    {
        public string ProgressId { get; set; }
        public float PrcentComplete { get; set; }
        public string Status { get; set; }
        public string FileId { get; set; }
    }
}
