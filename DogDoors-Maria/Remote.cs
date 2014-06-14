using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogDoors
{
    public class Remote
    {
        private DogDoor _door;

        public Remote(DogDoor door)
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

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (_door.IsOpen)
            {
                _door.Close();
            }
            else
            {
                _door.Open();
            }
        }
    }
}
