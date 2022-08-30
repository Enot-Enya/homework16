static void Print(string msg, int delay)
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"{msg} поток №{Task.CurrentId}");
        Thread.Sleep(delay);
    }
}

var task1 = Task.Run(() => Print("+", 100));
var task2 = Task.Run(() => Print("-", 500));
Task.WaitAll(task1, task2);