using System;

class Program {
    static void Main(string[] args) {
        string[] input = Console.ReadLine().Split(' ');

        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        int smallest = Math.Min(Math.Min(a, b), c);
        int largest = Math.Max(Math.Max(a, b), c);
        int middle = a + b + c - smallest - largest;

        Console.WriteLine(smallest);
        Console.WriteLine(middle);
        Console.WriteLine(largest);
        Console.WriteLine();
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}
