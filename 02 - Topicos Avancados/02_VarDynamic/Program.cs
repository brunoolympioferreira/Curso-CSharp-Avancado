object t1 = "";
object t2 = 123456;

var v1 = "";
var v2 = 1234567;

dynamic d1 = new Usuario { Nome = "Maria"};

Console.WriteLine(d1.Nome);

Console.ReadKey();
class Usuario
{
    public string Nome { get; set; }
}
