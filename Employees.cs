using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise1
{
	public class Employees : IEmployees
	{
		private int _idCounter = 0;
		Dictionary<int, IEmployee> _employees;

		public Employees()
		{
			_employees = new Dictionary<int, IEmployee>();
		}

		// Initiates input for new employee and adds said employee to the list
		public void AddEmployee()
		{
			Console.Clear();
			
			Console.Write("Input the employees name: ");
			string name = Console.ReadLine();


			int salary = 0;

			do
			{
				Console.Write("Input the employees salary: ");
				string salaryInput = Console.ReadLine();

				if (int.TryParse(salaryInput, out salary))
					break;
				else
					Console.WriteLine("Input only integer values! Try again.\n");

			} while (true);

			Console.Clear();
			
			_employees.Add(++_idCounter, new Employee(_idCounter, name, salary));
			Console.WriteLine($"Employee with \nID: {_idCounter} \nName: {name} \nSalary: {salary} \nadded to record. \n");
		}

		
		// Displays all currently registered employees, showing id, name, salary 
		public void DisplayAllEmployee()
		{
			foreach (var employee in _employees)
			{
				Console.WriteLine($"Employee ID: {employee.Key} Name: {employee.Value.Name} Salary: {employee.Value.Salary}");
			}
		}

		// Display a single employees information 
		// TODO: actually do what i said it does >_<
		public IEmployee GetEmployee(int id)
		{
			
			if (_employees.ContainsKey(id))
			{
				Console.WriteLine(_employees[id]);
				return _employees[id];
			}

			Console.WriteLine($"No Employee with the id {id} was found! Try again. \n");
			return null;
		}

		// Initiates input for removing an employee and removes said employee from the list
		public void RemoveEmployee()
		{
			int id = 0;

			do
			{
				Console.Clear();
				Console.Write("Input the id of employee: ");
				string idInput = Console.ReadLine();

				if (int.TryParse(idInput, out id))
					break;
				else
					Console.WriteLine("Employee IDs consists of only integers! Try again.\n");

			} while (true);

			Console.Clear();

			if (_employees.ContainsKey(id))
			{
				Console.WriteLine($"Employee {_employees[id].Name} Id: {_employees[id].Id} removed from record. \n" );
				_employees.Remove(id);
			}
			else
			{
				Console.WriteLine($"No Employee with the id {id} was found! Try again. \n");
			}
		}

		// Change the specified employees name
		public void ChangeEmployeeName()
		{
			int id = 0; 
			do
			{
				Console.Clear();
				Console.Write("Input the id of employee: ");
				string idInput = Console.ReadLine();

				if (int.TryParse(idInput, out id))
					break;
				else
					Console.WriteLine("Employee IDs consists of only integers! Try again.\n");

			} while (true);

			
			if (_employees.ContainsKey(id))
			{
				Console.Write("Input the new name: ");
				string newName = Console.ReadLine();

				_employees[id].ChangeName(newName);
			}
			else
			{
				Console.WriteLine($"No Employee with the id {id} was found! Try again. \n");
			}		
		}


		// Change the specified employees salary 
		public void ChangeEmployeeSalary()
		{
			int id = 0;
			
			do
			{
				Console.Clear();
				Console.Write("Input the id of employee: ");
				string idInput = Console.ReadLine();

				if (int.TryParse(idInput, out id))
					break;
				else
					Console.WriteLine("Employee IDs consists of only integers! Try again.\n");

			} while (true);


			if (_employees.ContainsKey(id))
			{
				Console.Write("Input the new salary: ");

				int salary = 0;

				do
				{
					Console.Write("Input the employees salary: ");
					string salaryInput = Console.ReadLine();

					if (int.TryParse(salaryInput, out salary))
						break;
					else
						Console.WriteLine("Input only integer values! Try again.\n");

				} while (true);

								
				_employees[id].ChangeSalary(salary);
			}
			else
			{
				Console.WriteLine($"No Employee with the id {id} was found! Try again. \n");
			}

		}
	}
}
