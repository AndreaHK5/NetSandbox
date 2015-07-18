using AutoMapper;
using SampleApp.Models;

namespace SampleApp.DTO.Mappers {
    /// <summary>
    /// Maps a Blog to a BlogDto
    /// </summary>
    public class BlogDtoMapper : Profile {
        protected override void Configure() {
            Mapper.CreateMap<Blog, BlogDto>()
                .ForMember(blogDto => blogDto.AuthorName, opt => opt.MapFrom(b => b.AuthorName))
                .ForMember(blogDto => blogDto.Title, opt => opt.MapFrom(b => b.Title))
                .ForMember(blogDto => blogDto.Posts, opt => opt.MapFrom(b => b.Posts));
        }
    }
}
