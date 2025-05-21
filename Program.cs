namespace LexiconExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;

            Employees employees = new Employees();


            do
            {
                Console.WriteLine();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1: Add an employee.");
				Console.WriteLine("2: Remove an employee.");
				Console.WriteLine("3: Display all employees.");
                Console.WriteLine("4: Change employees name.");
				Console.WriteLine("5: Change employees salary.");


				string input = Console.ReadLine();

                if (int.TryParse(input, out int intInput))
                {
                    switch (intInput)
                    {
                        case 1: employees.AddEmployee();
                            break;
						case 2:
                            employees.RemoveEmployee();
							break;
						case 3:
							employees.DisplayAllEmployee();
							break;
						case 4:
							employees.ChangeEmployeeName();
							break;
						case 5:
							employees.ChangeEmployeeSalary();
							break;
						default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You must enter one of the number options.");
                }
				
			} while (!exitProgram);
            
		}
	}
}
