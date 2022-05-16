using System;

namespace equilateralTriangle
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Величина стороны треугольника: ");

			int sideSize;

			// Данные вводятся пользователем, и если эти данные не являются целым числом
			// Выводится сообщение об ошибке
			if(int.TryParse(Console.ReadLine(), out sideSize))
			{
				Console.WriteLine();
				Console.WriteLine("Треугольник:");
				PrintEquilateralTriangle(sideSize);
			}
			else Console.WriteLine("Введенные данные не являются целым числом.");
		}

		/// <summary>
		/// Выводит в командную строку равносторонний треугольник из символов "*".
		/// </summary>
		/// <param name="n">Размер стороны треугольника.</param>
		public static void PrintEquilateralTriangle(int n)
		{
			// Если введены неверные данные, на экран выводится сообщение об ошибке
			if(n < 0 || n % 2 == 1) 
			{
				Console.WriteLine("Введены неверные данные.");
				return;
			}

			// Рисуется равносторонний треугольник
			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j <= i; j++) Console.Write("*");
				Console.WriteLine();
			}
		}
	}
}
