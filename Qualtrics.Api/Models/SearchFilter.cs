using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class SearchFilter
    {
        public string FilterType { get; set; }
        public string Value { get; set; }
        public SearchFilterComparison Comparison { get; set; }
    }
}
