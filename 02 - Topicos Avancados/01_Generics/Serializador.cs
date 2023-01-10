using System.Text.Json;

namespace _01_Generics;
public class Serializador
{
    public static void Serializar(object obj)
    {
        StreamWriter sw = new("C:\\Users\\Bruno\\Documents\\Cursos\\Curso-CSharp-Avancado\\02 - Topicos Avancados\\Input\\03_" + obj.GetType().Name + ".txt");

        string objSerializado = JsonSerializer.Serialize(obj);

        sw.Write(objSerializado);
        sw.Close();
    }

    public static T Deserializar<T>()
    {
        StreamReader sr = new("C:\\Users\\Bruno\\Documents\\Cursos\\Curso-CSharp-Avancado\\02 - Topicos Avancados\\Input\\03_" + typeof(T).Name + ".txt");
        string conteudo = sr.ReadToEnd();

        T obj = (T)JsonSerializer.Deserialize(conteudo, typeof(T));

        return obj;
    }
}
