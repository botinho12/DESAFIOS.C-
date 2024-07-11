// See https://aka.ms/new-console-template for more information

var soma = 0;
for (int i = 1; i <= 10; i++)
{
    var antigoValorSoma = soma;
    soma += i;
    Console.WriteLine("a soma de " + antigoValorSoma + " + " + i + " é igual a " + soma);


}
Console.ReadKey();
