using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

public Transform spawnPoint;

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "Chicken"){
		other.transform.position = spawnPoint.position;
		other.transform.rotation = spawnPoint.rotation;
	}
	}
}
