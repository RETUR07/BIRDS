using System;
using System.Collections.Generic;
using System.Text;

namespace BIRDS
{
    abstract class birds
    {
        public birds(double w, double f)
        {
            weight = w;
            fatness = f;
        }
        public double weight { get; set; }
        public double fatness { get; }
        public bool IsItReadyToBeEaten(double m, bool CanBeEaten)
        {
            if (CanBeEaten)
            {
                if (weight >= m) return true;
                return false;
            }
            else throw new Exception("It is usually not eaten and perhaps don't tasts good");
            
        }
        public abstract void Say();
    }
}
