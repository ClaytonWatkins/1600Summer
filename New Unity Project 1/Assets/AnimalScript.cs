using UnityEngine;
using System.Collections;

public class AnimalScript : MonoBehaviour {

    //Properties (things they are or have)
    //BodySegments
    public string[] BodySegments = { "Head", "Abs", "Thorax" };
    public string animalName = "Jenny";
    //Health
    public int health = 100;
    //Speed
    public float speed = 1.0f;
    //Size
    public string size = "Small";
    //Color
    public Color BaseColor = Color.black;
    public bool canEat = false;

    //Functions (things they do)
    //Breathe
    //Reproduce


    //Eat     //health = 100 + health //heatlh -= 100
    void Awake()
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


        if (health >= 10)
        {
            health += 100;
        }         
        else
        { 
            health = 100 - health; 
        }

        if (health > 0)
        {
            health = health / 2;
            print(health);
        }
        else
        {
            print("Error");
        }

        if (speed > 20.5f)
        {
            speed /= 2.5f;
        }




        
    }
    
    //Move
    //Die
    //Grow

}
