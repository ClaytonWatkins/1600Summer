using UnityEngine;
using System.Collections;

public class FunctionBasics : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("Start");
	}
	void Awake(){		
		print("Awake");
	}
	void OnEnable()	{
		print("onEnable");
	}	
	void OnDisable(){
		print("OnDisable");
	}
	void OnTriggerEnter(Collider _col){
		print(_col.name);
		if(_col.name != "enemy")
		{
			_col.gameObject.SetActive(false);
		}
	}
	void OnTriggerExit(){
		print("triggerexit");
	}

}