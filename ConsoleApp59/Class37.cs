
namespace ConsoleApp59;

public class Class37
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class38().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
