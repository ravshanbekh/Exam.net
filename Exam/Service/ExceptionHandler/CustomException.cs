namespace Exam.Service.ExceptionHandler;

public class CustomException : Exception
{
    public int StatusCode { get; set; }
    public CustomException(int _code , string message) : base(message)
    {
        this.StatusCode = _code;
    }
}
