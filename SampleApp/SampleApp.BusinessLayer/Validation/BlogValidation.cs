using FluentValidation;
using SampleApp.DTO;

namespace SampleApp.BusinessLayer.Validation
{
    public class BlogValidation : AbstractValidator<BlogDto> {
        /// <summary>
        /// Validation for the Blog model
        /// </summary>
        public BlogValidation() {
            RuleFor(blog => blog.AuthorName)
                .NotEmpty()
                .WithMessage("AuthorName must be present");
            RuleFor(blog => blog.Title)
                .NotEmpty().WithMessage("Title Must be present");
        }
    }
}
