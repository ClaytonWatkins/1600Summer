using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
public int regen;
public const int maxHealth = 100;
public int currentHealth = maxHealth;

public Text HP;
public Text maxHP; 

	void OnCollisionEnter(Collision other){
		StartCoroutine(Regen());
		}

	IEnumerator Regen(){
		while(currentHealth<maxHealth){
			yield return new WaitForSeconds(3);
			print("Health at " + currentHealth);			
			currentHealth += regen;}
		}

	// Update is called once per frame
	void Update(){
		HP.text = currentHealth.ToString();
		maxHP.text = maxHealth.ToString();	
		}
	public void TakeDamage(int amount){
		currentHealth -= amount;
		if (currentHealth <= 0){
			currentHealth = 0;
			print("Game Over, have you tried being better?");
		}
	}
}