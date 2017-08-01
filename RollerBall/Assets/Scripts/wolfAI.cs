using UnityEngine;
using System.Collections;

public class wolfAI : MonoBehaviour {

public float moveSpeed;
public Transform target;
public int damage;
public const int maxHealth = 5;
public int currentHealth = maxHealth;
public Transform spawnPoint;

	void OnTriggerStay (Collider other)
	{
		if (other.gameObject.name == "Roller"){
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
	}
	
	void OnCollisionEnter(Collision other)
	{
		var hit = other.gameObject;
		var health = hit.GetComponent<PlayerHealth>();
		
		if (health != null){
			health.TakeDamage(damage);
		}
	}
	public void TakeDamage(int amount){
		currentHealth -= amount;
		if (currentHealth <= 0){
			currentHealth = 0;
			print("wolf is dead");
			/*Destroy (gameObject);*/
			//add points to score for killing the wolf
			/*scoreManager.addPoints(points);*/
			//move wolf to spawn point
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
			currentHealth = maxHealth;
		}
	}
}