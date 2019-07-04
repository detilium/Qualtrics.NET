using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class ContactsImportProgressResponse : BaseResponse
    {
        public ContactsImportProgress Result { get; set; }
    }

    public class ContactsImportProgress
    {
        public float PercentComplete { get; set; }
        public string Status { get; set; }
        public ImportContactsStatus Contacts { get; set; }
        public string[] InvalidEmails { get; set; }
    }

    public class ImportContactsStatus
    {
        public ImportContactsCount Count { get; set; }
    }

    public class ImportContactsCount
    {
        public int Added { get; set; }
        public int Updates { get; set; }
        public int Failed { get; set; }
    }
}
