using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task_38_04
{
    class Student
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Patronymic { get; private set; }
        public string Group { get; private set; }
        public Paul Paull { get; private set; }
        public DateTime DateOfBirth { get; private set; }

        public Student(string name, string surname, string patronymic, string group, Paul paull, DateTime dateOfBirth)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Group = group;
            Paull = paull;
            DateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return $"{Surname} {Name} {Patronymic}, {Group}, пол: {StringPaul()}, дата рождения: {DateOfBirth:dd.MM.yyyy}";
        }
        public string StringPaul()
        {
            switch (Paull)
            {
                case Paul.female: return "женский"; break;
                case Paul.male: return "мужской"; break;
            }
            return null;
        }
    }
}
