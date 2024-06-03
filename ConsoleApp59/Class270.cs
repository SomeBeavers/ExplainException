
namespace ConsoleApp59;

public class Class270
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class271().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
