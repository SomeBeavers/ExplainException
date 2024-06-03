
namespace ConsoleApp59;

public class Class29
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class30().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
