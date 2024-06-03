
namespace ConsoleApp59;

public class Class244
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class245().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
