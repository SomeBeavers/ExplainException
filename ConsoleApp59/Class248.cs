
namespace ConsoleApp59;

public class Class248
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class249().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
