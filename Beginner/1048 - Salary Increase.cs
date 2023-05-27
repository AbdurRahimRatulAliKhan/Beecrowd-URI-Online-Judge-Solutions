using System;

class Program {
    static void Main(string[] args) {
        double salary = double.Parse(Console.ReadLine());

        double newSalary, increase;
        int percentage;

        if (salary >= 0 && salary <= 400.00) {
            percentage = 15;
        } else if (salary <= 800.00) {
            percentage = 12;
        } else if (salary <= 1200.00) {
            percentage = 10;
        } else if (salary <= 2000.00) {
            percentage = 7;
        } else {
            percentage = 4;
        }

        increase = salary * percentage / 100;
        newSalary = salary + increase;

        Console.WriteLine("Novo salario: " + newSalary.ToString("F2"));
        Console.WriteLine("Reajuste ganho: " + increase.ToString("F2"));
        Console.WriteLine("Em percentual: " + percentage + " %");
    }
}
