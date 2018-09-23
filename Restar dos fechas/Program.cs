using System;

namespace Restar_dos_fechas
{
    public class Program
    {
        public static void Main()
        {
            DateTime fechaActual = DateTime.Now;  //  se inicia la variable facha actual
            DateTime fechaNacimiento = new DateTime(1979, 9, 19);   //se crea la variable fecha de nacimiento que es la que se va a restar
            TimeSpan diferencia = fechaActual.Subtract(fechaNacimiento);   // con este comando se hace la resta de la fecha actual a la fecha de nacimeinto.
            // TimeSpan viene siendo como el intervalo de tiempo
             
            Console.WriteLine("Han pasado {0} dias",diferencia.Days);
            Console.WriteLine("Si lo quieres con decimales: {0} dias", diferencia.TotalDays);
            Console.WriteLine("Y si quieres con mas detalles {0} ", diferencia);
            
            Console.ReadKey();

        }
    }
}
