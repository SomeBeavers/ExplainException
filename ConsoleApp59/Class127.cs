
namespace ConsoleApp59;

public class Class127
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class128().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
