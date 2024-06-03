
namespace ConsoleApp59;

public class Class249
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class250().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
