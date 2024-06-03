
namespace ConsoleApp59;

public class Class260
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class261().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
