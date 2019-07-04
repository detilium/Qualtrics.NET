using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class BaseResponse
    {
        public Meta Meta { get; set; }

        public bool IsSuccess
        {
            get
            {
                if (Meta != null)
                    return Meta.HttpStatus.Contains("200");

                return false;
            }
        }
    }
}
