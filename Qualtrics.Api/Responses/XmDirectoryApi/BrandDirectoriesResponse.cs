using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class BrandDirectoriesResponse : BaseResponse
    {
        public BrandDirectories Result { get; set; }
    }

    public class BrandDirectories
    {
        public List<Directory> Elements { get; set; }
        public string NextPage { get; set; }
    }
}
