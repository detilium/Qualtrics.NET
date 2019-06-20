namespace Qualtrics.Core.Models
{
    public class GenericResponse
    {
        public GenericResult Result { get; set; }
        public ResponseMeta Meta { get; set; }
    }

    public class GenericResult
    {
        public string Id { get; set; }
    }
}
