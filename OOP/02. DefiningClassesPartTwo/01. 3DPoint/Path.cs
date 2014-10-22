using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._3DPoint
{
    public class Path : IEnumerable<Point3D>
    {
        public List<Point3D> path = new List<Point3D>();

        public List<Point3D> Paths
        {
            get
            {
                return this.path;
            }
            set
            {
                this.path = value;
            }

        }

        public void AddPoint(Point3D point)
        {
            Paths.Add(point);
        }

        public IEnumerator<Point3D> GetEnumerator()
        {
            foreach (Point3D point in path)
                yield return point;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Point3D>)this).GetEnumerator();
        }

    }
}
