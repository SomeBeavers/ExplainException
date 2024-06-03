
namespace ConsoleApp59;

public class Class107
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class108().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
