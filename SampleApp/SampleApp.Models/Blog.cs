using System.Collections.Generic;
using Norman.Data.Persistence;

namespace SampleApp.Models
{
    public class Blog : BaseDataObject {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public List<BlogPost> Posts { get; set; } 
    }
}
