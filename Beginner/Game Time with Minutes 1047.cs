using System;

class Program {
    static void Main(string[] args) {
        string[] input = Console.ReadLine().Split(' ');

        int startHour = int.Parse(input[0]);
        int startMinute = int.Parse(input[1]);
        int endHour = int.Parse(input[2]);
        int endMinute = int.Parse(input[3]);

        int totalStartMinutes = startHour * 60 + startMinute;
        int totalEndMinutes = endHour * 60 + endMinute;

        int durationMinutes;
        if (totalEndMinutes > totalStartMinutes) {
            durationMinutes = totalEndMinutes - totalStartMinutes;
        } else {
            durationMinutes = 24 * 60 - (totalStartMinutes - totalEndMinutes);
        }

        int durationHours = durationMinutes / 60;
        int durationRemainingMinutes = durationMinutes % 60;

        Console.WriteLine("O JOGO DUROU " + durationHours + " HORA(S) E " + durationRemainingMinutes + " MINUTO(S)");
    }
}
