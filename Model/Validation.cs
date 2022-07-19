namespace WebUtilities.Model;

public abstract class Validation<T>
{
    private List<string> _errors = new List<string>();
    public abstract ValidationResult Validate(T data);
}