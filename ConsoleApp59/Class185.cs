
namespace ConsoleApp59;

public class Class185
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class186().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
