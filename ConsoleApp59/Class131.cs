
namespace ConsoleApp59;

public class Class131
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class132().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
