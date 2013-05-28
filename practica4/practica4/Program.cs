using System;

namespace practica4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Archivo archivo = new Archivo("tres.txt");
			archivo.Mezclar();
		}
	}
}
