const int frequency = 800;
const int duration = 100;

if (args.Length < 1)
{
    throw new ArgumentException("A query is required.");
}

var query = args.First();
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
