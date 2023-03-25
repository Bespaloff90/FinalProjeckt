// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine());
        rec(n);
    
    static void rec(int i)
    {
        if(i==0)
            return;
        else
            rec(i-1);
        Console.Write(i + " ");
    }