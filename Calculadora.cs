using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

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

//Punto 2
namespace Empleado;

public class Empleado
{
    string Nombre;
    string Apellido;
    DateTime FechaNac;
    char EstadoCivil;
    DateTime Ingreso;
    double Sueldo;
    enum cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    cargos cargo;

    DateTime hoy = DateTime.Now;


    

    public void Antiguedad()
    {
        int anti = hoy.year - Ingreso.year;
    }

    public void Edad()
    {
        int edad = hoy.year - FechaNac.year;

    }

    public int Jubilacion()
    {
        int jubi = 65 - edad;
    }
}