
namespace ConsoleApp59;

public class Class207
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class208().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
