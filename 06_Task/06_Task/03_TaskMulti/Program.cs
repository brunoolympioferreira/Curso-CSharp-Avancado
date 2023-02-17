using System.Net;

List<Task> lista = new();

lista.Add(Task.Factory.StartNew(Metodo01));
lista.Add(Task.Factory.StartNew(Metodo01));
lista.Add(Task.Factory.StartNew(Metodo01));
lista.Add(Task.Factory.StartNew(Metodo01));

Task.WaitAll(lista.ToArray());



string[] enderecos = new string[] { "http://www.google.com", "http://www.r7.com.br", "http://www.g1.com.br" };

var listaEnd = from end in enderecos select DownloadPagina(end);

Task.WaitAll(listaEnd.ToArray());

Console.WriteLine("Programa finalizado!");
Console.ReadKey();
static void Metodo01()
{
    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine("Valor: " + i + "TaskId: " + Task.CurrentId);
    }
}

static async Task DownloadPagina(string end)
{
    WebClient web = new();
    string html = await web.DownloadStringTaskAsync(end);
    Console.WriteLine("Download realizado para a pagina: " + end);
}
