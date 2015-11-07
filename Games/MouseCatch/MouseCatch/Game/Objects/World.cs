using MouseCatch.Helper.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseCatch.Game.Objects
{
    public class World
    {
        private IList<Mouse> Mice { get; set; }

        public World()
        {
            Mice = new List<Mouse>();
            Init();
        }

        private void Init()
        {
            Mouse mouse = new Mouse(new Vec2(0, 0));
            mouse.SetVelocity(new Vec2(20, 15));
            AddMouse(mouse);
        }

        public void AddMouse(Mouse mouse)
        {
            Mice.Add(mouse);
        }

        public void Loop(double dt)
        {
            foreach(Mouse mouse in Mice)
            {
                mouse.Update(dt);
            }
        }

        public IEnumerable<Mouse> GetMice()
        {
            return Mice;
        }
    }
}
