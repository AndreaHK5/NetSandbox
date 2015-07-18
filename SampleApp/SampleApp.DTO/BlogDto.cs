using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.DTO
{
    public class BlogDto {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public List<BlogPostDto> Posts { get; set; }
    }
}
