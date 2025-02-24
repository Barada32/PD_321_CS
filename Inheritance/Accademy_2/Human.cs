﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy_2
{
	internal class Human
	{
		/*_______________Поля_Класса__________________*/
		public string lastName{  get; set; }
		public string firstName { get; set; }
		public int age { get; set; }

		/*________________Конструкторы________________*/
		public Human(string lastName, string firstName, int age)
		{
			this.lastName = lastName;
			this.firstName = firstName;
			this.age = age;
			Console.WriteLine("HumConstructor:\t" + GetHashCode()) ;
        }
		public Human(Human other)//конструктор копирования
		{
			this.lastName = other.lastName;
			this.firstName = other.firstName;
			this.age = other.age;
			Console.WriteLine("HCopyConstructor: "+GetHashCode()) ;
		}	
		/*_________________Деструктор________________*/
		~Human() 
		{
            Console.WriteLine("HumDestrucor\t"+ GetHashCode());
        }
		/*________________Методы_____________________*/
		public void Info()
		{ 
			Console.Write($"{lastName},{firstName},{age} лет, ");
		}

		public override string ToString()//ovveride необходим для переопределения функции
		{
			return $"{lastName},{firstName},{age}";
		}
		public virtual void Init(string[] values) //virtrual необходим для переопределения поведения метода
		{
			lastName = values[1];
			firstName = values[2];
			age = Convert.ToInt32(values[3]);
		}
	}
}
