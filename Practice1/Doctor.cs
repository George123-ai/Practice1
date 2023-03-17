using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Practice1
{
    internal class Doctor : HumanBase
    {
        public short y;
        public int v;


      
       public void Testmethod()
        {
            Name = "Dr. Liza";
            Age = y;
            publicHelloMen();
            internalByeMen();
            protectedWhyMen();
            
        }
        public Doctor():base()
        {

        }
        public Doctor(short t) : base(t)
        {
            this.y = t;
            //this.v = base.Age;
        }

        

    }
}
