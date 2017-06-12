using UnityEngine;
using System.Collections;

public class Reptiles : AnimalScript
{
    //Properties (things they are or have)
    //Legs
    public int LegCount = 4;
    //Tail
    public bool tail = true;
    //Claws
    public bool claws = true;
    //Teeth
    public bool teeth = true;
    //Spikes
    public bool spikes = true;
    //Venomous 
    public bool venomous = true;
    
    //Functions (things they do)
    //Breathe
    //Reproduce
    //Eat
    //Move
    //Die
    //Grow

    void OnEnable()
    {
        if (LegCount < 1 && tail)
        {
            print(this.name + " slithers.");
        }
        else
        {
            print(this.name + " crawls.");
        }

        if (teeth || claws)
        {
            print(this.name + " may hurt.");
        }
        else
        {
            print(this.name + " is pretty harmless.");
        }

        if (!(venomous || !spikes))
        {
            print("Watch out for those spikes.");
        }
        else
        {
            print("Look out " + this.name + " might be venomous");
        }
    }
}

