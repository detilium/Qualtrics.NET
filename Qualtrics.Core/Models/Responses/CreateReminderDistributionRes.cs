namespace Qualtrics.Core.Models
{
    public class CreateReminderDistributionRes
    {
        public CreateReminderDistributionResult Result { get; set; }
        public ResponseMeta Meta { get; set; }
    }

    public class CreateReminderDistributionResult
    {
        public string DistributionId { get; set; }
    }
}
