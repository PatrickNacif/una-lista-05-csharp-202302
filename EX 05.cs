int[] numeros = new int[20];
int[] pares = new int[20];
int[] impares = new int[20];

Console.WriteLine("Digite um número");
Convert.ToDouble(Console.ReadLine());

for (int i = 1; i < 20; i++)
{
  Console.Write("Digite mais um número " + (i + 1) + ": ");
  numeros[i] = Convert.ToInt32(Console.ReadLine());


  if (numeros[i] % 2 == 0)
  {
    pares[i] = numeros[i];
  }
  else
  {
    impares[i] = numeros[i];
  }
}

Console.WriteLine("Números digitados:");
foreach (int numero in numeros)
{
  Console.Write(numero + " ");
}

Console.WriteLine("\nNúmeros pares:");
foreach (int numero in pares)
{
  if (numero != 0)
  {
    Console.Write(numero + " ");
  }
}

Console.WriteLine("\nNúmeros ímpares:");
foreach (int numero in impares)
{
  if (numero != 0)
  {
    Console.Write(numero + " ");
  }
}

Console.ReadLine();