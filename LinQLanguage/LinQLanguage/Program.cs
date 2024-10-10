using System.Collections.Generic;
using System.Linq;
int[] arrayNumeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 24 };
Console.WriteLine("Numeros pares: ");
/**List<int> numerosPares = new List<int>();
foreach(int numero in arrayNumeros)
{
    if (numero % 2 == 0)
    {
        numerosPares.Add(numero);
    }
}
**/
IEnumerable<int> numerosPares = from numero in arrayNumeros where numero%2==0 select numero;
foreach(int numero in numerosPares)
{
    Console.WriteLine(numero);
}
