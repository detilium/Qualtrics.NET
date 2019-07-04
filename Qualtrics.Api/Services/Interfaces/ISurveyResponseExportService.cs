using Qualtrics.Api.Requests;
using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface ISurveyResponseExportService
    {
        ResponseExportResponse CreateResponseExport(CreateResponseExtportRequest creteResponseExtportRequest);
        ResponseExportResponse GetResponseExportProgress(string exportProgressId, Formats format, string surveyId);
        object GetResponseExportFile(string fileId, string surveyId);
    }
}
