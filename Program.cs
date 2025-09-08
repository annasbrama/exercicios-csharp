// // Leia um número inteiro e exiba a mensagem "Você digitou um número negativo." caso o número seja menor que zero.
Console.WriteLine("Digite um número");
int num1 = int.Parse(Console.ReadLine());
if (num1 < 0)
{
    Console.WriteLine("Você digitou um número negativo");
}

// // Leia um número inteiro e exiba "Negativo", "Zero" ou "Positivo", conforme o caso.
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

// //Receba um numerador e um denominador. Exiba o resultado da divisão ou "Não é possível dividir por zero.", conforme o caso.
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

// //Receba 4 notas, com somente uma casa decimal. Valide se todas estão entre 0.0 e 10.0. Se alguma delas não estiver, exiba "Digite somente notas entre 0 e 10.". Caso todas as notas sejam válidas, calcule a média aritmética das notas. Exiba uma mensagem no seguinte padrão: "Você ficou com média 7,5. Resultado: Aprovado".

// // Resultados possíveis:

// //     "Reprovado" para médias menores que 5.0
// //     "Em recuperação" para médias entre 5.0 e 6.0
// //     "Aprovado", para médias acima de 6.0

double nota1, nota2, nota3, nota4, media;
Console.WriteLine("Digite somente notas entre 0 e 10.");
Console.Write("Digite a primeira nota ");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a segunda nota ");
nota2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a terceira nota ");
nota3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a quarta nota ");
nota4 = Convert.ToDouble(Console.ReadLine());
media = (nota1 + nota2 + nota3 + nota4) / 4;

if (media < 5)
{
    Console.WriteLine($"Você ficou com {media}. Resultador: Reprovado!");
}
else if (media > 6)
{
    Console.WriteLine($"Você ficou com {media}. Resultador: Aprovado!");
}
else
{
    Console.WriteLine($"Você ficou com {media}. Resultador: Recuperação!");
}

//Solicite ao usuário que digite a sua senha (uma string). Exiba "Acesso permitido" caso a senha digitada seja 1234abcd, senão exiba "Acesso negado".

string senha;

Console.WriteLine("Digite a sua senha.");
senha = Console.ReadLine();

if (senha == "1234abcd")
{
    Console.WriteLine("Acesso permitido.");
}
else
{
 Console.WriteLine("Acesso negado.");
}

//Solicite a idade do usuário. Avalie se ele pode ser doador de sangue (i.e. possui idade entre 18 e 67 anos). Informe o resultado da avaliação.

int idade;

Console.WriteLine("Qual é a sua idade?");
idade = Convert.ToInt32(Console.ReadLine()!);

if (idade >= 18 && idade <= 67)
{
    Console.WriteLine("Você pode ser doador de sangue.");
}
else
{
    Console.WriteLine("Você não pode ser doador de sangue");
}

//Receba um número. Exiba "par" ou "ímpar", conforme o caso.

int num;
Console.WriteLine("Digite um nũmero: ");
num = Convert.ToInt32(Console.ReadLine()!);

if (num % 2 == 0)
{
    Console.WriteLine("Par");
}
else
{
    Console.WriteLine("Ímpar");
}