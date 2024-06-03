
namespace ConsoleApp59;

public class Class90
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class91().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
