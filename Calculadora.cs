namespace EspacioCalculadora
{
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
            dato /= termino;
        }

        public void Limpiar()
        {
            dato = 0;
        }
    }

    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private char estadoCivil;
        private DateTime ingreso;
        private double sueldo;
        private Cargos cargo;

        public enum Cargos
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }

        public Empleado(string nombre, string apellido, DateTime fechaNac, char estadoCivil, DateTime ingreso, double sueldo, Cargos cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.estadoCivil = estadoCivil;
            this.ingreso = ingreso;
            this.sueldo = sueldo;
            this.cargo = cargo;
        }

        public int Antiguedad()
        {
            DateTime hoy = DateTime.Now;
            return hoy.Year - ingreso.Year;
        }

        public int Edad()
        {
            DateTime hoy = DateTime.Now;
            return hoy.Year - fechaNac.Year;
        }

        public int Jubilacion()
        {
            int edad = Edad();
            return 65 - edad;
        }

         public double CalcularSalario()
        {
            double adicional = 0;
            int antiguedad = Antiguedad();

            // Calcular adicional por antigüedad
            if (antiguedad <= 20)
            {
                adicional = sueldo * 0.01 * antiguedad;
            }
            else
            {
                adicional = sueldo * 0.25;
            }

            // Incrementar adicional si el cargo es Ingeniero o Especialista
            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional *= 1.5;
            }

            // Incrementar adicional si es casado
            if (estadoCivil == 'C')
            {
                adicional += 150000;
            }

            return sueldo + adicional;
        }

    }
}


