using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class SessionQuestion
    {
        public string QuestionId { get; set; }
        public string Type { get; set; }
        public string Display { get; set; }
        public SessionQuestionOptions Options { get; set; }
        public List<SessionQuestionChoice> Choices { get; set; }
    }

    public class SessionQuestionOptions
    {
        public bool MultiSelect { get; set; }
    }

    public class SessionQuestionChoice
    {
        public int ChoideId { get; set; }
        public string Display { get; set; }
        public bool Textual { get; set; }
    }
}
