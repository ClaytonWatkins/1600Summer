using UnityEngine;
using System.Collections;

public class Birds : AnimalScript {

    //Properties of Birds
    //Feather count
    public int feathers = 100;
    //Beaks
    public float beak = .25f;
    //Wings bool for if they work
    public bool wings = true;
    //Legs 2
    //Color
    public Color featherColor = Color.red;


    //Functions of Birds
    //Fly overrides move
    //BuildNests
    //Lay Eggs Overrides Reproduction
    //Call

    public bool makeNoise = false;

    void OnEnable()
    {
        if (makeNoise)
        {
            print(this.name + " tweets.");
        }

        if (wings && feathers > 0)
        { 
            print("Flying");
        }
        else
        {
            print(this.name + " is lame.");
        }
 
               
        if (beak < 1 || beak > 10)
        {
            print(this.name + " is to small or to big.");
        }
    }
}
