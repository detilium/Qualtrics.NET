using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class Contact
    {
        public string Id { get; set; }
        public string ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ExtRef { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastModified { get; set; }

        public bool DirectoryUnsubscribed { get; set; }
        public DateTime? DirectoryUnsubscribedDate { get; set; }
        public bool MailingListUnsubscribed { get; set; }
        public DateTime? MailingListUnsubscribedDate { get; set; }

        public string ExternalDataReference { get; set; }
        public Dictionary<string, string> EmbeddedData { get; set; }
        public string Language { get; set; }
        public bool Unsubscribed { get; set; }
        public DateTime? UnsubscribeDate { get; set; }
        public List<ResponseHistoryElement> ResponseHistory { get; set; }
        public List<EmailHistoryElement> EmailHistory { get; set; }
        public ContactStats Stats { get; set; }
    }

    public class ContactStats
    {
        public int AvgTimeToRespond { get; set; }
        public int DataIntegrity { get; set; }
        public int EmailCount { get; set; }
        public int InviteCount { get; set; }
        public DateTime? LastEmailDate { get; set; }
        public DateTime? LastInviteDate { get; set; }
        public DateTime? LastResponseDate { get; set; }
        public int MonthEmailCount { get; set; }
        public int MonthInviteCount { get; set; }
        public int Points { get; set; }
        public int ResponseCount { get; set; }
        public float ResponseRate { get; set; }
    }
}
