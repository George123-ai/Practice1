using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesson3.Animal;

namespace Lesson3
{
    internal class SpeedVoice
    {
        public  virtual string Voice(AnimalVoice animal)
        {
            switch (animal)
            {
                case AnimalVoice.Dog:
                    return "Half";
                case AnimalVoice.Cat:
                    return "Miaoo";
                case AnimalVoice.Horse:
                    return "bbbrrrr";
                default:
                    return "Animal voice";
            }
        }
    }
}
