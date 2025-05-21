using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise1
{
	public interface IEmployee
	{
		int Id { get; }
		string Name { get; }
		public int Salary { get; }
		public void ChangeName(string newName);
		public void ChangeSalary(int salary);
	}
}
