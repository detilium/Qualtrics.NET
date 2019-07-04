using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class SampleResponse : BaseResponse
    {
        public Samples Result { get; set; }
    }

    public class Samples
    {
        public List<Sample> Elements { get; set; }
        public string NextPage { get; set; }
    }
}
