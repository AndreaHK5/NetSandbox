using AutoMapper;
using SampleApp.Models;

namespace SampleApp.DTO.Mappers {
    public class BlogPostMapper : Profile {
        protected override void Configure() {
            Mapper.CreateMap<BlogPostDto, BlogPost>()
                .ForMember(post => post.Content, opt => opt.MapFrom(p => p.Content))
                .ForMember(post => post.Content, opt => opt.MapFrom(p => p.Content));
        }
    }
}
