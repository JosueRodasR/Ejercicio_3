using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float cp1, cp2, cp3, cef, ctf, nf;
            Console.WriteLine("Ingrese su primera Calificacion Parcial: ");
            cp1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese su segunda Calificacion Parcial; ");
            cp2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese su tercera Calificacion Parcial; ");
            cp3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese su Calificacion del Examen Final: ");
            cef = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese su Calificacion del Trabajo Final: ");
            ctf = Convert.ToSingle(Console.ReadLine());

            nf = 0.55f * (cp1 + cp2 + cp3) / 3 + 0.30f * cef + 0.15f * ctf;

            Console.WriteLine("El producto final es: " + nf);
            Console.ReadKey();
        }
    }
}
