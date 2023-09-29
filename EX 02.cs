int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
  Console.WriteLine("Digite o número " + (i + 1) + ":");
  numeros[i] = Convert.ToInt32(Console.ReadLine()); // To.Int32 é usado para converter um valor em um tipo inteiro de 32 bits (int)
}

Console.WriteLine("Os números digitados em ordem inversa: ");

for (int i = 9; i >= 0; i--)
{
  Console.WriteLine(numeros[i]);
}
Console.ReadKey();
