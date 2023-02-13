for (int i = 0; i < 5; i++)
{
    Thread t1 = new(ThreadRepeticao);
    t1.Start(i);
}

Console.WriteLine("Programa finalizado");

static void ThreadRepeticao(object id)
{
    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine("Thread:" + id + " - Num:" + i + "Id Interno: " + Thread.CurrentThread.ManagedThreadId);
    }
}