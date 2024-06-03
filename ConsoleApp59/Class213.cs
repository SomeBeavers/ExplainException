
namespace ConsoleApp59;

public class Class213
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class214().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
