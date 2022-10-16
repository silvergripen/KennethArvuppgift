using System;
using System.Collections.Generic;
using System.Text;

namespace KennethArvuppgift
{
    class Djur
    {
        public string pupilShape;
        public bool fur;
        public string sounds;
        public string animalType;
        public bool carnivore;
        public bool omnivore;
        public bool subtype = true;
        public Djur(string pupilShape, string sounds, string animalType, bool fur, bool carnivore, bool omnivore, bool subtype)
        {
            this.pupilShape = pupilShape;
            this.fur = fur;
            this.sounds = sounds;
            this.animalType = animalType;
            this.carnivore = carnivore;
            this.omnivore = omnivore;
            this.subtype = subtype;

        }

        public virtual void makeSound()
        { 
         
        }
        public virtual void Apperance()
        {
            
        }
        public virtual void behaviour()
        {
           
        }
    }
}
