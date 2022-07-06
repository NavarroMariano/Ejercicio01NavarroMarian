using System;

namespace Ejercicio01NavarroMariano
{
	class Program
	{
		static void Main(string[] args)
		{
			/* Desarrollar un programa para informar la distancia recorrida en metros por segundo, por un móvil que se
			// desplaza a una velocidad constante, durante un lapso de tiempo. Convertir y mostrar luego, la distancia en
			// kms.
			// i. Distancia= Velocidad*Tiempo.
			// ii. 1 metro=0,001 kms*/

			Console.WriteLine("Ingrese la velocidad del movil en metros");
			double metros = Double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el tiempo de viaje");
			double tiempo = Double.Parse(Console.ReadLine());
			if (metros > 0 && tiempo > 0)
			{
				double kms = (metros / 1000) * tiempo;
				Console.WriteLine($"La distancia recorrida por el movil fue de {kms} Kms en un tiempo de  {tiempo} minutos.");
			}
			else
			{
				Console.WriteLine("Los datos ingresados son incorrectos");
			}
		}
	}
}
