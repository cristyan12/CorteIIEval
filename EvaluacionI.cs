using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CorteIIPracticaEvaluada2
{
    class EvaluacionI
    {
        static void Main(string[] args)
        {
            Console.Title = "Práctica Evaluada 2 - Corte II";

            int cantidadPersonas;
            int edad;
            float peso;
            float estatura;

            int dosEdades = 0;
            int mayor21 = 0;
            int pesoMenor72 = 0;
            int pesoMayor80 = 0;
            int edad18 = 0;
            int peso70 = 0;
            float estaturaMayorIgual180 = 0F;
            float sumatoriaEstatura = 0F;
            float promedioEstaturas;

            Console.Write("¿Cuantas personas se procesarán? ");
            cantidadPersonas = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadPersonas; i++) {
                Console.WriteLine("Persona # {0}", i + 1);

                // Edad
                Console.Write("Edad: ");
                edad = int.Parse(Console.ReadLine());

                // 1. Cantidad de personas con edad comprendida entre 15 y 20 años
                if (edad >= 15 && edad <= 20) {
                    dosEdades += i;
                }

                // 2. Cantidad de personas mayores a 21 años
                if (edad > 21) {
                    mayor21 += 1;
                }

                // Peso
                Console.Write("Peso: ");
                peso = float.Parse(Console.ReadLine());

                // 3. Cantidad de personas con peso menor o igual a 72 kilogramos 
                if (peso <= 72) {
                    pesoMenor72 += i;
                }

                // 4. Cantidad de personas con peso mayor a 80 kilogramos 
                if (peso > 80) {
                    pesoMayor80 += i;
                }

                // 5.1 Cantidad de personas con edad igual a 18 años
                if (edad == 18) {
                    edad18 += i;
                }

                // 5.2 Cantidad de personas con peso igual a 70 KG
                if (peso == 70) {
                    peso70 += i;
                }

                // Estatura
                Console.Write("Estatura: ");
                estatura = float.Parse(Console.ReadLine());
                sumatoriaEstatura += estatura;

                // 5.3 Cantidad de personas con estatura mayor o igual
                // que 1.80 metros
                if (estatura >= 180) {
                    estaturaMayorIgual180 += i;
                }

                Console.WriteLine();
            }

            // 6. Promedio de las estaturas procesadas
            promedioEstaturas = sumatoriaEstatura / cantidadPersonas;

            Console.WriteLine("\n Personas procesadas = {0}", cantidadPersonas);

            Console.WriteLine("\n Cantidad de personas con edad entre 15 y 20 años = {0}", dosEdades);

            Console.WriteLine("\n Cantidad de personas mayores a 21 años = {0}", mayor21);

            Console.WriteLine("\n Cantidad de personas con peso menor o igual a 72 kilogramos = {0}", pesoMenor72);

            Console.WriteLine("\n Cantidad de personas con peso mayor a 80 kilogramos = {0}", pesoMayor80);

            Console.WriteLine("\n Cantidad de personas con edad igual a 18 años = {0}", edad18);

            Console.WriteLine("\n Cantidad de personas con peso igual a 70 KG = {0}", peso70);

            Console.WriteLine(
                "\n Cantidad de personas con estatura mayor o igual que 1.80 metros = {0}", 
                estaturaMayorIgual180
            );

            Console.WriteLine("\n Promedio de las estaturas procesadas = {0}", promedioEstaturas);

            Console.ReadKey();
        }
    }
}