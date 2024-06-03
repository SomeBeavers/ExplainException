
namespace ConsoleApp59;

public class Class293
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class294().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
