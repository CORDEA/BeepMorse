// See https://aka.ms/new-console-template for more information

const int frequency = 800;
const int duration = 100;

const string query = "hello world";
var morse = new Morse.Morse(query).Generate();

foreach (var m in morse)
{
    if (m >= 0)
    {
        Console.Beep(frequency, m == 0 ? duration : duration * 3);
        continue;
    }

    Thread.Sleep(duration);
}
