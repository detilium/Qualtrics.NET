using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class Block
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public List<BlockElement> BlockElements { get; set; }
        public BlockOptions Options { get; set; }
    }

    public class BlockElement
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string QuestionId { get; set; }
    }

    public class BlockOptions
    {
        public bool BlockLocking { get; set; }
        public bool RandomizeQuestions { get; set; }
        public string BlockVisibility { get; set; }
    }
}
