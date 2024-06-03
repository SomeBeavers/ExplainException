
namespace ConsoleApp59;

public class Class97
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class98().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
