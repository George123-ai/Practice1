using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class DoctorAssistant:Doctor
    {
        public void _DoctorAssist() => Console.WriteLine(Name);

        public int AssistantAge { get; set; }

        public DoctorAssistant() 
        {

        }
    }
}
