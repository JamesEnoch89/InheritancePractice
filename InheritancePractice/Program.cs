using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var newHuman = new Human("James");
            Console.WriteLine($"Hi, i'm {newHuman.Name}. I am a human/alien. Arrived on earth at {newHuman.Birthday}");

            var newPanda = new Panda("Jack Black");
            Console.WriteLine($"Hi, i'm {newPanda.Name}. I am a bad actor. Arrived on earth at {newPanda.Birthday}");

            var newRobot = new Robot("Bender");
            Console.WriteLine($"Hi, i'm {newRobot.Name}. I am a drunk. Arrived on earth at {newRobot.Birthday}");


            newHuman.Adopt(newPanda);
            newHuman.Adopt(newRobot);

            foreach (IPet pet in newHuman.Pets)
            {
                Console.WriteLine($"{pet} is in James' PetList");

            }

            Console.WriteLine($"{newRobot}'s owner is {newRobot.OwnersName}");
            Console.WriteLine($"{newPanda}'s owner is {newPanda.OwnersName}");


            Console.WriteLine($"The Pandas owner is: {newPanda.OwnersName}");
            Console.WriteLine($"Robots owner is: {newRobot.OwnersName}");

            newRobot.StartUp();
            newRobot.GetState();
            newRobot.ShutDown();
            newRobot.GetState();

        }
    }
}
