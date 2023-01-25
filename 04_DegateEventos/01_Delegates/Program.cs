

Calcula calc = new(Soma);
int so = calc(10, 20);

Calcula calc1 = new(Subtrair);
int su = calc(30, 15);


/*
    var so = Soma(10, 20);
    var su = Subtrair(20, 10);
*/

Console.WriteLine($"Soma: {so}");
Console.WriteLine($"Sub: {su}");

static int Soma(int a, int b)
{
    return a + b;
}

static int Subtrair(int a, int b)
{
    return a - b;
}

delegate int Calcula(int a, int b);
