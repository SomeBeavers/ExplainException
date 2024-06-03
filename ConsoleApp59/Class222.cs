
namespace ConsoleApp59;

public class Class222
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class223().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
