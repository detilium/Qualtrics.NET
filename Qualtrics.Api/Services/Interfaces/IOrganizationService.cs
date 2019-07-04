using Qualtrics.Api.Models;
using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface IOrganizationService
    {
        GetOrganizationResponse GetOrganization(string organizationId);
    }
}
