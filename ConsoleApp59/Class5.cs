
namespace ConsoleApp59;

public class Class5
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class6().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
