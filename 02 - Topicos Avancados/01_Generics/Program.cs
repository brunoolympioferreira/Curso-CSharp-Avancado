using _01_Generics;

Carro carro = new() { Marca = "FIAT", Modelo = "Uno"};
Casa casa = new Casa() { Cidade = "Brasilia", Endereco = "QSQ 400" };
Usuario usuario = new Usuario() { Nome = "Maria", Email = "maria@email.com", Senha = "123456"};

Serializador.Serializar(carro);
Serializador.Serializar(casa);
Serializador.Serializar(usuario);

Carro carro2 = Serializador.Deserializar<Carro>();
Casa casa2 = Serializador.Deserializar<Casa>();
Usuario usuario2 = Serializador.Deserializar<Usuario>();

Console.WriteLine("Carro2: " + carro2.Marca + " - " + carro.Modelo);

Console.WriteLine("Casa2: " + casa2.Cidade + " - " + casa2.Endereco);

Console.WriteLine("Carro2: " + usuario2.Nome + " - " + usuario2.Email);

Console.ReadKey();

