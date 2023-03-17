using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Animal:SpeedVoice
    {
        public override string Voice(AnimalVoice animal)
        {
            return base.Voice(animal);
        }
        
         public enum AnimalVoice
        {
            Dog,
            Cat,
            Horse
        }
    }
}
