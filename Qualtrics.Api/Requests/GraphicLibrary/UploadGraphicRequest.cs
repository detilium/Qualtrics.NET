using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class UploadGraphicRequest
    {
        public string Name { get; set; }
        public string FileUrl { get; set; }
        public GraphicContentType ContentType { get; set; }
        public string Folder { get; set; }
        public string LibraryId { get; set; }
    }
}
