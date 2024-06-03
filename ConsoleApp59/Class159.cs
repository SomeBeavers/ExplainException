
namespace ConsoleApp59;

public class Class159
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class160().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
