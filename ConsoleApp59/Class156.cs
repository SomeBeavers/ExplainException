
namespace ConsoleApp59;

public class Class156
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class157().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
