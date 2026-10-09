using System;
using System.Security.Cryptography;

class Program
{
    public static void Main()
    {
        //Datatypes

        //int
        //long
        //float
        //double
        //decimal
        //bool
        //string
        //char
        //dateTime
        //dateOnly
        //time
        //object(information)

        int number = 10;
        long phone_no = 9879768968;
        float price = 10.2f;
        double balance = 200.9999999;
        decimal salary = 1700.000m;
        bool status = false;
        string name = "Nithar";
        char grade = 'A';
        DateTime Today = DateTime.Now;
        DateOnly Today_date = DateOnly.FromDateTime(DateTime.Today);
        TimeOnly Time = TimeOnly.FromDateTime(DateTime.Now);

        Console.WriteLine(number);
        Console.WriteLine(phone_no);
        Console.WriteLine(price);
        Console.WriteLine(balance);
        Console.WriteLine(salary);
        Console.WriteLine(status);
        Console.WriteLine(name);
        Console.WriteLine(grade);
        Console.WriteLine(Today);
        Console.WriteLine(Today_date);
        Console.WriteLine(Time);

    }
    
}