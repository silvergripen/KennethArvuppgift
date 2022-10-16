using System;
using System.Collections.Generic;
using System.Text;

namespace KennethArvuppgift
{
    class Chihuahua : Hund
    {
        public string size;
        public string energy;
        

        public Chihuahua(string pupilShape, string sounds, string animalType, bool fur, bool carnivore, bool omnivore, string size, string energy, bool subtype, string typeDog) : base(pupilShape, sounds, animalType, fur, carnivore, omnivore, subtype, typeDog)
        {
            this.pupilShape = pupilShape;
            this.sounds = sounds;
            this.animalType = animalType;
            this.fur = fur;
            this.carnivore = carnivore;
            this.omnivore = omnivore;
            this.size = size;
            this.energy = energy;
            this.subtype = subtype;
            this.typeDog = typeDog;
        }
        public override void dogSize()
        {
            
            Console.WriteLine("A Chihuahua is " + size);
        }
        public void mood()
        {
            
            Console.WriteLine("Chihuahua have a short dog complex, which makes it more " + energy + ". This is because its very uncertain around dogs or people that are larger than it");
        }
    }
}
