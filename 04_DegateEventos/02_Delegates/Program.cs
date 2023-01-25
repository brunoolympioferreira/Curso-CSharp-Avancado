using _02_Delegates.Lib;


//Tela -> Cadastro de Usuarios: Thumb (foto de perfil do usuario).
Foto foto = new() { Nome = "perfil.jpeg", TamanhoX = 1920, TamanhoY = 1080 };
FotoProcessador.filtros = new FotoFiltro().GerarThumb;
FotoProcessador.Processar(foto);

//Tela -> Cadastro de Produtos: Colorir + Tamanho Medio
Foto foto2 = new() { Nome = "produto.jpeg", TamanhoX = 1920, TamanhoY = 1080 };
FotoProcessador.filtros = new FotoFiltro().Colorir;
FotoProcessador.filtros += new FotoFiltro().RedimensionarTamMedio;
FotoProcessador.Processar(foto2);

//Tela -> Cadastro de Albuns do Usuario - Retro: Preto e Branco
Foto foto3 = new() { Nome = "album.jpeg", TamanhoX = 1920, TamanhoY = 1080 };
FotoProcessador.filtros = new FotoFiltro().PretoBranco;
FotoProcessador.Processar(foto3);