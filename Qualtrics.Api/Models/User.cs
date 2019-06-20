using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class User
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserType { get; set; }
        public string OrganizationId { get; set; }
        public string DivisionId { get; set; }
        public string Language { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public bool Unsubscribed { get; set; }
        public DateTime AccountCreationDate { get; set; }
        public DateTime? AccountExpirationDate { get; set; }
        public DateTime? PasswordLastChangedDate { get; set; }
        public DateTime? PasswordExpirationDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string TimeZone { get; set; }
        public ResponseCounts ResponseCounts { get; set; }
        public PermissionScheme Permissions { get; set; }
    }
}
