
namespace ConsoleApp59;

public class Class22
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class23().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
