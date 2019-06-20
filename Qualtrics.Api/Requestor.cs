using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api
{
    internal class Requestor
    {
        private RestClient Client { get; set; }

        internal Requestor(string url, string apiToken)
        {
            Client = new RestClient(url);
            Client.AddDefaultHeader("X-API-TOKEN", apiToken);
            Client.AddDefaultHeader("Content-Type", "application/json");
        }
    }
}
