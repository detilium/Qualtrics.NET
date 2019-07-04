using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class CreateQuestionResponse : BaseResponse
    {
        public QuestionIdResponse Result { get; set; }
    }

    public class QuestionIdResponse
    {
        public string QuestionId { get; set; }
    }
}
