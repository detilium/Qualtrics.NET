using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class CreateNewResponseResponse : BaseResponse
    {
        public CreateNewResponse Result { get; set; }
    }

    public class CreateNewResponse
    {
        public string ResponseId { get; set; }
    }
}
