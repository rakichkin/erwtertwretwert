using System;

namespace ageDetermination
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Введите возраст: ");

			int age;

			// Данные вводятся пользователем, и если эти данные не являются целым числом
			// Выводится сообщение об ошибке
			if(int.TryParse(Console.ReadLine(), out age)) Console.WriteLine(GetCorrectAge(age));
			else Console.WriteLine("Введенные данные не являются целым числом.");
		}

		/// <summary>
		/// Возвращает строку с правильным согласованием возраста со словом "год".
		/// </summary>
		/// <param name="n">Возраст в годах.</param>
		public static string GetCorrectAge(int n)
		{
			if(n < 0 || n > 99) return "Введён некорректный возраст.";

			string correctPrintOfAge = ""; // Строка с правильным согласованием возраста со словом "год"

			// Проверяются все возможные варианты возраста
			// Вследствие чего устанавливается правильное написание возраста со словом "год
			if(n >= 11 && n <= 19)
			{
				correctPrintOfAge = $"Мне {n} лет.";
			}
			else if(n % 10 == 1)
			{
				correctPrintOfAge = $"Мне {n} год.";
			}
			else if(n % 10 >= 2 && n % 10 <= 4)
			{
				correctPrintOfAge = $"Мне {n} года.";
			}
			else if (n % 10 == 0 || n % 10 >= 5 && n % 10 <= 9)
			{
				correctPrintOfAge = $"Мне {n} лет.";
			}

			return correctPrintOfAge;
		}
	}
}
