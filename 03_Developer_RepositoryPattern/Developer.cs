using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Developer_RepositoryPattern
{
    public class Developer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public bool HasPluralSight { get; set; }

        public Developer() { }
        public Developer(string id, string lastName, bool hasPluralSight)
        {
            ID = id;
            LastName = lastName;
            HasPluralSight = hasPluralSight;
        }
    }
}
