using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class GetDirectoryContactsResponse : BaseResponse
    {
        public ListDirectoryContacts Result { get; set; }
    }

    public class ListDirectoryContacts
    {
        public List<Contact> Elements { get; set; }
        public string NextPage { get; set; }
    }
}
