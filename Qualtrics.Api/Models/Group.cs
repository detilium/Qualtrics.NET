using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class Group
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string OrganizationId { get; set; }
        public string DivisionId { get; set; }
        public string Name { get; set; }
        public bool AutoMembership { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatorId { get; set; }
    }
}
