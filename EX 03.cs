double[] notas = new double[4];

for (int i = 0; i < 4; i++)
{
  Console.WriteLine("Digite a nota do aluno " + (i + 1) + ":");
  notas[i] = Convert.ToDouble(Console.ReadLine());
}
Array.Sort(notas);
Array.Reverse(notas);

double soma = 0;
foreach (double nota in notas)
{
  soma += nota;
}
double media = soma / 4;

Console.WriteLine("As notas digitadas são: ");

foreach (double nota in notas)
{
  Console.WriteLine(nota);
}
Console.WriteLine("A média das notas: " + media);

Console.ReadKey();


