using Qualtrics.Api.Models;
using Qualtrics.Api.Requests;
using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface ISurveyService
    {
        GetSurveyResponse GetSurvey(string surveyId);
        object UpdateSurvey(UpdateSurveyRequest updateSurveyRequest);
        T UpdateSurvey<T>(UpdateSurveyRequest updateSurveyRequest);
        BaseResponse DeleteSurvey(string surveyId);
        ListSurveysResponse ListSurveys(int offset = 0);
        SimpleIdResponse ImportSurveyFromUrl(ImportSurveyRequest importSurveyRequest);
        SimpleIdResponse ImportSurvey(ImportSurveyRequest importSurveyRequest);
        SimpleIdResponse CopySurvey(CopySurveyRequest copySurveyRequest);
        BaseResponse ShareSurvey(ShareSurveyRequest shareSurveyRequest);
        BaseResponse InsertEmbeddedDataFields(InsertEmbeddedDataFieldsRequest insertEmbeddedDataFieldsRequest);
        GetSurveyQuotasResponse GetSurveyQuotas(string surveyId);
        GetSurveyLanguageResponse GetSurveyLanguages(string surveyId);
        object GetSurveyTranslations(string surveyId, string languageCode);
        BaseResponse UpdateSurveyLanguages(string surveyId, List<string> availableLanguages);
        BaseResponse UpdateSurveyLanguages(string surveyId, string languageCode, object surveyFields);
    }
}
