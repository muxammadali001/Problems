namespace World;

public class Program 
{         
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any 2 numbers : ");     
        double i,fact=1;      
        Console.Write("Enter a : ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter b : ");
        double b = Convert.ToDouble(Console.ReadLine());     
        for(i = 1;i <= a;i++)
        {      
            fact = fact * i;      
        }      
       
        double fact2 = fact * 0.05;           
        double log = Math.Log(b);

        if (fact2 > log)
        {
            Console.WriteLine($"Number a = {fact2:0.00} and more than number  b = {log:0.00}");
            
        }
        else
        {
            Console.WriteLine($"Number b = {log:0.00} and more than number a = {fact2:0.00}");
        }

    }
}