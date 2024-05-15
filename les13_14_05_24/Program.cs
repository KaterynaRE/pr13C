using cl1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace les13_14_05_24
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//			Завдання 1:
			//Для масиву цілих реалізуйте наступні запити:
			//+ Отримати весь масив цілих.
			//+ Отримати парні цілі.
			//+ Отримати непарні цілі.
			//+ Отримати значення більше заданого.
			//+ Отримати числа в заданому діапазоні.
			//+ Отримати числа, кратні семи.Результат відсортуйте за зростанням.
			//+ Отримати числа, кратні восьми.Результат відсортуйте зa спаданням.

			//int size = 20;
			//int[] arrayInt = new int[size];

			//Random randomM = new Random();
			//for (int i = 0; i < size; i++)
			//{
			//	arrayInt[i] = randomM.Next(30);
			//	Console.Write(arrayInt[i] + " ");
			//}
			//Console.WriteLine();

			//var arrNew = from i in arrayInt select i;

			//Console.WriteLine("\nThe array:\n");
			//foreach (int item in arrNew)
			//{
			//	Console.Write($"{item} ");
			//}
			//Console.WriteLine();

			//var arrNewEven = from i in arrayInt where i % 2 == 0 select i;
			//Console.WriteLine("\nOnly the even elements:\n");
			//foreach (int item in arrNewEven)
			//{
			//	Console.Write($"{item} ");
			//}
			//Console.WriteLine();

			//var arrNewOdd = from i in arrayInt where i % 2 != 0 select i;
			//Console.WriteLine("\nOnly the odd elements:\n");
			//foreach (int item in arrNewOdd)
			//{
			//	Console.Write($"{item} ");
			//}
			//Console.WriteLine();


			//int num = 4;
			//var arrNewvalueMore = arrayInt.Where(i => i > num).ToArray();
			//Console.WriteLine($"\nValue in array more {num}: \n");
			//foreach (int item in arrNewvalueMore)
			//{
			//	Console.Write($"{item} ");
			//}
			//Console.WriteLine();


			//int start = 3;
			//int end = 18;
			//var arrInDiapazon = arrayInt.Where(i => i > start && i < end).ToArray();
			//Console.WriteLine($"\nValue in array {start}-{end} \n");
			//foreach (int item in arrInDiapazon)
			//{
			//	Console.Write($"{item} ");
			//}
			//Console.WriteLine();

			//var arrMultiplesOfSeven = arrayInt.Where(i => i % 7 == 0).ToArray().OrderBy(i => i);
			//Console.WriteLine($"\nnumbers that are multiples of seven: \n");
			//foreach (int item in arrMultiplesOfSeven)
			//{
			//	Console.Write($"{item} ");
			//}
			//Console.WriteLine();

			//IEnumerable<int> arrMultiplesOfEight = arrayInt.Where(i => i % 8 == 0).ToArray().OrderByDescending(i => i);
			//Console.WriteLine($"\nnumbers that are multiples of eight: \n");
			//foreach (int item in arrMultiplesOfEight)
			//{
			//	Console.Write($"{item} ");
			//}
			//Console.WriteLine();



			//			Завдання 2:
			//Для масиву рядків з назвою міст, реалізуйте наступні запити:
			//+ Отримати весь масив міст.
			//+ Отримати міста з довжиною назви, що дорівнює заданому.
			//+ Отримати міста, назви яких починаються з літери A.
			//+ Отримати міста, назви яких закінчуються літерою M.
			//+ Отримати міста, назви яких починаються з літери N і закінчуються літерою K.
			//+ Отримати міста, назви яких починаються з Ne. Результат відсортувати за спаданням.


			//List<string> city = new List<string>() {
			//	"Zp", "Kushugum", "Poznan","Krakov","Varshawa", "Kurnic", "Berlin", "Wroclav", "Kolobgeh", "Hurgada","Kair"};

			//var selectedAll = city.ToList();
			//foreach (var cityItem in selectedAll)
			//{
			//	Console.WriteLine(cityItem);
			//}


			//int len = 6;
			//List<string> lenCity = city.Where(i => i.Length == len).ToList();
			//Console.WriteLine($"\nCity with lenght name {len}\n");
			//foreach (var cityItem in lenCity)
			//{
			//	Console.WriteLine(cityItem);
			//}

			//List<string> nameCityP = city.Where(i => i.StartsWith("P")).ToList();
			//Console.WriteLine($"\nCity name startWith: P\n");
			//foreach (var cityItem in nameCityP)
			//{
			//	Console.WriteLine(cityItem);
			//}

			//List<string> nameCityN = city.Where(i => i.EndsWith("n")).ToList();
			//Console.WriteLine($"\nCity name endtWith: n\n");
			//foreach (var cityItem in nameCityN)
			//{
			//	Console.WriteLine(cityItem);
			//}

			//List<string> nameCityPN = city.Where(i => i.StartsWith("P") && i.EndsWith("n")).ToList();
			//Console.WriteLine($"\nCity name startWith:P endtWith: N\n");
			//foreach (var cityItem in nameCityPN)
			//{
			//	Console.WriteLine(cityItem);
			//}


			//List<string> nameCityDec = city.Where(i => i.StartsWith("Ku")).OrderByDescending(i => i).ToList();
			//Console.WriteLine($"\nCity name startWith:Ku \n");
			//foreach (var cityItem in nameCityDec)
			//{
			//	Console.WriteLine(cityItem);
			//}


			//			Завдання 3:
			//Реалізуйте тип користувача «Студент» з інформацією про ім'я, прізвище, вік, назву навчального закладу.
			//Для масиву «Студент» реалізуйте наступні запити:
			//+ Отримати весь масив студентів.
			//+ Отримати список студентів з ім'ям Boris.
			//+ Отримати список студентів з прізвищем, яке починається з Bro.
			//+ Отримати список студентів, старших 19 років.
			//+ Отримати список студентів, старших 20 років і молодших 23 років.
			//+ Отримати список студентів, які навчаються в MIT.
			//+ Отримати список студентів, які навчаються в Oxford, і вік яких старше 18 років.Результат відсортуйте за віком, за
			//спаданням

			List<Student> students = new List<Student>()
			{
			   new Student( 1, "Ivan", "Ivanov", 19, "Step"),
			   new Student( 2, "Ian", "Portnov", 23, "Step"),
			   new Student( 3, "Oleg", "Bron", 33, "Step"),
			   new Student( 4, "Den", "Bronislav", 35, "Poletexnika"),
			   new Student( 5, "Den", "Denov", 35, "Poletexnika"),
			   new Student( 6, "Anna", "Annovna", 22, "ZNU")
			};

			List<Student> students1 = (from i in students select i).ToList();
			foreach (var item in students1)
			{
				Console.WriteLine(item);
			}

			List<Student> students2 = students.Where(i => i.FirstName == "Den").ToList();
			Console.WriteLine("\nStudents with name Den: ");
			foreach (var item in students2)
			{
				Console.WriteLine(item);
			}


			List<Student> students3 = students.Where(i => i.LastName.StartsWith("Bro")).TakeWhile(s => s.LastName.StartsWith("Bro")).ToList();

			Console.WriteLine("\nStudents with name start 'Bro': ");
			foreach (var item in students3)
			{
				Console.WriteLine(item);
			}


			List<Student> students4 = students.Where(i => i.Age > 19).ToList();
			Console.WriteLine("\nStudents whoes age more 19: ");
			foreach (var item in students4)
			{
				Console.WriteLine(item);
			}

			List<Student> students5 = students.Where(i => i.Age > 20 && i.Age <23).ToList();
			Console.WriteLine("\nStudents whoes age 20-23: ");
			foreach (var item in students5)
			{
				Console.WriteLine(item);
			}


			List<Student> students6 = students.Where(i => i.NameEducational.StartsWith("ZNU")).ToList();
			Console.WriteLine("\nStudents whoes Name Educational is 'ZNU': ");
			foreach (var item in students6)
			{
				Console.WriteLine(item);
			}

			List<Student> students7 = students.Where(i => i.NameEducational.StartsWith("Step")).OrderBy(s => s.Age > 18).ThenByDescending(st => st.Age).ToList();
			Console.WriteLine("\nStudents whoes Name Educational is 'Step' and age more 18: ");
			foreach (var item in students7)
			{
				Console.WriteLine(item);
			}



		}
	}
}
