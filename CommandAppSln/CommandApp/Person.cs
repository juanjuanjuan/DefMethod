using System;

namespace CommandApp
{
    class Person
    {
        string name;
        string middleInitial;
        public string lastname;
        public string gender;
        string color;
        public DateTime birth;

        public Person(string name, string middleInitial, string lastname, string gender, string color, DateTime birth) {
            this.name = name;
            this.middleInitial = middleInitial;
            this.lastname = lastname;
            this.gender = gender;
            this.color = color;
            this.birth = birth;
        }

        public override string ToString()
        {
            // last name, first name, gender, date of birth, favorite color
            return lastname + " " + name + " " + gender + " " + birth.ToString("M/d/yyyy") + " " + color;
        }
    }
}