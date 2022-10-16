using System;

namespace KennethArvuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Djur animal = new Djur("", "" , "", false, false, false, false);
            animal = new Hund("round", "Woof", "dog", true, false, true, false, "dog");
            animal.makeSound();
            animal = new Ko("horizontal line", "Moo", "Cow", true, false, false, false);
            animal.makeSound();
            animal = new Get("vertical line", "Baah", "Goat", true, false, false, false);
            animal.makeSound();
            animal = new Bulldog("round", "Ruff", "dog", true, false, true, "medium", "fucked up", true, "Bulldog");
            animal.makeSound();
            animal = new Chihuahua("round", "Wof", "dog", true, false, true, "small", "aggresive", true, "chiuahua");
            animal.makeSound();



        }
    }
}
