using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class ListMailingListResponse : BaseResponse
    {
        public ListMailingList Result { get; set; }
    }

    public class ListMailingList
    {
        public List<MailingList> Elements { get; set; }
        public string NextPage { get; set; }
    }
}
