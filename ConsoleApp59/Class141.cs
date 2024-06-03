
namespace ConsoleApp59;

public class Class141
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class142().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
