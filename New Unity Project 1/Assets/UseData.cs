using UnityEngine;
using System.Collections;

public class UseData : MonoBehaviour {

	public string myName = "Tony";
	public int myScore = 2;

	void Start() {
		UseData(myName);
		UseData(myScore);
	}
	
	void UseData (string _s)
	{
		print(_s + ", Hello.");
	}

	void UseData (int _i)
	{
		print(_i * 10);
	}
}
