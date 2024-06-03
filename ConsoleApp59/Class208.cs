
namespace ConsoleApp59;

public class Class208
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class209().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
