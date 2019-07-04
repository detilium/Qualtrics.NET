using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class CreateBlockResponse
    {
        public CreateBlock Result { get; set; }
    }

    public class CreateBlock
    {
        public string BlockId { get; set; }
        public string FlowId { get; set; }
    }
}
