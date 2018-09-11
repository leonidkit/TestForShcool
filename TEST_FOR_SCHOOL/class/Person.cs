using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_FOR_SCHOOL
{
    class Person : Obj
    {
        private string _firstName = "";
        private string _lastName = "";
        private int _age = 0;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 3 && value <= 110)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("You can`t use it app");
                }
            }
        }

        public Person()
            :base()
        {
            
        }

        public override string ToString()
        {
            return '[' + base.ToString() + ']' + " [Person] " + _firstName + " " + _lastName + ", " + _age.ToString();
        }
    }
}
