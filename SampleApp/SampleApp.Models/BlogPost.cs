using Norman.Data.Persistence;

namespace SampleApp.Models
{
    public class BlogPost : BaseDataObject {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
