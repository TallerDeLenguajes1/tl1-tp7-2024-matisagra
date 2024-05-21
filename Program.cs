using EspacioCalculadora;

Calculadora calcu = new Calculadora();

string opcion;
do
{


    Console.WriteLine("Ingrese que operacion desea hacer: ");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
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

    }

    double resultado = calcu.dato;

} while (opcion != "0");
;



