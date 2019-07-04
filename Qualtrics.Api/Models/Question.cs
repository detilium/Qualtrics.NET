using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class Question
    {
        public string QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string DataExportTag { get; set; }
        public string QuestionType { get; set; }
        public string Selector { get; set; }
        public string SubSelector { get; set; }
        public string QuestionDescription { get; set; }
        public object Configuration { get; set; }
        public Dictionary<string, QuestionChoice> Choices { get; set; }
        public int[] ChoiceOrder { get; set; }
        public QuestionValidation Validation { get; set; }
        public object Language { get; set; }
        public int? NextChoiceId { get; set; }
        public int? NextAnswerId { get; set; }
        public QuestionDataVisibility DataVisibility { get; set; }

        //TODO: Json name is QuestionText_Unsafe
        public string QuestionTextUnsafe { get; set; }
    }
}
