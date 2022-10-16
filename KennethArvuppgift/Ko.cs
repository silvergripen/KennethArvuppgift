using System;
using System.Collections.Generic;
using System.Text;

namespace KennethArvuppgift
{
    class Ko : Djur
    {
        public Ko(string pupilShape, string sounds, string animalType, bool fur, bool carnivore, bool omnivore, bool subtype) : base(pupilShape, sounds, animalType, fur, carnivore, omnivore, subtype)
        {
            this.pupilShape = pupilShape;
            this.sounds = sounds;
            this.animalType = animalType;
            this.fur = fur;
            this.carnivore = carnivore;
            this.omnivore = omnivore;
            this.subtype = subtype;
        }
        public override void makeSound()
        {
            Console.WriteLine(sounds + " goes the " + animalType);
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
            
        }
        public void pastureSize()
        {

        }
    }
}
