int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
  Console.WriteLine("Digite o número " + (i + 1) + ":");
  numeros[i] = Convert.ToInt32(Console.ReadLine()); // To.Int32 é usado para converter um valor em um tipo inteiro de 32 bits (int)
}

Console.WriteLine("Os nnúmeros digitados: ");

foreach (int numero in numeros) // usamos um loop foreach para exibir os números armazenados no vetor após a leitura.
{
  Console.WriteLine(numero);
}
Console.ReadKey();
