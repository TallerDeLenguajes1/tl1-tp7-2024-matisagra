using System.Reflection;
using System.Runtime.CompilerServices;

namespace EspacioCalculadora;

public class Calculadora
{

    public double dato;

    public void Sumar(double termino)
    {
        dato += termino;
        Console.WriteLine($"{dato}");
    }

    public void Restar(double termino)
    {
        dato -= termino;
        Console.WriteLine($"{dato}");
    }

    public void Multiplicar(double termino)
    {
        dato *= termino;
        Console.WriteLine($"{dato}");
    }

    public void Dividir(double termino)
    {
        dato = dato / termino;
        Console.WriteLine($"{dato}");
    }



}