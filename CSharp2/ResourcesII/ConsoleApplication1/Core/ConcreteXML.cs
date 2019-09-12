﻿using Model;
using Model.MapXML;

namespace Core
{
	public class ConcreteXML : AbstractRegistry
	{
		public override Registry<Career> GetCareers()
		{
			return new Registry<Career>(new CareerMap());
		}

		public override Registry<Student> GetStudents()
		{
			return new Registry<Student>(new StudentMap());
		}
	}
}
