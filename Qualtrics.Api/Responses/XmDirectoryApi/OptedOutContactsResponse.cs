using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class OptedOutContactsResponse : BaseResponse
    {
        public OptedOutContacts Result { get; set; }
    }

    public class OptedOutContacts
    {
        public List<Contact> Elements { get; set; }
        public string NextPage { get; set; }
    }
}
