using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
public int damage = 1;
public int time = 3;
public int ammo;

	void Start(){
		StartCoroutine(DestroyBullet());
		StartCoroutine(AmmoLoad());
	}
		IEnumerator AmmoLoad(){
			while(ammo<15){
				yield return new WaitForSeconds(2);
				print("Ammo is at " + ammo);			
				ammo ++;}
		}

	void OnCollisionEnter(Collision other)
	{
		var hit = other.gameObject;
		var health = hit.GetComponent<wolfAI>();
		
		if (health != null){
			health.TakeDamage(damage);
		}
	}
		IEnumerator DestroyBullet(){
			yield return new WaitForSeconds(time);
			Destroy(gameObject);
	}
}