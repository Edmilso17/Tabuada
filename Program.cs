double contador, numero, produto;
int multiplicaçao;
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Digite a tabuada desejada: ");
numero = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Digite a multiplicação da tabuada desejada: ");
multiplicaçao = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

if(numero <0 || numero >10)
{
    Console.WriteLine("Digite um numero de 0 a 10");
}

else
{
    contador=0;
    while(contador <= multiplicaçao)
    {
        produto = contador * numero;
        Console.WriteLine($"{numero} x {contador} = {produto}");
        contador+=1;
    }
}
