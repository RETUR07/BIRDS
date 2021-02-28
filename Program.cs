using System;

namespace BIRDS
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Chicken ch = new Chicken(2.5);

                ch.ItIsFlying();
                ch.ItIsSwimming();

                if (ch.IsItReadyToBeEaten()) ch.Say();
                else Console.WriteLine("wait");

                ch.weight = 1.4;
                if (ch.IsItReadyToBeEaten()) ch.Say();
                else Console.WriteLine("wait");

                Pinguin p = new Pinguin(5);
                p.ItIsSwimming();
                p.Say();
                p.IsItReadyToBeEaten();
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally { Console.WriteLine("program ended"); }
            }
    }
    }

