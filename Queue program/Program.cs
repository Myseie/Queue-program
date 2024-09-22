using System;

class Program
{
    static void Main()
    {
        Queue <int> queue = new Queue<int>(); // för att skapa en kö av något

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
            
        queue.Enqueue(5);
            
        queue.Enqueue(6);

        Console.WriteLine($"Det första elementet i kön är {queue.Peek()}"); // för att visa en del av kön

        queue.Dequeue();
        queue.Dequeue();

        Console.WriteLine($"Det första elementet i kön är {queue.Peek()}");
    }
}