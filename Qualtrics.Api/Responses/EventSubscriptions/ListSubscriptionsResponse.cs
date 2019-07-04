using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class ListSubscriptionsResponse : BaseResponse
    {
        public ListSubscriptions Result { get; set; }
    }

    public class ListSubscriptions
    {
        public List<Subscription> Elements { get; set; }
        public string NextPage { get; set; }
    }
}
