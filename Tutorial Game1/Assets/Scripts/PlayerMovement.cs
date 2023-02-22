using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;


    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
/*
    void Start()
    {
        rb.AddForce(0,200,500);
    }
*/
    // Update is called once per frame
    // We marked this as "Fixed"Update because we are using it to mess with physics.
    void FixedUpdate() //unity like fixedupdate for physics stuff
    {
        // Add a forward force
        rb.AddForce(0,0,forwardForce * Time.deltaTime); // Add a force of 2000 on the z-axis

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
