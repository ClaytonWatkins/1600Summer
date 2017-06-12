using UnityEngine;
using System.Collections;

public class Dog : MammalsWithLegs {

    //Properties
    //Tails
    public bool tail = true;
    //HowManyLegs Override {4}
    public int legs = 4;
    //age
    public int age = 1;


    //Functions
    //friendly
    public bool friendly = true;
    //Bark
    //Attack
    void OnEnable()
    {
        if (makeNoise)
        {
            print(this.name + " barks.");
        }

        if (tail && friendly)
        {
            print(this.name + "wags his tail in excitement.");
        }
        else
        {
            print(this.name + "runs in circles excitedly.");
        }


        if (legs < 4 || legs > 2 )
        {
            print(this.name + "crawls.");
        }



    }
}
