using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class CreateUserRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserType { get; set; }
        public string Email { get; set; }
        public string Langauge { get; set; }
        public string TimeZone { get; set; }
        public string DivisionId { get; set; }
        public DateTime AccountExpirationDate { get; set; }
    }
}
