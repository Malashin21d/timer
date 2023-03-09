using System.Runtime.CompilerServices;
using System.Timers;
Console.Write("Таймер:\n");
void time(int hour, int minute, int second)
{
    int timeCountDown = hour * 3600 + minute * 60 + second; //Расчет времени
    var timer = new System.Timers.Timer(1000);
    timer.Elapsed += (sender, eventArgs) =>
    {
        if (timeCountDown == 1)
        {
            timer.Dispose();
            Console.Clear();
            Console.WriteLine("Время вышло");
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(250, 500);
            Thread.Sleep(50);
            Console.Beep(350, 250);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(250, 500);
            Thread.Sleep(50);
            Console.Beep(350, 250);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            return;
        }
        timeCountDown--;
        Console.Clear();
        Console.WriteLine($"Осталось {timeCountDown} секунд");
    };
    timer.Start();
    Console.ReadLine();
}

Console.WriteLine("Введите Часы минуты секунды:");
var hour = int.Parse(Console.ReadLine());
var minute = int.Parse(Console.ReadLine());
var second = int.Parse(Console.ReadLine());
time(hour, minute, second);
Console.ReadKey();