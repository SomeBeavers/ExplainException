
namespace ConsoleApp59;

public class Class45
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class46().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
