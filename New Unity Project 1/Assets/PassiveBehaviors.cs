using UnityEngine;
using System.Collections;
using System.Xml.Linq;

public class PassiveBehaviors : AnimalScript
{

    //PROPERTIES
    //Reduced aggression
    //Scary easy
    //Makes Noise
    public string passiveAnimalName = "Cat";

    //FUNCTIONS

    void OnEnable()
    {
        if (health > 7)
        {
            print(this.name + " jumps 7ft high.");
        }
        else
        {
            print(this.name + " falls down.");
        }
    }
}