
namespace ConsoleApp59;

public class Class55
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class56().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
