using Qualtrics.Api.Requests;
using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface IGraphicLibraryService
    {
        SimpleIdResponse UploadGraphic(UploadGraphicRequest uploadGraphicRequest);
        SimpleIdResponse UploadGraphicFromUrl(UploadGraphicRequest uploadGraphicRequest);
        BaseResponse DeleteGraphic(string graphicId, string libraryId);
    }
}
