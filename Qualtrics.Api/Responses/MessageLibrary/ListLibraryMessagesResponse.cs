using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class ListLibraryMessagesResponse : BaseResponse
    {
        public ListLibraryMessages Result { get; set; }
    }

    public class ListLibraryMessages
    {
        public List<Message> Elements { get; set; }
        public string NextPage { get; set; }
    }
}
