
namespace ConsoleApp59;

public class Class184
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class185().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
