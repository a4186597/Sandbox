using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogDoors
{
    class DogDoorTester
    {
        public static void Execute()
        {
            DogDoor door = new DogDoor();
            door.AddAllowedBark(new Bark("rowlf"));
            door.AddAllowedBark(new Bark("rooowlf"));
            door.AddAllowedBark(new Bark("rawlf"));
            door.AddAllowedBark(new Bark("woowf"));

            BarkRecognizer recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);

            // 模擬硬體聽到 Bark
            Console.WriteLine("Bruce starts barking.");
            recognizer.Recongize(new Bark("Rowlf"));

            Console.WriteLine("\nBruce has gone outside...");

            try
            {
                System.Threading.Thread.Sleep(10000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nBruce all done...");
            Console.WriteLine("...but he's stuck outside!");

            // 模擬硬體聽到 Bark (不是 Bruce!)

            Bark smallDogBark = new Bark("yip");
            Console.WriteLine("A small dog starts barking.");
            recognizer.Recongize(smallDogBark);

            try
            {
                System.Threading.Thread.Sleep(5000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // 模擬硬體再一次聽到 Bark
            Console.WriteLine("\nBruce starts barking.");
            recognizer.Recongize(new Bark("Rowlf"));

            Console.WriteLine("\nBruce's back inside...");

        }
    }
}
