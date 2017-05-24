using UnityEngine;
using System.Collections;

public class AggressiveBehaviors : AnimalScript
{

    //Properties
    public bool makeNoise = false;

    // Use this for initialization
void OnEnable()
    {
        if (makeNoise)
        {
            print(this.name + " growls.");
        }
    }
}