namespace WebUtilities.Model;

public enum ValidationStatus
{
    Success,
    Failed
}

public class ValidationResult
{
    public ValidationStatus Status { get; }
    public IEnumerable<string> ErrorMessages { get; }

    public ValidationResult(ValidationStatus status): this(status, Array.Empty<string>())
    {
    }
    
    public ValidationResult(ValidationStatus status, string errorMessage): this(status, new string[] {errorMessage})
    {
    }

    public ValidationResult(ValidationStatus status, IEnumerable<string> errorMessages)
    {
        Status = status;
        ErrorMessages = errorMessages;
    }
}