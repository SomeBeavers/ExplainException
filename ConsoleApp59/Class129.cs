
namespace ConsoleApp59;

public class Class129
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class130().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
