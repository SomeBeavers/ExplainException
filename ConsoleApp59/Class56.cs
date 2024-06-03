
namespace ConsoleApp59;

public class Class56
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class57().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
