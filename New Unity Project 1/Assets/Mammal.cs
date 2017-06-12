using UnityEngine;
using System.Collections;

public class Mammal : AnimalScript
{

    //Properties
    //Hair
    public bool hasHair = true;
    public int hairCount = 1000;
    public Color HairColor = Color.grey;
    //Warm blooded
    //HowManyLegs {1, 2, 4}
    public int LegCount = 1;
    public bool makeNoise = false;

    //Functions
    //Live Birth Overrides Reproduction
    //Feed Milk
    //Bite

    void OnEnable()
    {
        if (hairCount < 20 || !hasHair)
        {
            print(this.name + " does not have much hair.");
        }

        if (!(hasHair && LegCount > 1))
        {
            print(this.name + " can swim fast.");
        }
        else
        {
            print(this.name + " can run fast.");
        }
    }



}
