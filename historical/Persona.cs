using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This class is meant to hold the information of people or characters or institutions
/// that participated on a given event or series of events
/// </summary>
namespace historian.historical {
    internal class Persona {
        private string name;
        private int age;
        private string title;
        private string origin; //country or region of origin
        

        //empty constructor
        public Persona() {
            name = string.Empty;
            age = 0;
            title = string.Empty;
            origin = string.Empty;
        }
        //filled constructors
        public Persona(string name, int age, string title, string origin) {
            this.name = name;
            this.age = age;
            this.title = title;
            this.origin = origin;
        }

        //public properties 
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Title { get { return title; } set { title = value; } }
        public string Origin { get { return origin; } set { origin = value; } }

        //ill do methods as I go

    }
}
