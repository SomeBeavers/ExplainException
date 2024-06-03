
namespace ConsoleApp59;

public class Class118
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class119().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
