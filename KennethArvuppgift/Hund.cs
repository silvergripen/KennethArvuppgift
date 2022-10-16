using System;
using System.Collections.Generic;
using System.Text;

namespace KennethArvuppgift
{
    class Hund : Djur
    {
        public string typeDog;
        public Hund(string pupilShape, string sounds, string animalType, bool fur, bool carnivore, bool omnivore, bool subtype, string typeDog) : base(pupilShape, sounds, animalType, fur, carnivore, omnivore, subtype)
        {
            this.pupilShape = pupilShape;
            this.sounds = sounds;
            this.animalType = animalType;
            this.fur = fur;
            this.carnivore = carnivore;
            this.omnivore = omnivore;
            this.subtype = subtype;
            this.typeDog = typeDog;
        }
        public override void makeSound()
        {
            if (subtype == true)
            {
                Console.WriteLine(typeDog + " barks " + sounds + " a " + typeDog + " Is a kind of " + animalType);
            }
            else
            {
                Console.WriteLine(sounds + " goes the " + animalType);
            }

        }
        public override void Apperance()
        {
            Console.WriteLine("the " + animalType + " has " + pupilShape + " pupils");
            if (fur == true) 
            {
                Console.WriteLine(animalType + "s" + " have fur");
            }
            else
            {
                Console.WriteLine(animalType + "s" + " has no fur");
            }
            
        }
        public override void behaviour()
        {
            animalType = "Dog";
            omnivore = true;
            carnivore = false;
            
        }
        public virtual void  dogSize()
        {

        }
    }
}
