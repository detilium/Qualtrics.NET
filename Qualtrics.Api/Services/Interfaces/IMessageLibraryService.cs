using Qualtrics.Api.Models;
using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface IMessageLibraryService
    {
        ListLibraryMessagesResponse ListLibraryMessages(string libraryId, string category = null, int? pageOffset = null);
        GetLibraryMessagesResponse GetLibraryMessage(string messageId, string libraryId);
        SimpleIdResponse CreateLibraryMessage(Message message);
        BaseResponse UpdateLibraryMessage(string messageId, string libraryId, string description = null, Dictionary<string, string> messages = null);
        BaseResponse DeleteLibraryMessage(string messageId, string libraryId);
    }
}
