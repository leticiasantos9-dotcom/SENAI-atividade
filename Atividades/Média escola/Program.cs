// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite a primeira nota");
decimal nota1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite a segunda nota");
decimal nota2 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite a terceira nota");
decimal nota3 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite a quarta nota");
decimal nota4 = Convert.ToDecimal(Console.ReadLine());


decimal media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine($"A média é: {media} ");

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}



