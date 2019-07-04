using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface IXmDirectoryMailingListService
    {
        XmListMailingListResponse ListMailingLists(string directoryId, int? pageSize = null, int? offset = null, string skipToken = null, string ownerId = null);
        GetMailingListResponse GetMailingList(string mailingListId, string directoryId);
        SimpleIdResponse CreateMailingList(string name, string directoryId, string ownerId = null);
        BaseResponse UpdateMailingList(string name, string mailingListId, string directoryId, string ownerId = null);
        BaseResponse DeleteDirectoryMailingList(string mailingListId, string directoryId);
    }
}
