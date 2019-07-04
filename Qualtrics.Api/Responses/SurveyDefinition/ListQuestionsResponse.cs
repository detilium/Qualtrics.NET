using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class ListQuestionsResponse : BaseResponse
    {
        public ListQuestions Result { get; set; }
    }

    public class ListQuestionsResponse<T> : BaseResponse
    {
        public T Result { get; set; }
    }
}
