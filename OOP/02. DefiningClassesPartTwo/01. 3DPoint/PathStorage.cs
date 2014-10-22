using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._3DPoint
{
    public static class PathStorage
    {

        public static void SavePath(Path points, string fullFileName)
        {
            if (String.IsNullOrWhiteSpace(fullFileName))
            {
                throw new ArgumentException("File name cannot be null or empty.");
            }

            using (StreamWriter fileWriter = new StreamWriter(fullFileName, false))
            {
                foreach (Point3D point in points)
                {
                    string line = String.Format("{0:F2} {1:F2} {2:F2}", point.x, point.y, point.z);
                    fileWriter.WriteLine(line);
                }
            }
        }

        public static Path LoadPath(string fullFileName)
        {
            Path points = new Path();

            using (StreamReader fileReader = new StreamReader(fullFileName))
            {
                string line;
                while ((line = fileReader.ReadLine()) != null)
                {
                    string[] coordinates = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int x, y, z;

                    x = int.Parse(coordinates[0]);
                    y = int.Parse(coordinates[1]);
                    z = int.Parse(coordinates[2]);

                    Point3D point = new Point3D(x, y, z);
                    points.AddPoint(point);
                }
                return points;
            }
        }


    }
}
