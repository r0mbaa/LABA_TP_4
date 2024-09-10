using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public abstract class Man
    {
        private string firstName;

        private string lastName;

        private int age;

        public string FirstName { get => firstName; set => firstName = value; }

        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age;
            set { 
                if ( value >= 0 && value < 150 ) age = value;
            }
        }
    }

}
