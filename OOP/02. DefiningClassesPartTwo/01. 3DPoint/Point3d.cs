using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._3DPoint
{

    public struct Point3D
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Point3D(int x, int y, int z) : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            StringBuilder endText = new StringBuilder();
            endText.AppendFormat("Point X: {0}", this.x.ToString());
            endText.AppendLine();
            endText.AppendFormat("Point Y: {0}", this.y.ToString());
            endText.AppendLine();
            endText.AppendFormat("Point Z: {0} \n", this.z.ToString());
            return endText.ToString();
        }

        public static readonly Point3D startPoint = new Point3D(0, 0, 0);

    }


    class Point3dTest
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D(3,5,2);
            
            Console.WriteLine(point);

            

        }
    }
}
