
namespace ConsoleApp59;

public class Class19
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class20().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
