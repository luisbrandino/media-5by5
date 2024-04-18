/*
2- FAÇA UM ALGORITMO QUE LEIA DOIS NÚMEROS REAIS CALCULE SUA MÉDIA E INFORME A SITUACAO DO ALUNO BASEADO NOS SEGUINTES CRITERIOS:
SE A MÉDIA FOR MENOR OU IGUAL A 3 O ALUNO ESTÁ REPROVADO;
SE FOR MAIOR QUE TRÊS E MENOR IGUAL A 5 O ALUNO ESTÁ DE EXAME;
SE NÃO ELE ESTÁ APROVADO;
*/

Console.Write("Informe a primeira nota: ");
float nota1 = float.Parse(Console.ReadLine());

Console.Write("Informe a segunda nota: ");
float nota2 = float.Parse(Console.ReadLine());

if (nota1 < 0 || nota2 < 0)
{
    Console.WriteLine("As notas não podem ser negativas");
    Environment.Exit(0);
}

float media = (nota1 + nota2) / 2;

Console.WriteLine($"Média: {media}");

if (media <= 3)
    Console.WriteLine("Aluno reprovado");
else if (media <= 5)
    Console.WriteLine("Aluno de exame");
else
    Console.WriteLine("Aluno aprovado");