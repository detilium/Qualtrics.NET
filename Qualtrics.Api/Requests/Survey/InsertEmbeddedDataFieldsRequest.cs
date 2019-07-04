using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class InsertEmbeddedDataFieldsRequest
    {
        public string SurveyId { get; set; }
        public string EmbeddedDataFields { get; set; }
    }
}
