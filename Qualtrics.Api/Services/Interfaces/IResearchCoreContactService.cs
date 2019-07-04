using Qualtrics.Api.Models;
using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface IResearchCoreContactService
    {
        #region Mailing lists

        GetMailingListResponse GetMailingList(string mailingListId);
        ListMailingListResponse ListMailingList(int? offset = null);
        SimpleIdResponse CreateMailingList(string name, string libraryId, string category = null);
        BaseResponse UpdateMailingList(string mailingListId, string libraryId, string name = null, string category = null);
        BaseResponse DeleteMailingList(string mailingListId);

        #endregion

        #region Contacts

        ListContactsResponse ListContacts(string mailingListId, string skipToken = null);
        GetContactResponse GetContact(string contactId, string mailingListId);
        SimpleIdResponse CreateContact(Contact contact, string mailingListId);
        BaseResponse UpdateContact(Contact contact, string contactId, string mailingListId);
        BaseResponse DeleteContact(string contactId, string mailingListId);
        SimpleIdResponse CreateContactsImport(string jsonContent, string mailingListId, string contentType = "application/json");
        SimpleIdResponse CreateContactsImport(object data, string mailingListId, string contentType = "application/json");
        SimpleIdResponse CreateContactsImportFormUrl(string mailingListId, string fileUrl, string contentType = "application/json");
        ContactsImportProgressResponse GetContactsImportProgress(string importId, string mailingListId);
        ContactsImportProgressResponse GetContactsImportProgressSummary(string importId, string mailingListId);

        #endregion

        #region Samples

        SampleResponse ListSamples(string mailingListId);
        SampleResponse GetSample(string sampleId, string mailingListId);

        #endregion
    }
}
