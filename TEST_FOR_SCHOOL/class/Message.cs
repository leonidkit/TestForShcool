using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_FOR_SCHOOL
{ 
    class Message : Obj
    {
        public string Msg { get; set; }

        public Message()
        : base()
        {

        }

        public override string ToString()
        {
            return '[' + base.ToString() + ']' + " [Message] " + Msg;
        }
    }
}
