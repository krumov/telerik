﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._3DPoint
{
    class DistanceIn3D
    {
        public static double CaclDisance(Point3D pointOne, Point3D pointTwo)
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow(pointOne.x - pointTwo.x, 2) 
                + Math.Pow(pointOne.y - pointTwo.y, 2) + Math.Pow(pointOne.z - pointTwo.z, 2));

            return distance;
        }
    }
}
