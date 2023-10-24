namespace ConsoleApp1.Models
{
	internal class Employee
	{
		private string _name;
		private string _surname;
		private string _username;
		private int _age;

        public string Name
		{
			get{return _name;}
			set
			{
				if (value.Length > 0)
				{
					_name = value.ToUpper()[0] + value.Substring(1);
				}
				else
				{
					Console.WriteLine("Ad duzgun daxil edilmeyib!!!");
				}
			}
		}
		public string Surname
		{
			get { return _surname; }
			set
			{
				if (value.Length > 0)
				{
					_surname = value.ToUpper()[0] + value.Substring(1);
				}
				else
				{
					Console.WriteLine("Soyad duzgun daxil edilmeyib!!!");
				}
			}
		}
		public string Username
		{
			get { return _username; }
			set { _username = value; }
		}
		public int Age
		{
			get { return _age; }
			set 
			{
                if (value >= 0)
                {
					_age = value;
				}
                else
                {
                    Console.WriteLine("Yash duzgun daxil edilmeyib!!!");
                }
            }
		}
	}
}
