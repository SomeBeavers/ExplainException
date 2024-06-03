
namespace ConsoleApp59;

public class Class290
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class291().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
