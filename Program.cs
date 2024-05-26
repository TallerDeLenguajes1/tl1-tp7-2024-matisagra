using EspacioCalculadora;

/* Calculadora calcu = new Calculadora();

string opcion;
do
{


    Console.WriteLine("Ingrese que operacion desea hacer: ");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Limpiar");
    Console.WriteLine("0. Salir");


    opcion = Console.ReadLine();





    Console.WriteLine("Ingrese el valor que desea operar:");
    string valor;
    double valor1;
    valor = Console.ReadLine();
    double.TryParse(valor, out valor1);

    switch (opcion)
    {
        case "1":
            calcu.Sumar(valor1);
            break;

        case "2":
            calcu.Restar(valor1);
            break;

        case "3":
            calcu.Multiplicar(valor1);
            break;

        case "4":
            calcu.Dividir(valor1);
            break;

        case "5":
            calcu.Limpiar();
            break;

    }
    double resultado = calcu.dato;
    Console.WriteLine($"El resultado es: {resultado}");


} while (opcion != "0"); */


// Punto 2

        Empleado[] empleados = new Empleado[3];

        empleados[0] = new Empleado("Juan", "Pérez", new DateTime(1980, 5, 23), 'C', new DateTime(2010, 3, 15), 500000, Empleado.Cargos.Ingeniero);
        empleados[1] = new Empleado("Ana", "García", new DateTime(1975, 7, 30), 'S', new DateTime(2005, 6, 20), 650000, Empleado.Cargos.Administrativo);
        empleados[2] = new Empleado("Luis", "Martínez", new DateTime(1990, 11, 10), 'C', new DateTime(2015, 1, 10), 400000, Empleado.Cargos.Especialista);

        double montoTotalSalarios = 0;
        Empleado empleadoProximoJubilacion = empleados[0];

        foreach (Empleado empleado in empleados)
        {
            montoTotalSalarios += empleado.CalcularSalario();

            if (empleado.Jubilacion() < empleadoProximoJubilacion.Jubilacion())
            {
                empleadoProximoJubilacion = empleado;
            }
        }

        Console.WriteLine($"Monto Total de Salarios: {montoTotalSalarios:C}");
        Console.WriteLine($"Empleado más próximo a jubilarse: {empleadoProximoJubilacion}");


