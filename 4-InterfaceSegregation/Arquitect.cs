using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Arquitect : IActivities
    {
        public void Plan()
        {
            throw new ArgumentException();
        }

        public void Comunicate()
        {
            throw new ArgumentException();
        }

        public void Develop()
        {
            Console.WriteLine("I'm developing the functionalities required");
        }

        public void Test()
        {
            throw new ArgumentException();
        }

        public void Design()
        {
            Console.WriteLine("I'm designing the functionalities required");
        }

    }
}
