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

        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.width = b.width + c.width;
            box.height = c.height + b.height;

            return box;
        }

        public static bool operator ==(Box a, Box b)
        {
            bool ret = false;
            if (a.length == b.length && a.width == b.width && a.height == b.height)
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator !=(Box a, Box b)
        {
            bool ret = false;
            if (a.length != b.length || a.width != b.width || a.height != b.height)
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator <(Box a, Box b)
        {
            bool ret = false;
            if (a.length < b.length && a.width < b.width && a.height < b.height)
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator >(Box a, Box b)
        {
            bool ret = false;
            if (a.length > b.length && a.width > b.width && a.height > b.height)
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator <=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length <= rhs.length && lhs.height
                <= rhs.height && lhs.width <= rhs.width)
            {
                status = true;
            }
            return status;
        }

        public static bool operator >=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length >= rhs.length && lhs.height
               >= rhs.height && lhs.width >= rhs.width)
            {
                status = true;
            }
            return status;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", length, width, height);
        }
    }



    class test
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();          // 声明 Box1，类型为 Box
            Box Box2 = new Box();          // 声明 Box2，类型为 Box
            Box Box3 = new Box();          // 声明 Box3，类型为 Box
            Box Box4 = new Box();
            double volume = 0.0;   // 体积

            // Box1 详述
            Box1.setLength(6.0);
            Box1.setWidth(7.0);
            Box1.setHeight(5.0);

            // Box2 详述
            Box2.setLength(12.0);
            Box2.setWidth(13.0);
            Box2.setHeight(10.0);

            // 使用重载的 ToString() 显示两个盒子
            Console.WriteLine("Box1： {0}", Box1.ToString());
            Console.WriteLine("Box2： {0}", Box2.ToString());

            // Box1 的体积
            volume = Box1.getVolume();
            Console.WriteLine("Box1 的体积： {0}", volume);

            // Box2 的体积
            volume = Box2.getVolume();
            Console.WriteLine("Box2 的体积： {0}", volume);

            // 把两个对象相加
            Box3 = Box1 + Box2;
            Console.WriteLine("Box3： {0}", Box3.ToString());
            // Box3 的体积
            volume = Box3.getVolume();
            Console.WriteLine("Box3 的体积： {0}", volume);

            //comparing the boxes
            if (Box1 > Box2)
                Console.WriteLine("Box1 大于 Box2");
            else
                Console.WriteLine("Box1 不大于 Box2");
            if (Box1 < Box2)
                Console.WriteLine("Box1 小于 Box2");
            else
                Console.WriteLine("Box1 不小于 Box2");
            if (Box1 >= Box2)
                Console.WriteLine("Box1 大于等于 Box2");
            else
                Console.WriteLine("Box1 不大于等于 Box2");
            if (Box1 <= Box2)
                Console.WriteLine("Box1 小于等于 Box2");
            else
                Console.WriteLine("Box1 不小于等于 Box2");
            if (Box1 != Box2)
                Console.WriteLine("Box1 不等于 Box2");
            else
                Console.WriteLine("Box1 等于 Box2");
            Box4 = Box3;
            if (Box3 == Box4)
                Console.WriteLine("Box3 等于 Box4");
            else
                Console.WriteLine("Box3 不等于 Box4");

            Console.ReadKey();
        }
    }
}
