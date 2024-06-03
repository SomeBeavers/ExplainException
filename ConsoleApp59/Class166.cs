
namespace ConsoleApp59;

public class Class166
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class167().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
