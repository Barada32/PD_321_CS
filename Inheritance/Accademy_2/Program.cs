using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Human human=new Human("Montano","Oleg",25);
			Console.WriteLine(human);
			human.Info();

			Student student = new Student("Ivan", "Petrov", 25,"Chemestry","ww2024",95,98);
			Console.WriteLine(student);
			student.Info();

			Teacher teacher = new Teacher("Walter", "White", 50, "Chemestry",20);
			Console.WriteLine(teacher);
			teacher.Info();
			Graduate graduate = new Graduate("Hreder", "hank", 40, "Criminal", "OBN", 70, 40,"How to catch Hizenberg");
			graduate.Info();
            Console.WriteLine(graduate);
        }
	}
}
