using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class XmListMailingListResponse : BaseResponse
    {
        public XmListMailingList Result { get; set; }
    }

    public class XmListMailingList
    {
        public List<XmMailingList> Elements { get; set; }
        public string NextPage { get; set; }
    }
}
