
namespace ConsoleApp59;

public class Class47
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class48().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
