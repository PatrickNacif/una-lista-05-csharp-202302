double[,] notas = new double[10, 4];
double[] medias = new double[10];
int alunosAprovados = 0;

for (int aluno = 0; aluno < 10; aluno++)
{
  Console.WriteLine("Digite as quatro notas do aluno " + (aluno + 1) + ":");

  double soma = 0;

  for (int nota = 0; nota < 4; nota++)
  {
    Console.Write("Nota " + (nota + 1) + ": ");
    notas[aluno, nota] = Convert.ToDouble(Console.ReadLine());
    soma += notas[aluno, nota];
  }

  double media = soma / 4;
  medias[aluno] = media;

  if (media >= 7.0)
  {
    alunosAprovados++;
  }
}

Console.WriteLine("Número de alunos com média maior ou igual a 7.0: " + alunosAprovados);

Console.WriteLine("Médias dos alunos:");
for (int i = 0; i < 10; i++)
{
  Console.WriteLine("Aluno " + (i + 1) + ": " + medias[i]);
}

Console.ReadLine();