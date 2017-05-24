using UnityEngine;
using System.Collections;

public class AnimalScript : MonoBehaviour {

    //Properties (things they are or have)
    //BodySegments
    public string[] BodySegments = { "Head", "Abs", "Thorax" };
    public string animalName = "Jenny";
    //Health
    public int Health = 100;
    //Speed
    public float Speed = 0.0f;
    //Size
    public string Size = "Big";
    //Color
    public Color BaseColor = Color.black;
    public bool canEat = false;

    //Functions (things they do)
    //Breathe
    //Reproduce
    //Eat
    void Start()
    {
        if (canEat)
        {
            print(this.name + " can eat.");
        }
        else
        {
            print(this.name + " can't eat");
        }
        if (animalName == "Jen")
        {
            print("Jen");
        }
    }
    
    //Move
    //Die
    //Grow

}
