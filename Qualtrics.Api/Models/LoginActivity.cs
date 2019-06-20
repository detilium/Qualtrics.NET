using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class LoginActivity
    {
        public int TotalUsers { get; set; }
        public int Past1Days { get; set; }
        public int Past7Days { get; set; }
        public int Past14Days { get; set; }
        public int Past30Days { get; set; }
        public int Past60Days { get; set; }
        public int Past90Days { get; set; }
        public int Past120Days { get; set; }
        public int Ever { get; set; }
        public int Never { get; set; }
    }
}
