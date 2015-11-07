using System;

namespace MouseCatch.Helper.Math
{
    public class Vec2
    {
        public double TransformX { get; set; }
        public double TransformY { get; set; }

        public Vec2()
        {
            this.TransformX = 0;
            this.TransformY = 0;
        }

        public Vec2(double x, double y)
        {
            this.TransformX = x;
            this.TransformY = y;
        }

        public Vec2 Lerp(Vec2 start, Vec2 destination, double t)
        {
            Vec2 point = new Vec2();

            point.TransformX = (1 - t) * start.TransformX + t * destination.TransformX;
            point.TransformY = (1 - t) * start.TransformY + t * destination.TransformY;

            return point;
        }
    }

    public static class Vec2Oporators
    {
        public static Vec2 Subtract(this Vec2 me, Vec2 position)
        {
            me.TransformX = me.TransformX - position.TransformX;
            me.TransformY = me.TransformY - position.TransformY;

            return me;
        }

        public static Vec2 Add(this Vec2 me, Vec2 position)
        {
            me.TransformX = me.TransformX + position.TransformX;
            me.TransformY = me.TransformY + position.TransformY;

            return me;
        }

        public static Vec2 Scale(this Vec2 me, double scale)
        {
            me.TransformY = me.TransformY * scale;
            me.TransformX = me.TransformX * scale;

            return me;
        }
    }
}
