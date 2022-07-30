﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson
{
    class Person
    {
        public string Name;
        public string Surnme;
        private DateTime dateOfBirth;
        private string contactNumber;

        public static int Count = 0;

        public string ContactNumber
        {
            get { return contactNumber; }
            set 
            {   if (value.Length < 9)
                {
                    Console.WriteLine("Invalid contact number");
                }
                else
                {
                    contactNumber = value;
                }
            }
        }

        public Person(string firstName, string lastName)
        {
            Name = firstName;
            Surnme = lastName;
            Count++;
        }

        public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName)
        {
            SetDateOfBirth(dateOfBirth);
        }

        public void SetDateOfBirth(DateTime date)
        {
            if (date > DateTime.Now)
            {
                Console.WriteLine("Invalid date of birth");
            }
            else
            { 
                dateOfBirth = date;
            }
        }

        public DateTime GetDateOfBirth() => dateOfBirth;

        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {Name}, {GetDateOfBirth()}");
        }
    }
}
