using System;

namespace numbersInArray
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Write($"Введите размер массива: ");

			int size;
			
			 // Данные вводятся пользователем, и если эти данные не являются целым числом
			// Выводится сообщение об ошибке
			if(int.TryParse(Console.ReadLine(), out size))
			{
				int[] numbers = new int[size];
				FillArrayWithRandomValues(numbers);

				Console.WriteLine("Массив:");
				PrintArray(numbers);

				PrintNumberOfEvenAndOddNumbers(numbers);
			}
			else Console.WriteLine("Введенные данные не являются целым числом.");
		}

		/// <summary>
		/// Выводит на экран количество четных и нечетных чисел.
		/// </summary>
		/// <param name="array">Массив, в котором необходимо произвести подсчёт чисел.</param>
		public static void PrintNumberOfEvenAndOddNumbers(int[] array)
		{
			int evenNumbers = 0;
			int oddNumbers = 0;

			foreach(var number in array)
			{
				if(number % 2 == 0) evenNumbers++;
				else oddNumbers++;
			}

			Console.WriteLine($"Количество четных чисел - {evenNumbers}");
			Console.WriteLine($"Количество нечетных чисел - {oddNumbers}");
		}

		/// <summary>
		/// Заполняет массив случайными числами.
		/// </summary>
		/// <param name="array">Массив, который необходимо заполнить.</param>
		public static void FillArrayWithRandomValues(int[] array)
		{
			var random = new Random();
			for(int i = 0; i < array.Length; i++) array[i] = random.Next(500);
		}

		/// <summary>
		/// Выводит массив на экран.
		/// </summary>
		/// <param name="array">Массив, который необходимо вывести.</param>
		public static void PrintArray(int[] array)
		{
			Console.Write("[ ");
			for(int i = 0; i < array.Length; i++)
			{
				if(i == array.Length - 1) Console.Write(array[i]);
				else Console.Write(array[i] + ", ");
			}
			Console.Write(" ]");
			Console.WriteLine();
		}
	}
}
