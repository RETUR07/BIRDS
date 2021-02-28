using System;
using System.Collections.Generic;
using System.Text;

namespace BIRDS
{
    class Duck:birds, flying, swimming
    {
        public Duck(double w) : base(w, 19)
        {
        }
        public bool IsItReadyToBeEaten()
        {
            return base.IsItReadyToBeEaten(0.7, true);
        }
        public override void Say()
        {
            Console.WriteLine("Qua-Qua");
        }
        public void ItIsFlying()
        {
            Console.WriteLine("Duck is flying!");
        }
        public void ItIsSwimming()
        {
            Console.WriteLine("Duck is swimming!");
        }
    }
}
