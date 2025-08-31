// Leia um número inteiro e exiba a mensagem "Você digitou um número negativo." caso o número seja menor que zero.
Console.WriteLine("Digite um número");
int num1 = int.Parse(Console.ReadLine());
if (num1 < 0)
{
    Console.WriteLine("Você digitou um número negativo");
}

// Leia um número inteiro e exiba "Negativo", "Zero" ou "Positivo", conforme o caso.
Console.WriteLine("Digite um número");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 > 0)
{
    Console.WriteLine("Positivo");
}
else if (num1 == 0)
{
    Console.WriteLine("Zero");
}
else
{
    Console.WriteLine("Negativo");
}

//Receba um numerador e um denominador. Exiba o resultado da divisão ou "Não é possível dividir por zero.", conforme o caso.
double num1, num2, resultado;
Console.Write("Digite o numerador:");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o denominador:");
num2 = Convert.ToDouble(Console.ReadLine());
if (num2 == 0)
{
    Console.WriteLine("Não é possivel dividir por zero.");
}
else
{
    resultado = num1 / num2;
    Console.WriteLine($"{num1} dividido por {num2} é {resultado}");

}