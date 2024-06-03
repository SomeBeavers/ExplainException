
namespace ConsoleApp59;

public class Class30
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class31().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
