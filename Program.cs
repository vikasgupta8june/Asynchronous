namespace Asynchronous
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Invoke invoke = new Invoke();

            await invoke.Run();

            Console.ReadLine();
        }
    }
}