using System.Reflection;
using System.Runtime.CompilerServices;

namespace EspacioCalculadora;

public class Calculadora
{

    public double dato;

    public void Sumar(double termino)
    {
        dato += termino;

    }

    public void Restar(double termino)
    {
        dato -= termino;

    }

    public void Multiplicar(double termino)
    {
        dato *= termino;

    }

    public void Dividir(double termino)
    {
        dato = dato / termino;

    }

    public void Limpiar()
    {
        dato = 0;
    }



}