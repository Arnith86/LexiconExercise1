using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise1
{
	public interface IEmployees
	{
		public void AddEmployee();
		public void RemoveEmployee();
		public IEmployee GetEmployee(int id);
		public void DisplayAllEmployee();
		public void ChangeEmployeeName();
		public void ChangeEmployeeSalary();
	}
}
