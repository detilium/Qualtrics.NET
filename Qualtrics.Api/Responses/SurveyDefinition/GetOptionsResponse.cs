using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class GetOptionsResponse : BaseResponse
    {
        public Options Result { get; set; }
    }

    public class GetOptionsResponse<T> : BaseResponse
    {
        public T Result { get; set; }
    }
}
