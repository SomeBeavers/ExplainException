
namespace ConsoleApp59;

public class Class255
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class256().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
