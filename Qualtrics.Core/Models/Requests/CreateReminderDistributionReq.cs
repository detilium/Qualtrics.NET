namespace Qualtrics.Core.Models
{
    public class CreateReminderDistributionReq
    {
        public string SendDate { get; set; }
        public Header Header { get; set; }
        public Message Message { get; set; }
        public dynamic EmbeddedData { get; set; }
    }
}
