//LAMBDA
//LAMBDA = (entrada) => (expressao)

int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

//var listaFiltrada = lista.Where(a => a > 10).Select(a => a);
var listaFiltrada = lista.Where(a => a > 10).OrderBy(a => a).Select(a => a);

foreach (var item in listaFiltrada)
{
    Console.WriteLine(item);
}
