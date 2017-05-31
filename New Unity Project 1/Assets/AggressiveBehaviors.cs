using UnityEngine;
using System.Collections;

public class AggressiveBehaviors : AnimalScript
{

    //Properties
    public bool makeNoise = false;

    // Use this for initialization
    void OnEnable()
    {
        if (animalName == "Rover")
        {
            print(this.name + " growls.");
        }
        else
        {
            print(this.name + " hisses.");
        }
    }
}