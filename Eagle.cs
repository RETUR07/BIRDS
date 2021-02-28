using System;
using System.Collections.Generic;
using System.Text;

namespace BIRDS
{
    class Eagle:birds, flying
    {
        public Eagle(double w) : base(w, -1)
        {
        }
        public bool IsItReadyToBeEaten()
        {
            return base.IsItReadyToBeEaten(-1, false);
        }
        public override void Say()
        {
            Console.WriteLine("qu@@@@@@@");
        }
        public void ItIsFlying()
        {
            Console.WriteLine("Eagle is flying!");
        }
    }
}
