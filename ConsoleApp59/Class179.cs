
namespace ConsoleApp59;

public class Class179
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class180().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
