using System;
using System.Collections.Generic;
using System.Text;

namespace BIRDS
{
    class Chicken:birds, flying, swimming
    {
        public Chicken(double w) : base(w, 14)
        {
        }
        public bool IsItReadyToBeEaten()
        {
            return base.IsItReadyToBeEaten(1.5, true);
        }
        public override void Say()
        {
            Console.WriteLine("Cudah-tah-tah");
        }
        public void ItIsFlying()
        {
            Console.WriteLine("Chicken is flying!");
        }
        public void ItIsSwimming()
        {
            Console.WriteLine("Chicken is swimming!");
        }
    }
}
