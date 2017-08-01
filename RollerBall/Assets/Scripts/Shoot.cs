using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public Rigidbody projectile;
	public Transform Spawnpoint;
	public int shootSpeed;


	void FixedUpdate(){
		if(Input.GetButtonDown("Fire1")){
			Rigidbody clone;
			clone = (Rigidbody)Instantiate(projectile, Spawnpoint.position, Spawnpoint.rotation);
			clone.velocity = Spawnpoint.TransformDirection (Vector3.forward*shootSpeed);

			//WaitForSeconds = 3f
		}
	}
		/*void OnCollisionEnter(Collision other)
	{
		var hit = other.gameObject;
		var health = hit.GetComponent<PlayerHealth>();
		
		if (health != null){
			health.TakeDamage(damage);
		}
	}*/
}