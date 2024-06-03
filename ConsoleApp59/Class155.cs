
namespace ConsoleApp59;

public class Class155
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class156().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
