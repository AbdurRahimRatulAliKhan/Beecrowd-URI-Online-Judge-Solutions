using System;

class Program {
    static void Main(string[] args) {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int start = Math.Min(x, y) + 1;
        int end = Math.Max(x, y) - 1;

        int sum = 0;

        for (int i = start; i <= end; i++) {
            if (i % 2 != 0) {
                sum += i;
            }
        }

        Console.WriteLine(sum);
    }
}