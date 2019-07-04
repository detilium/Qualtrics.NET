using Qualtrics.Api.Requests;
using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface ISurveySessionService
    {
        SessionResponse CreateSession(SessionRequest createSessionRequest);
        SessionResponse UpdateSession(SessionRequest updateSessionRequest);
        SessionResponse GetSession(string sessionId, string surveyId);
        BaseResponse DeleteSession(string sessionId, string surveyId);
        BaseResponse CloseSession(string sessionId, bool close, string surveyId);
    }
}
