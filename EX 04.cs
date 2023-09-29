using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

char[] caracteres = new char[10];

for (int i = 0; i < 10; i++)
{
  Console.WriteLine("Digite o caracter desejado " + (i + 1) + ":");
  caracteres[i] = Convert.ToChar(Console.ReadLine());
}

int contadorConsoantes = 0;
string consoantes = "";

foreach (char caractere in caracteres)
{

  if (char.IsLetter(caractere) && !"AEIOUaeiou".Contains(caractere))
  {

    contadorConsoantes++;
    consoantes += caractere + " ";
  }
}

Console.WriteLine("Consoantes digitadas: " + consoantes);
Console.WriteLine("Total de consoantes: " + contadorConsoantes);

Console.ReadLine();
