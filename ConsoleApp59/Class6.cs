
namespace ConsoleApp59;

public class Class6
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class7().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
