using System.Collections.Generic;

namespace Qualtrics.Core.Models
{
    public class CreateContactsImportReq
    {
        public string MailingListId { get; set; }
        public List<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
