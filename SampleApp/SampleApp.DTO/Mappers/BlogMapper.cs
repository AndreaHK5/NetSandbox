using AutoMapper;
using SampleApp.Models;

namespace SampleApp.DTO.Mappers {
    /// <summary>
    /// Maps BlogDto into Blog
    /// </summary>
    public class BlogMapper : Profile {
        protected override void Configure() {
            Mapper.CreateMap<BlogDto, Blog>()
                .ForMember(blog => blog.AuthorName, opt => opt.MapFrom(b => b.AuthorName))
                .ForMember(blog => blog.Title, opt => opt.MapFrom(b => b.Title))
                .ForMember(blog => blog.Posts, opt => opt.MapFrom(b => b.Posts));
        }
    }
}
