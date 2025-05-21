using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise1
{
	public class Employee : IEmployee
	{
		private int _id;
		private string _name;
		private int _salary;

		
		public Employee(int id, string name, int salary)
		{
			_id = id;
			_name = name;
			_salary = salary;
		}

		public int Id => _id;
		public string Name => _name;
		public int Salary => _salary;
		
		public void ChangeName(string newName)
		{
			_name = newName;
		}

		public void ChangeSalary(int salary)
		{
			_salary = salary;
		}

	}
}
