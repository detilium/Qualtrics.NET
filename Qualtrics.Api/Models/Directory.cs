using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class Directory
    {
        public string DirectoryId { get; set; }
        public string Name { get; set; }
        public int ContactCount { get; set; }
        public bool IsDefault { get; set; }
        public object DeduplicationCriteria { get; set; }
    }
}
