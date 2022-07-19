using WebUtilities.Model;
using WebUtilities.Services;

namespace WebUtilities.Interfaces;

public interface IValidationService
{
    public OperationResult CheckAllValidation<T>(IEnumerable<Validation<T>> validations, T data);
}