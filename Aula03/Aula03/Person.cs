﻿using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
=======
using System.Linq;
>>>>>>> 30e0b2fd275b1ac54ab836c9cb6795cadaeb9471
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public virtual string GetPersonDetails()
        {
            return $"Nome: {Name}, Idade: {Age}";
        }
    }
}
