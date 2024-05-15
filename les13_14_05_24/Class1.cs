using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cl1
{
	public class Student
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age {  get; set; }
		public string NameEducational {  get; set; }

		public Student(int Id, string FirstName, string LastName, int Age, string NameEducational) 
		{
			this.Id = Id;
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Age = Age;
			this.NameEducational = NameEducational;
		}

		public override string ToString()
		{
			return $"\nId: {Id},\nFirst name: {FirstName},\nLast name: {LastName},\nAge: {Age},Name educational: {NameEducational} ";
		}

	}
}
