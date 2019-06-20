using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class Division
    {
        public string Id { get; set; }
        public string OrganizationId { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatorId { get; set; }
        public string Name { get; set; }
        public PermissionScheme Permissions { get; set; }
        public ResponseCounts ResponseCounts { get; set; }
        public Status Status { get; set; }
    }
}
