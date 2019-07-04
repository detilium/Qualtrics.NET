using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class MailingList
    {
        public string Id { get; set; }
        public string LibraryId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Folder { get; set; }
    }
}
