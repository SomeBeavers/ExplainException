
namespace ConsoleApp59;

public class Class125
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class126().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
