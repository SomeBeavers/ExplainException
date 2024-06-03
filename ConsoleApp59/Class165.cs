
namespace ConsoleApp59;

public class Class165
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class166().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
