using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public double getVolume()
        {
            return length * width * height;
        }

        public void setLength(double len)
        {
            length = len;
        }

        public void setWidth(double wid)
        {
            width = wid;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

        public static Box operator+()
    }




    class test
    {
        static void Main(string[] args)
        {

        }
    }
}
