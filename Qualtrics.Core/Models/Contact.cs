namespace Qualtrics.Core.Models
{
    public class Contact
    {
        /// <summary>
        /// If included, the contact with this id will be updated.
        /// </summary>
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Language { get; set; } = "DK";
        public SubscriptionEnum Unsubscribed { get; set; } = SubscriptionEnum.Subscribed;
        public string ExternalReference { get; set; }
        public dynamic EmbeddedData { get; set; }
    }

    public enum SubscriptionEnum
    {
        Subscribed = 0,
        Unsubscribed = 1
    }
}
