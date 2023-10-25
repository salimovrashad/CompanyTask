using Company_Project;

Company company1 = new Company("Socar kbr");
Employee employe = new Employee("vugar", "sariyev", "vuqar123");
char option;
do 
{
    Console.WriteLine("1. Create a company");
    Console.WriteLine("2. Create an employee");
    Console.WriteLine("3. Add employee");
    Console.WriteLine("4. Get one employee");
    Console.WriteLine("5. Get all employee");
    Console.WriteLine("6. Remove all employee");
    Console.WriteLine("7. Edit employee");
    option = Convert.ToChar(Console.ReadLine());

    switch (option)
    {
        case '1':
            Console.WriteLine("Company created...");
            company1 = new Company("Socar kbr");
            break;
        case '2':
            Console.WriteLine("Ad: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyad: ");
            string surname = Console.ReadLine();
            Console.WriteLine("User: ");
            string username = Console.ReadLine();
            employe = new Employee(name, surname, username);
            break;
        case '3':
            company1.AddUser(employe);
            break;
        case '4':
            Console.WriteLine("Name daxil edin...");
            string inpname = Console.ReadLine();
            if (inpname == employe.Username)
            {
                Console.WriteLine("User tapildi"); ;
            }
            else
            {
                Console.WriteLine("Employee with given username not found");
            }
            break;
		case '5':
			company1.GetAllUser(employe.Username);
			break;
        case '6':
            company1.RemoveUser(employe);
            break;
        case '7':
            company1.EditUser(employe.Username);
            
            break;
        default:
            Console.WriteLine("Choose from options");
            break;
    }
} while (option != 'q');
