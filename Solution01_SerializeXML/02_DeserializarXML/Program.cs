using _00_Biblioteca;
using System.Xml.Serialization;

StreamReader stream = new("C:\\Users\\Bruno\\Documents\\Cursos\\Curso-CSharp-Avancado\\Solution01_SerializeXML\\Input\\01_SerializarXML.xml");

XmlSerializer serializador = new(typeof(Usuario));

Usuario usuario = (Usuario)serializador.Deserialize(stream);

Console.WriteLine("Usuario(Nome): {0}, CPF: {1} e Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
Console.ReadKey();
