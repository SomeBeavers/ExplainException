
namespace ConsoleApp59;

public class Class15
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class16().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
