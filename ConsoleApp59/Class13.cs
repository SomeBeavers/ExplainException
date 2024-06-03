
namespace ConsoleApp59;

public class Class13
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class14().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
