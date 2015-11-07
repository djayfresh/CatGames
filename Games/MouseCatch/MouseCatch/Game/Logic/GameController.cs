using MouseCatch.Game.Objects;
using MouseCatch.Helper.Math;
using MouseCatch.Helper.Time;
using System.Collections.Generic;
using System.Linq;

namespace MouseCatch.Game.Logic
{
    public class GameController
    {
        public Clock Clock { get; set; }
        public World World { get; set; }

        public GameController()
        {
            Clock = new Clock();
            World = new World();
        }

        public void Start()
        {
            Clock.Start();
        }

        public void Step()
        {
            Clock.Tick();

            World.Loop(Clock.DT);
        }
    }
}
