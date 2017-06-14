using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArrayAndLists : MonoBehaviour {

    //Arrays can not able be modified by the computer during 'runtime'
    //Arrays can be modified by the editor while not in 'runtime'

    public List<string> players = new List<string>();
    public string thing;

    public void ClickHere(string _s)
    {
        players.Add(_s);

    }

    public void RunLoop()
    {
        foreach (string item in players)
        {
            print(item);
        }
        if (players.Count != 1 )
        {
            print("You have " + players.Count + " players.");
        }
        else
        {
            print("You have " + players.Count + " player.");
        }


    }
/*public string[] myStrings;
public string[] myOtherStrings = { "Bob", "Fred", "Mike" , "Jeff" };

public List<string> myStringList;*/

// Use this for initialization
void Start () {

        players.Add("Jenny");
        players.Add("Bill");
        players.Add("Bob");


        /*myStringList = new List<string>();
        myStringList.Add("Jenny");*/

	
	}

	// Update is called once per frame
	void Update () {
	
	}
}
