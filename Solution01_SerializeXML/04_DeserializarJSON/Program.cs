using _00_Biblioteca;
using System.Text.Json;


StreamReader stream = new StreamReader(@"C:\Users\Bruno\Documents\Cursos\Curso-CSharp-Avancado\Solution01_SerializeXML\Input\02_SerializarJSON.json");
string linhasDoArquivo = stream.ReadToEnd();

Usuario usuario =  (Usuario)JsonSerializer.Deserialize(linhasDoArquivo, typeof(Usuario));

Console.WriteLine("Usuario(Nome): {0}, CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
