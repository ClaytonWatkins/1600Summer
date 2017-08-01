using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController2 : MonoBehaviour {

	public float moveSpeed;
	public float turnSpeed;
	public float myForce;
	private Rigidbody myR;
    public bool canJump;

	void Start (){
		myR = GetComponent<Rigidbody>();
	} 
    
    void FixedUpdate(){
        var y = Input.GetAxis("Horizontal")* Time.deltaTime * turnSpeed;
        var z = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;
        transform.Rotate(0,y,0);
        transform.Translate(0,0,z);
	
	}
	
	private void Jump()
	{
        canJump = false;
		}

    void OnCollisionEnter(Collision other)
    {
        canJump = true;    
    }
}

