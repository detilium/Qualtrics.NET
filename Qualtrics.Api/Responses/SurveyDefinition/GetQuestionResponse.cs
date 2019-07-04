using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class GetQuestionResponse : BaseResponse
    {
        public Question Result { get; set; }
    }

    public class GetQuestionResponse<T> : BaseResponse
    {
        public T Result { get; set; }
    }
}
