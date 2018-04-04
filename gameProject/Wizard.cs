using System;

namespace gameProject
{   // Create a base Human class with five attributes: name, strength, intelligence, dexterity, and health.
    public class Wizard: human
    {
        public string charName { get; set; }
        public int strength { get; set; } 
        public int intelligence  { get; set; }

        // Give a default value of 3 for strength, intelligence, and dexterity. Health should have a default of 100.
        //  When an object is constructed from this class it should have the ability to pass a name

        public Wizard(string name) {
            this.strength = 2;
            this.intelligence = 4;
            this.charName = name;

        }
    }
}