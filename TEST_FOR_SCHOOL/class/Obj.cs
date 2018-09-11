using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_FOR_SCHOOL
{
    class Obj
    {
        public DateTime timeStamp { get; private set; }

        private int _count = 0;
        public int Count
        {
            get { return _count; }
            private set { _count = value; }
        }

        public Obj()
        {
            this.Count = ++Count;
            timeStamp = DateTime.Now;
        }

        public override string ToString()
        {
            return timeStamp.ToString();
        }
    }
}
