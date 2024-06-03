
namespace ConsoleApp59;

public class Class51
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class52().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
