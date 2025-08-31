//Leia um número inteiro e exiba a mensagem "Você digitou um número negativo." caso o número seja menor que zero.
Console.WriteLine("Digite um número");
int num1 = int.Parse(Console.ReadLine());
if (num1 < 0)
{
    Console.WriteLine("Você digitou um número negativo");
}
