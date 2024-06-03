namespace ConsoleApp59;

public class Class3
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class4().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}