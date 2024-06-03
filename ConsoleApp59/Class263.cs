
namespace ConsoleApp59;

public class Class263
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class264().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
