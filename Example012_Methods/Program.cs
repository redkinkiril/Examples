﻿internal class Program
{
    private static void Main(string[] args)
    {
        // View 1
        void Method1()
        {
            Console.WriteLine("Autor...");
        }
        //Method1();

        //View 2
       void Method2(string msg)
       {
            Console.WriteLine(msg);
       } 
       //Method2("Text message");

       //View 3
       int Method3()
       {
            return DateTime.Now.Year;
       }
       int year = Method3();
       //Console.WriteLine(year);

       //View 4
       string Method4(int count, string text)
       {
        int i = 0;
        string result = String.Empty;
        while (i < count)
        {
            result = result +text;
            i++;
        }
        return result;
       }
       string res = Method4(10, "z");
       Console.WriteLine(res);
    }
}