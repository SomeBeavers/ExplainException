
namespace ConsoleApp59;

public class Class223
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class224().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
