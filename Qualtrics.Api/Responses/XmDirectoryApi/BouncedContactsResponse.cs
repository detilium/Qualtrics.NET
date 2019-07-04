using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class BouncedContactsResponse : BaseResponse
    {
        public BouncedContacts Result { get; set; }
    }

    public class BouncedContacts
    {
        public List<Contact> Elements { get; set; }
        public string NextPage { get; set; }
    }
}
