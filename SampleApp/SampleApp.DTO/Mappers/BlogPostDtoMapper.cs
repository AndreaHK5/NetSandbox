using AutoMapper;
using SampleApp.Models;

namespace SampleApp.DTO.Mappers
{
    public class BlogPostDtoMapper : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<BlogPost, BlogPostDto>()
                .ForMember(post => post.Content, opt => opt.MapFrom(p => p.Content))
                .ForMember(post => post.Content, opt => opt.MapFrom(p => p.Content));
        }
    }
}