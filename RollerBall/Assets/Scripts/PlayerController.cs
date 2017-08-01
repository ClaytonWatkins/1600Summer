using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody PlayerRb;
    public float myForce = 500;
    public bool canJump;
    private void Jump(){
        PlayerRb.AddForce(0,myForce,0);
        canJump = false;

        //public float jumpHeight;
        //used for movement and not AddForce.
        //var j = Input.GetAxis("Jump")* Time.deltaTime * jumpHeight;
        //var y = Input.GetAxis("Horizontal")* Time.deltaTime * turnSpeed;
        //var z = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;
//Used to move camera
        //transform.Rotate(0,y,0);
        //transform.Translate(0,0,z);
        //transform.Translate(0,j,0); 
    }
    void start()  
    {
        PlayerRb = GetComponent<Rigidbody>();
    }

    //fixedupdated updates on the object when an event occurs rather than time.
    void FixedUpdate()
    {
        //assigning movement to inputs from the keyboard.
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //changing vector3 (x,y,z) to input movements from keyboard while changing lift to 0.
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        //adding force to the rigidbody based on the inputs from the keyboard.
        PlayerRb.AddForce(movement * speed);
                if(Input.GetKeyDown(KeyCode.Space)&& canJump){
            Jump();

        }
    }

    //Collider will destroy other object rather than bouning off
    /*void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }*/
    
    void OnCollisionEnter(Collision other)
    {
        canJump = true;
    }
}
