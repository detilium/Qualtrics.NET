using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class ListGroupsResponse : BaseResponse
    {
        public GroupList Result { get; set; }
    }
}
