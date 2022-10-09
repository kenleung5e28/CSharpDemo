using System.Threading;
using System.Threading.Tasks;

static async Task f(string id, int delay) {
    Console.WriteLine("Before {0}: {1}", id, Thread.CurrentThread.ManagedThreadId);
    await Task.Delay(delay);
    Console.WriteLine("After {0}: {1}", id, Thread.CurrentThread.ManagedThreadId);
}

Task t1 = f("first", 2000);
Task t2 = f("second", 500);
Console.WriteLine("Before WhenAll: {0}", Thread.CurrentThread.ManagedThreadId);
await Task.WhenAny(t1, t2);
Console.WriteLine("After WhenAll: {0}", Thread.CurrentThread.ManagedThreadId);