using MouseCatch.Helper.Math;

namespace MouseCatch.Game.Objects
{
    public class WorldEntity
    {
        public Vec2 Position { get; protected set; }
        public Vec2 Scale { get; set; }
        public Vec2 Velocity { get; protected set; }
        public double Rotation { get; protected set; }

        public WorldEntity()
        {
            Rotation = 0.0d;
        }

        public void SetVelocity(Vec2 velocity)
        {
            Velocity = velocity;
            RotateToPoint(velocity);
        }

        public void RotateToPoint(Vec2 point)
        {
            Vec2 direction = point.Subtract(Position);
            Rotation = Angles.AngleInDegrees(direction);
        }

        protected void Move(double dt)
        {
            Position.TransformX += Velocity.TransformX * dt;
            Position.TransformY += Velocity.TransformY * dt;
        }

        public void Update(double dt)
        {
            Move(dt);
        }
    }
}
