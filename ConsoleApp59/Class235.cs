
namespace ConsoleApp59;

public class Class235
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class236().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
