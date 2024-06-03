
namespace ConsoleApp59;

public class Class34
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class35().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
