using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseCatch.Helper.Math
{
    public class Angles
    {
        public static double RadiantsToDegree(double radiants)
        {
            return radiants * (180 / System.Math.PI);
        }

        public static double DegreeToRadiants(double degrees)
        {
            return degrees / (180 / System.Math.PI);
        }

        public static double AngleInDegrees(Vec2 position)
        {
            double angle = System.Math.Atan2(position.TransformY, position.TransformX);

            angle = angle < 0 ? Math.Angles.RadiantsToDegree(angle + System.Math.PI) : Math.Angles.RadiantsToDegree(angle);
            return angle;
        }

        public static double AngleInRadiants(Vec2 position)
        {
            double angle = System.Math.Atan2(position.TransformY, position.TransformX);

            return angle;
        }
    }
}
