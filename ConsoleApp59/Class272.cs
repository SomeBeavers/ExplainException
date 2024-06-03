
namespace ConsoleApp59;

public class Class272
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class273().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
