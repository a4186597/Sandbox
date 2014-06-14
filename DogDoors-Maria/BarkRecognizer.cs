using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogDoors
{
    public class BarkRecognizer
    {
        private DogDoor _door;

        public BarkRecognizer(DogDoor door)
        {
            _door = door;
        }

        private DogDoor Door
        {
            get
            {
                return _door;
            }
        }

        public void Recongize(Bark bark)
        {
            Console.WriteLine("\tRecognizer: Heard a '{0}' ", bark.Sound);
            if (_door.AllowedBarks.Contains(bark))
            {
                _door.Open();
            }
            else
            {
                Console.WriteLine("This dog is not allowed.");
            }
        }
    }
}
