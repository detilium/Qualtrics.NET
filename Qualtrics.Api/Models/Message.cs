using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class Message
    {
        public string Id { get; set; }
        public string LibraryId { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public Dictionary<string, string> Messages { get; set; }
    }
}
