using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEjPag192
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables necesarias
            int cantidad = 0;

            float promedio = 0.0f;

            float minima = 10.0f;
            float maxima = 0.0f;
 
            Console.WriteLine("Ingrese la cantidad de Alumnos");
            cantidad = Convert.ToInt32(Console.ReadLine());
            float[] calif = new float[cantidad];

            for(int i = 0; i < calif.Length; i++)
            {
                Console.WriteLine("Dame la calificacion de alimno " + Convert.ToInt32(i+1) + ": ");
                calif[i] = Convert.ToSingle(Console.ReadLine());
                promedio += calif[i];

                if (calif[i] < minima)
                {
                    minima = calif[i];
                }

                if (calif[i] > maxima)
                {
                    maxima = calif[i];
                }

            }

            promedio /= calif.Length;

            Console.WriteLine("El promedio es " + promedio);
            Console.WriteLine("La calificacion mas alta es " + maxima);
            Console.WriteLine("La calificacion mas baja es " + minima);

            while (true)
            {

            }
        }
    }
}
