
namespace ConsoleApp59;

public class Class299
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class300().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
