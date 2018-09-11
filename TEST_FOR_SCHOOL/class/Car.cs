using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_FOR_SCHOOL
{ 
    class Car : Obj
    {
        private int _releaseYear = 0;
        private string _modelCar;

        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                if(value >= 1806 && value <= 2018)
                {
                    _releaseYear = value;
                }
                else
                {
                    Console.WriteLine("Car has never been!");
                }
            }
        }

        public string ModelCar
        {
            get { return _modelCar; }
            set { _modelCar = value; }
        }

        public Car()
            :base()
        {

        }

        public override string ToString()
        {
            return '[' + base.ToString() + ']' + " [Car] " + _modelCar + ", " + _releaseYear.ToString();
        }
    }
}
