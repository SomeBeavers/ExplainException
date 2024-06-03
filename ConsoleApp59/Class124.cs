
namespace ConsoleApp59;

public class Class124
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class125().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
