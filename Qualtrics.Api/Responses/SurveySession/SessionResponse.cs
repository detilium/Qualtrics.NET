using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class SessionResponse : BaseResponse
    {
        public Session Result { get; set; }

    }

    public class SessionResponse<T> : BaseResponse
    {
        public Session<T> Result { get; set; }

    }

    public class BaseSession
    {
        public string SessionId { get; set; }
        public List<SessionQuestion> Questions { get; set; }
        public Dictionary<string, object> Responses { get; set; }
        public bool Done { get; set; }
    }

    public class Session : BaseSession
    {
        public object EmbeddedData { get; set; }
    }

    public class Session<T> : BaseSession
    {
        public T EmbeddedData { get; set; }
    }
}
