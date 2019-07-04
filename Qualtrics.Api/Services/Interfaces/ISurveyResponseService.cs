using Qualtrics.Api.Requests;
using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface ISurveyResponseService
    {
        CreateNewResponseResponse CreateNewResponse(CreateNewResponseRequest createNewResponseRequest);
        RetrieveSurveyResponseResponse RetireveSurveyResponse(string responseId, string surveyId);
        BaseResponse DeleteSurveyResponse(string responseId, bool decrementQuotas, string surveyId);
    }
}
