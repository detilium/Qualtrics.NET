using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface ISurveyResponseImportService
    {
        ResponseImportResponse StartResponseImport(string surveyId, string rawData);
        ResponseImportResponse StartResponseImport(string surveyId, object data);
        ResponseImportResponse StartResponseImportByUrl(string surveyId, Formats format, string fileUrl);
        ResponseImportResponse GetResponseImportProgress(string progressId, string surveyId);
    }
}
