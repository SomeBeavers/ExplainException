
namespace ConsoleApp59;

public class Class115
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class116().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
