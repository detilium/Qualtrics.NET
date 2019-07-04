'using System;
using Qualtrics.Api.Models;
using Qualtrics.Api.Requests;
using Qualtrics.Api.Responses;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface IDivisionService
    {
        SimpleIdResponse CreateDivision(CreateDivisionRequest createDivisionModel);
        GetDivisionResponse GetDivision(string divisionId);
        BaseResponse UpdateDivision(UpdateDivisionRequest updateDivisionModel);
    }
}
