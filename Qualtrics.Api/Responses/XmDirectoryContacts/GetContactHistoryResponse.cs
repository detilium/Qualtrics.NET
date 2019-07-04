using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class GetContactHistoryResponse : BaseResponse
    {
        public GetContactHistory Result { get; set; }
    }

    public class GetContactHistory
    {
        public List<ContactHistory> Elements { get; set; }
        public string NextPage { get; set; }
    }
}
