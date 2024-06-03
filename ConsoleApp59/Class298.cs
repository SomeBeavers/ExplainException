
namespace ConsoleApp59;

public class Class298
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class299().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
