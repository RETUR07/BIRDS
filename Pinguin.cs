using System;
using System.Collections.Generic;
using System.Text;

namespace BIRDS
{
    class Pinguin:birds, swimming
    {
        public Pinguin(double w) : base(w, 19)
        {
        }
        public bool IsItReadyToBeEaten()
        {
            return base.IsItReadyToBeEaten(-1, false);
        }
        public override void Say()
        {
            Console.WriteLine("a-a-a-a-a-a-a-a-a");
        }
        public void ItIsSwimming()
        {
            Console.WriteLine("pinguin is swimming!");
        }
    }
}
