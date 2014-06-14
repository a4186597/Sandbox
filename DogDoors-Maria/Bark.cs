using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogDoors
{
    public class Bark
    {
        private string _sound;

        public Bark(string sound)
        {
            _sound = sound;
        }

        public string Sound
        {
            get
            {
                return _sound;
            }
        }



        public override bool Equals(object bark)
        {
            if (bark is Bark)
            {
                Bark otherBark = (Bark)bark;
                if (_sound.Equals(otherBark.Sound, StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}