using MouseCatch.Helper.Math;

namespace MouseCatch.Game.Objects
{
    public class Mouse : WorldEntity
    {
        private static int MouseIds = 0;
        
        public int MouseId { get; private set; }
        public int Points { get; private set; }
        

        public double LifeSpan { get; set; }

        public Mouse(Vec2 pos)
        {
            this.MouseId = MouseIds++;
            Points = 1;
            this.Scale = new Vec2(1, 1);
            this.Position = pos;
        }

        public void Move(Vec2 pos)
        {
            Position.TransformX = pos.TransformX;
            Position.TransformY = pos.TransformY;
        }
    }
}
