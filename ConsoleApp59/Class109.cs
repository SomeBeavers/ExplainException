
namespace ConsoleApp59;

public class Class109
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class110().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
