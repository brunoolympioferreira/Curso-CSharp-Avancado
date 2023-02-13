// Thread Sleep
Console.WriteLine("Inicio do nosso programa");
Thread.Sleep(3000);
Console.WriteLine("Termino");

// Thread Join
Thread t1 = new(ThreadRepeticao);
t1.Start();
t1.Join();

Console.WriteLine("Termino");
Console.WriteLine("Termino");
Console.WriteLine("Termino");
Console.WriteLine("Termino");
Console.WriteLine("Termino");

static void ThreadRepeticao()
{
    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine("Num:" + i);
    }
}
