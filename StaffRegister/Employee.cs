

namespace StaffRegister
{
    public class Employee
    {
		private string firstName;
		private string lastName;
        private int salary;

        public Employee(string _firstName, string _lastName, int _salary)
        {
            firstName = _firstName;
            lastName = _lastName;
            salary = _salary;
        }

        public string Name
		{
			get { return firstName + " " + lastName; }
		}


		public int Salary
		{
			get { return salary; }
			set { salary = value; }
		}

	}
}
