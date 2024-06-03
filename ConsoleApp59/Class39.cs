
namespace ConsoleApp59;

public class Class39
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class40().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
