using _04_LINQ_JOIN;

List<Livro> listaLivro = new();
listaLivro.Add(new Livro() { Id = 1, AutorId = 2, Titulo = "Amor amado" });
listaLivro.Add(new Livro() { Id = 2, AutorId = 2, Titulo = "Bem amado" });
listaLivro.Add(new Livro() { Id = 3, AutorId = 3, Titulo = "Um espião em Washington" });
listaLivro.Add(new Livro() { Id = 4, AutorId = 1, Titulo = "A vida na terra" });

List<Autor> listaAutor = new();
listaAutor.Add(new Autor() { Id = 1, Nome = "Leonardo" });
listaAutor.Add(new Autor() { Id = 2, Nome = "Maria Maria" });
listaAutor.Add(new Autor() { Id = 3, Nome = "Joseph" });

var listaJoin = from livros in listaLivro join autor in listaAutor on livros.AutorId equals autor.Id select new { livros, autor };

foreach (var item in listaJoin)
{
    Console.WriteLine("Livro: " + item.livros.Titulo + "Autor: " + item.autor.Nome);
}
