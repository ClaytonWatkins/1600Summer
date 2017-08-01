using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	
	public int points;

	
	void Update () 
	{
		transform.Rotate (new Vector3 (45, 30, 15) * Time.deltaTime);
	}
	void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Chicken"))
        {
            this.gameObject.SetActive(false);
			ScoreManager.AddPoints(points);
		}
	}
}
