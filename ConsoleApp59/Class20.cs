
namespace ConsoleApp59;

public class Class20
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class21().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
