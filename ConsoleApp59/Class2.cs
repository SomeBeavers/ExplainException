﻿namespace ConsoleApp59;

public class Class2
{
    public void ThrowException(string parameter)
    {
        try
        {
            new Class3().ThrowException(parameter);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}