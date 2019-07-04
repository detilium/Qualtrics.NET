using Qualtrics.Api.Requests;
using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface ISurveyDefinitionService
    {
        #region Questions

        GetQuestionResponse GetQuestion(string surveyId, string questionId);
        GetQuestionResponse<T> GetQuestion<T>(string surveyId, string questionId);
        ListQuestionsResponse ListQuestions(string surveyId);
        ListQuestionsResponse<T> ListQuestions<T>(string surveyId);
        CreateQuestionResponse CreateQuestion(CreateQuestionRequest createQuestionRequest);
        BaseResponse UpdateQuestion(UpdateQuestionRequest updateQuestionRequest);
        BaseResponse DeleteQuestion(string questionId, string surveyId);

        #endregion

        #region Flows
        BaseResponse UpdateFlow(string surveyId, object flow);
        GetFlowResponse GetFlow(string surveyId);
        GetFlowResponse<T> GetFlow<T>(string surveyId);
        BaseResponse UpdateFlowElement(UpdateFlowElementsRequest updateFlowElementsRequest);

        #endregion

        #region Blocks

        GetBlockResponse GetBlock(string blockId, string surveyId);
        BaseResponse UpdateBlock(UpdateBlockRequest updateBlockRequest);
        BaseResponse DeleteBlock(string blockId, string surveyId); 
        CreateBlockResponse CreateBlock(CreateBlockRequest createBlockRequest);

        #endregion

        #region Options

        GetOptionsResponse GetOptions(string surveyId);
        GetOptionsResponse<T> GetOptions<T>(string surveyId);
        BaseResponse UpdateOptions(UpdateOptionsRequest updateOptionsRequest);

        #endregion

        #region Survey

        GetSurveyMetadataResponse GetSurveyMetaData(string surveyId);
        GetSurveyDefinitionResponse GetSurveyResponse(string surveyId);
        DeleteSurveyResponse DeleteSurvey(string surveyId);
        CreateSurveyResponse CreateSurvey(CreateSurveyRequest createSurveyRequest);
        ImportSurveyDefinitionResponse ImportSurveyDefinition(ImportSurveyDefinitionRequest importSurveyRequest);

        #endregion

        #region Versions

        CreateSurveyVersionResponse CreateSurveyVersion(string description, bool published);
        ListSurveyVersionsResponse ListSurveyVersions(string surveyId);
        GetSurveyVersionResponse GetSurveyVersion(string surveyId, string versionId);

        #endregion
    }
}
