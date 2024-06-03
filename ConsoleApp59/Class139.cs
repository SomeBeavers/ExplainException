
namespace ConsoleApp59;

public class Class139
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class140().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
