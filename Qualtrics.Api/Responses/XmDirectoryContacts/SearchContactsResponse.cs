using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class SearchContactsResponse : BaseResponse
    {
        public SearchContacts Result { get; set; }
    }

    public class SearchContacts
    {
        public List<Contact> Elements { get; set; }
        public string SkipToken { get; set; }
    }
}
