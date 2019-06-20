using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class PermissionScheme
    {
        public ControlPanelPermissions ControlPanel { get; set; }
        public SiteInterceptPermissions SiteIntercept { get; set; }
        public ContactPermissions Contacts { get; set; }
    }

    public class ControlPanelPermissions
    {
        public Dictionary<string, Permission> AccountPermissions { get; set; }
        public Dictionary<string, Permission> OrgianizationPermissions { get; set; }
        public Dictionary<string, Permission> QuestionPermissions { get; set; }
        public Dictionary<string, Permission> SurveryPermissions { get; set; }
    }

    public class SiteInterceptPermissions
    {

    }

    public class ContactPermissions
    {

    }

    public class Permission
    {
        public string CalculatedState { get; set; }
        public string State { get; set; }
    }
}
