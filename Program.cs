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

using System; 
 class Program 
{ 
    static void Main() 
    { 
        Console.Write("Введите неотрицательное число m: "); 
        int m = int.Parse(Console.ReadLine()); 
 
        Console.Write("Введите неотрицательное число n: "); 
        int n = int.Parse(Console.ReadLine()); 
 
        int result = AckermannFunction(m, n); 
        Console.WriteLine($"Значение функции Аккермана для ({m}, {n}) равно: {result}"); 
    } 
 
    static int AckermannFunction(int m, int n) 
    { 
        if (m == 0) 
            return n + 1; 
        else if (n == 0) 
            return AckermannFunction(m - 1, 1); 
        else 
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1)); 
    } 
}

using System; 
 
class Program 
{ 
    static void Main() 
    { 
        int[] myArray = { 10, 20, 30, 40, 50 }; 
 
        Console.WriteLine("Элементы массива, начиная с конца:"); 
        PrintArrayReverse(myArray, myArray.Length - 1); 
    } 
 
    static void PrintArrayReverse(int[] arr, int index) 
    { 
        if (index >= 0) 
        { 
            Console.Write(arr[index] + " "); 
            PrintArrayReverse(arr, index - 1); 
        } 
    } 
}
