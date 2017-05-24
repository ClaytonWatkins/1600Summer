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
    //Move away (overrides Move)
    public float SlowSpeed = 0.0f;
    //Run away (Overrides Move away
    public float RunSpeed = 0.0f;

    void Awake()
    {
        if (passiveAnimalName == "Cat")
        {
            print(this.name + " purrs.");
        }
        if (2 + 5 == 7)
        {
            print(this.name + " jumps 7ft high.");
        }
    }
}