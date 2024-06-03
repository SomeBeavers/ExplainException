
namespace ConsoleApp59;

public class Class149
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class150().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
