using _00_Biblioteca;
using System.Xml.Serialization;

Usuario usuario = new()
{
    Nome = "José Costa Silva",
    CPF = "333.333.333.33",
    Email = "jose@email.com"
};

XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
//XmlSerializer serializador = new XmlSerializer(usuario.GetType());

StreamWriter stream = new("C:\\Users\\Bruno\\Documents\\Cursos\\Curso-CSharp-Avancado\\Solution01_SerializeXML\\Input\\01_SerializarXML.xml");

serializador.Serialize(stream, usuario);
