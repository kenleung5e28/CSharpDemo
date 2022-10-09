using System.Threading;
using System.Threading.Tasks;

Console.WriteLine("Before delay: {0}", Thread.CurrentThread.ManagedThreadId);
await Task.Delay(100);
Console.WriteLine("After delay: {0}", Thread.CurrentThread.ManagedThreadId);
