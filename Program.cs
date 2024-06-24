using System; 
 
class Program 
{ 
    static void Main() 
    { 
        Console.Write("Введите значение M: "); 
        int M = int.Parse(Console.ReadLine()); 
 
        Console.Write("Введите значение N: "); 
        int N = int.Parse(Console.ReadLine()); 
 
        PrintNaturalNumbers(M, N); 
    } 
 
    static void PrintNaturalNumbers(int current, int N) 
    { 
        if (current <= N) 
        { 
            Console.Write(current + " "); 
            PrintNaturalNumbers(current + 1, N); 
        } 
    } 
}

