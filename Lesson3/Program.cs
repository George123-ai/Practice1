using static Lesson3.Animal;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Animal animal= new Animal();
            Console.WriteLine();
            Console.WriteLine(animal.Voice(AnimalVoice.Cat));
            
        }
    }
}