using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface IXmDirectoryApiService
    {
        BouncedContactsResponse GetBouncesContacts(string directoryId, string mailingListId, DateTime? since = null, string pageSize = null, string skipToken = null);
        OptedOutContacts GetOptedOutContacts(string directoryId, string mailingListId, int? pageSize = null, string skipToken = null);
        BrandDirectoriesResponse GetDirectoriesForBrand(int? pageSize = null, string skipToken = null);
    }
}
