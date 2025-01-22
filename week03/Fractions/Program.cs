using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        f1.SetTop(1);
        int f1Top = f1.GetTop();
        Console.WriteLine($"f1Top: {f1Top}");
        f1.SetBottom(1);
        int f1Bottom = f1.GetBottom();
        Console.WriteLine($"f1Bottom: {f1Bottom}");
        
        Fraction f2 = new Fraction(5);
        int f2Top = f2.GetTop();
        Console.WriteLine($"f2Top: {f2Top}");
        f2.SetBottom(1);
        int f2Bottom = f2.GetBottom();
        Console.WriteLine($"f2Bottom: {f2Bottom}");
        
        Fraction f3 = new Fraction(3, 4);
        int f3Top = f3.GetTop();
        Console.WriteLine($"f3Top: {f3Top}");
        int f3Bottom = f3.GetBottom();
        Console.WriteLine($"f3Bottom: {f3Bottom}");
        
        Fraction f4 = new Fraction(1, 3);
        int f4Top = f4.GetTop();
        Console.WriteLine($"f4Top: {f4Top}");
        int f4Bottom = f4.GetBottom();
        Console.WriteLine($"f4Bottom: {f4Bottom}");
        
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}