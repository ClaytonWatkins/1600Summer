using UnityEngine;
using System.Collections;

public class Dog : MammalsWithLegs {

    //Properties
    //Tails
    //HowManyLegs Override {4}


    //Functions
    //Bark
    //Attack
    void OnEnable()
    {
        if (makeNoise)
        {
            print(this.name + " barks.");
        }
    }
}
