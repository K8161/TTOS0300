using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko7T3
{
    abstract class Person
    {
        public string SocialId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    //    public DateTime TimeOfBirth { get; set; }

        public Person()
            {
            }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
