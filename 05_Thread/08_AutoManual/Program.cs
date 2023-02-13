AutoResetEvent auto01;
ManualResetEvent manual01;

manual01 = new(false);
Thread t1 = new(Executa01);
t1.Start();

Thread t2 = new(Executa02);
t2.Start();

static void Executa01()
{
    Console.WriteLine("01 - Iniciado Executa01.");
    Thread.Sleep(1000);
    Console.WriteLine("02 - Em execução 01 Executa01.");
    Console.WriteLine("03 - Em execução 02 Executa01.");
    Console.WriteLine("04 - Finalizado Executa01.");
}

static void Executa02()
{
    Console.WriteLine("01 - Iniciado Executa02.");
    Console.WriteLine("02 - Em execução 01 Executa02.");
    Console.WriteLine("03 - Em execução 02 Executa02.");
    Console.WriteLine("04 - Finalizado Executa02.");
}
