
namespace ConsoleApp59;

public class Class239
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class240().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
