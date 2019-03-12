using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Insurance_RepositoryPattern
{
    public enum GenderType
    {
        Male = 1, Female, Other
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }

        public User() { }
        public User(string name, int age, GenderType gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
}
