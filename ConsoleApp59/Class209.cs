
namespace ConsoleApp59;

public class Class209
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class210().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
