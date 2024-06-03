
namespace ConsoleApp59;

public class Class113
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class114().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
