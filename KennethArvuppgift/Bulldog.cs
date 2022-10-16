using System;
using System.Collections.Generic;
using System.Text;

namespace KennethArvuppgift
{
    class Bulldog : Hund
    {
        public string size;
        public string skull;
        
        
        public Bulldog(string pupilShape, string sounds, string animalType, bool fur, bool carnivore, bool omnivore, string size, string skull, bool subtype, string typeDog) : base(pupilShape, sounds, animalType, fur, carnivore, omnivore, subtype, typeDog)
        {
            this.pupilShape = pupilShape;
            this.sounds = sounds;
            this.animalType = animalType;
            this.fur = fur;
            this.carnivore = carnivore;
            this.omnivore = omnivore;
            this.size = size;
            this.skull = skull;
            this.subtype = subtype;
            this.typeDog = typeDog;
        }

        public override void dogSize()
        {
            size = "medium";
            Console.WriteLine("A Chihuahua is " + size);
        }
        public void skullShape()
        {
            skull = "Fucked up";
            Console.WriteLine("A bulldogs skull is kinda " + skull);
        }
    }
}
