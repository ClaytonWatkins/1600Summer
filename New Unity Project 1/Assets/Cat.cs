using UnityEngine;
using System.Collections;

public class Cat : MammalsWithLegs{

    // Use this for initialization


    // Update is called once per frame

    void OnEnable()
    {
        if (makeNoise)
        {
            print(this.name + " purrs.");
        }
    }
}
