using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using FluentValidation.Results;
using Newtonsoft.Json;

namespace SampleApp.BusinessLayer.Validation {
    /// <summary>
    /// Helper methods for validation
    /// </summary>
    public static class ValidationHelper  {

        /// <summary>
        /// return http message 400 Bad Request, with the content of the validation
        /// </summary>
        /// <param name="_results"></param>
        /// <returns></returns>
        public static HttpResponseMessage FailedValidationMessage(ValidationResult _results) {
            var validationErrors = _results.Errors.Select(error => error.ErrorMessage).ToList();
            var errors = JsonConvert.SerializeObject(validationErrors);
            return new HttpResponseMessage()
            {
                Content = new StringContent(errors),
                StatusCode = HttpStatusCode.BadRequest
            };
        }
    }
}
