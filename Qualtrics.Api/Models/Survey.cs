using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class Survey
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string OwnerId { get; set; }
        public string OrganizationId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public ExpirationSpan Expiration { get; set; }

        public Dictionary<string, SurveyQuestion> Question { get; set; }
        public Dictionary<string, SurveyColumn> ExportColumnMap { get; set; }
        public Dictionary<string, SurveyBlock> Blocks { get; set; }
        public IEnumerable<Flow> Flow { get; set; }
        public IEnumerable<EmbeddedDataEntry> EmbeddedData { get; set; }
        public Comment Comment { get; set; }
        public Dictionary<string, LoopAndMerge> LoopAndMerge { get; set; }
        public ResponseCounts ResponseCounts { get; set; }
    }

    public class ExpirationSpan
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

    public class SurveyQuestion
    {
        public QuestionType QuestionType { get; set; }
        public string QuestionText { get; set; }
        public string QuestionLabel { get; set; }
        public QuestionValidation Validation { get; set; }
        public string QuestionName { get; set; }

        public Dictionary<string, QuestionChoice> SubQuestions { get; set; }
        public Dictionary<string, QuestionChoice> Choices { get; set; }
    }

    public class QuestionType
    {
        public string Type { get; set; }
        public string Selector { get; set; }
        public string SubSelector { get; set; }
    }

    public class QuestionValidation
    {
        public bool DoesForceResponse { get; set; }
    }

    public class QuestionChoice
    {
        public string Recode { get; set; }
        public string Description { get; set; }
        public string ChoiceText { get; set; }
        public string ImageDescription { get; set; }
        public string VariableName { get; set; }
        public bool Analyze { get; set; }
    }

    public class SurveyColumn
    {
        public string Question { get; set; }
        public string SubQuestion { get; set; }
    }

    public class SurveyBlock
    {
        public string Description { get; set; }
        public IEnumerable<BlockElement> Elements { get; set; }
    }

    public class BlockElement
    {
        public string Type { get; set; }
        public string QuestionId { get; set; }
    }

    public class Flow
    {
        public string Id { get; set; }
        public string QuestionId { get; set; }
    }

    public class EmbeddedDataEntry
    {
        public string Name { get; set; }
        public string DefaultValue { get; set; }
    }

    public class Comment
    {

    }

    public class LoopAndMerge
    {
        public string LoopType { get; set; }
        public LoopQuestionMeta LoopQuestionMeta { get; set; }
        public RandomizationMeta RandomizationMeta { get; set; }
    }

    public class LoopQuestionMeta
    {
        public string QuestionId { get; set; }
        public string QuestionType { get; set; }
        public IEnumerable<LoopOnEntry> LoopOn { get; set; }
        public Dictionary<string, string[]> ColumnNames { get; set; }
    }

    public class LoopOnEntry
    {
        public string Criterion { get; set; }
    }

    public class RandomizationMeta
    {
        public string Randomize { get; set; }
        public string Limit { get; set; }
    }
}