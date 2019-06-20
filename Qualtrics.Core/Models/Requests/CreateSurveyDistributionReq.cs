namespace Qualtrics.Core.Models
{
    public class CreateSurveyDistributionReq
    {
        public string SendDate { get; set; }
        public Header Header { get; set; }
        public Recipients Recipients { get; set; }
        public Message Message { get; set; }
        public SurveyLink SurveyLink { get; set; }
        public dynamic EmbeddedData { get; set; }
    }
}
