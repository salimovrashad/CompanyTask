using ConsoleApp1.Models;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Employee employee = new Employee();

			Company company = new Company();
			company.AddUser(employee);
			
			Console.WriteLine("Iscinin adi: ");
			employee.Name = Console.ReadLine();

			Console.WriteLine("Iscinin soyadi: ");
			employee.Surname = Console.ReadLine();

			Console.WriteLine("Iscinin istifadeci adi: ");
			employee.Username = Console.ReadLine();

			Console.WriteLine("Iscinin yasi: ");
			employee.Age = Convert.ToInt32(Console.ReadLine());

			string employe = employee.Name + " " + employee.Surname;

            Console.WriteLine(company);

			//Company company = new Company();
   //         Console.WriteLine("Sirket adi: ");
			//company.Name = Console.ReadLine();
   //         Console.WriteLine("Sirket Iscileri: ");
        }
	}
}