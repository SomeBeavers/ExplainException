
namespace ConsoleApp59;

public class Class98
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class99().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
