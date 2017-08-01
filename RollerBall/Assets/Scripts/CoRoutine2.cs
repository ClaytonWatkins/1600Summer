using UnityEngine;
using System.Collections;

public class CoRoutine2 : MonoBehaviour {
	public int number;
	public int maxNumber;
	public int ammo;


	// Use this for initialization
	void Start () {
		StartCoroutine(Health());
		StartCoroutine(AmmoLoad());
	}
	
	IEnumerator Health(){
		while(number<maxNumber){
			yield return new WaitForSeconds(5);
			print("Health at " + number);			
			number ++;}
		}

	IEnumerator AmmoLoad(){
		while(ammo<15){
			yield return new WaitForSeconds(2);
			print("Ammo is at " + ammo);			
			ammo ++;}
		}
}