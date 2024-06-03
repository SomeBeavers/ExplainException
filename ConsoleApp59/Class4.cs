namespace ConsoleApp59;

public class Class4
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class5().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}