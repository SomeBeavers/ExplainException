
namespace ConsoleApp59;

public class Class38
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class39().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
