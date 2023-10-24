namespace ConsoleApp1.Models
{
	internal class Company
	{
		private string _name;
		private Employee[] employee = new Employee[0];
        public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public void AddUser(Employee item)
		{
			Array.Resize(ref employee, 1);
		}
		public void RemoveUser()
		{

		}
		public void GetUser()
		{

		}
		public void GetAllUsers()
		{

		}
		public void UpdateUser()
		{

		}
	}
}
