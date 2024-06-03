
namespace ConsoleApp59;

public class Class178
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class179().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
