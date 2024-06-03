
namespace ConsoleApp59;

public class Class147
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class148().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
