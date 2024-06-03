
namespace ConsoleApp59;

public class Class146
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class147().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
