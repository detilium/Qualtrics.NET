using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class UpdateUserRequest
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserType { get; set; }
        public string DivisionId { get; set; }
        public string Status { get; set; }
        public string TimeZone { get; set; }
        public DateTime AccountExpirationDate { get; set; }
        public object Permissions { get; set; }
    }
}
