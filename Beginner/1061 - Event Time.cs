using System;

class Program {
    static void Main(string[] args) {
        string[] startDayInput = Console.ReadLine().Split(' ');
        string[] startTimeInput = Console.ReadLine().Split(':');
        string[] endDayInput = Console.ReadLine().Split(' ');
        string[] endTimeInput = Console.ReadLine().Split(':');

        int startDay = int.Parse(startDayInput[1]);
        int startHour = int.Parse(startTimeInput[0]);
        int startMinute = int.Parse(startTimeInput[1]);
        int startSecond = int.Parse(startTimeInput[2]);

        int endDay = int.Parse(endDayInput[1]);
        int endHour = int.Parse(endTimeInput[0]);
        int endMinute = int.Parse(endTimeInput[1]);
        int endSecond = int.Parse(endTimeInput[2]);

        int totalStartSeconds = startDay * 24 * 60 * 60 + startHour * 60 * 60 + startMinute * 60 + startSecond;
        int totalEndSeconds = endDay * 24 * 60 * 60 + endHour * 60 * 60 + endMinute * 60 + endSecond;

        int durationSeconds = totalEndSeconds - totalStartSeconds;

        int durationDays = durationSeconds / (24 * 60 * 60);
        durationSeconds %= (24 * 60 * 60);
        int durationHours = durationSeconds / (60 * 60);
        durationSeconds %= (60 * 60);
        int durationMinutes = durationSeconds / 60;
        durationSeconds %= 60;

        Console.WriteLine($"{durationDays} dia(s)");
        Console.WriteLine($"{durationHours} hora(s)");
        Console.WriteLine($"{durationMinutes} minuto(s)");
        Console.WriteLine($"{durationSeconds} segundo(s)");
    }
}
