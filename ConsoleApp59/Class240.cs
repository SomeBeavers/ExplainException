
namespace ConsoleApp59;

public class Class240
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class241().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
