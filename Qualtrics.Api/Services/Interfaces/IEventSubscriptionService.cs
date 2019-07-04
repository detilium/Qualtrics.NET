using Qualtrics.Api.Requests;
using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface IEventSubscriptionService
    {
        ListSubscriptionsResponse ListSubscriptions(int? offset = null);
        GetSubscriptionResponse GetSubscription(string subscriptionId);
        SimpleIdResponse CreateSusbcription(CreateSubscriptionRequest createSubscriptionRequest);
    }
}
