using Qualtrics.Api.Models;
using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface IXmDirectoryContactService
    {
        GetDirectoryContactsResponse ListDirectoryContacts(string directoryId, int? pageSize = null, int? offset = null, string skipToken = null); //TODO(chaa): Remember "useNewPaginationScheme" if pagination details have been defined
        GetDirectoryContactResponse GetDirectoryContact(string contactId, string directoryId);
        GetContactHistoryResponse GetContactHistory(string contactId, string directoryId, ContactHistoryType type, int? pageSize = null, int? offset = null);
        SimpleIdResponse CreateDirectoryContact(object contact, string directoryId);
        BaseResponse UpdateDirectoryContact(object contact, string contactId, string directoryId);
        BaseResponse DeleteDirectoryContact(string contactId, string directoryId);
        SearchContactsResponse SearchContacts(List<SearchFilter> filters, SearchFilterConjunction conjunction, string directoryId, int? pageSize = null, string skipToken = null);
    }
}
