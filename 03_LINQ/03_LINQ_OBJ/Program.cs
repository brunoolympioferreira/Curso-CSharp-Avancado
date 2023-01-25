using _03_LINQ_OBJ;

List<Usuario> lista = new();
lista.Add(new Usuario() { Nome = "Jose", Email = "jose@gmail.com" });
lista.Add(new Usuario() { Nome = "Maria", Email = "maria@hotmail.com" });
lista.Add(new Usuario() { Nome = "Joao", Email = "joao@gmail.com" });
lista.Add(new Usuario() { Nome = "Bruno", Email = "bruno@hotmail.com" });
lista.Add(new Usuario() { Nome = "Vivian", Email = "vivian@gmail.com" });

var listaFiltrada = lista.Where(a => a.Email.Contains("@gmail.com")).OrderBy(a => a.Nome).Select(a => a);

foreach (var item in listaFiltrada)
{
    Console.WriteLine(item.Nome + " - " + item.Email);
}
