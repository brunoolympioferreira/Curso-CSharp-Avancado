using _00_Biblioteca;
using System.Text.Json;

Usuario usuario = new()
{
    Nome = "Maria da Silva",
    CPF = "555.555.555-00",
    Email = "maria.costa@email.com"
};

string stringObjSerializado = JsonSerializer.Serialize(usuario);

StreamWriter sw = new StreamWriter(@"C:\Users\Bruno\Documents\Cursos\Curso-CSharp-Avancado\Solution01_SerializeXML\Input\02_SerializarJSON.json");
sw.WriteLine(stringObjSerializado);
sw.Close();
