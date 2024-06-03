
namespace ConsoleApp59;

public class Class31
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class32().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
