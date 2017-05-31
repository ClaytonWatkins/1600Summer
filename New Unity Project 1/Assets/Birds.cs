using UnityEngine;
using System.Collections;

public class Birds : AnimalScript {

    //Properties of Birds
    //Feathers
    //Beaks
    //Wings
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
    }
}
