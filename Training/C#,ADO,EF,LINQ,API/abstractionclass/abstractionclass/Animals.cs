using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractionclass
{
    //animals is a derived class
    //sounds and animal type are meathod 
    internal class Animals : Sounds, AnimalType
    {

        private string name;
        private int eye,mouth,leg,tail;

        public Animals(string name, int eye, int mouth, int leg, int tail)
        {
            this.Name = name;
            this.Eye = eye;
            this.Mouth = mouth;
            this.Leg = leg;
            this.Tail = tail;
        }

        public string Name { get => name; set => name = value; }
        public int Eye { get => eye; set => eye = value; }
        public int Mouth { get => mouth; set => mouth = value; }
        public int Leg { get => leg; set => leg = value; }
        public int Tail { get => tail; set => tail = value; }

        public void Sounds(string name)
        {
            //throw new NotImplementedException();
            if (name == "dog")

                Console.WriteLine("bow bow");
            else if (name == "cat")
                Console.WriteLine("meow meow");

        }

        public void type(string name)
        {
            if (name == "dog")

                Console.WriteLine("Carnivorus");
            else if (name == "cat")
                Console.WriteLine("Herbivorus");
            //throw new NotImplementedException();
        }
    }
}
