
namespace ConsoleApp59;

public class Class140
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class141().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
