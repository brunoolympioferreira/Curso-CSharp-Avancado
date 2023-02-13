for (int i = 0; i < 5; i++)
{
    Thread t1 = new(ThreadRepeticao);
    t1.Start();
}

Console.WriteLine("Programa finalizado");

static void ThreadRepeticao()
{
    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine("Num:" + i);
    }
}
