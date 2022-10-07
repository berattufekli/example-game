using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000;
    public float sidewayForce = 500;

    public Animator animator;

    public Vector3 offset;

    void FixedUpdate()
    {
        Debug.Log(rb.velocity.magnitude);
        

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }
    }

    //private void OnTriggerEnter(Collider collision)
    //{
    //    if (collision.name == "yer")
    //    {
    //        rb.velocity = Vector3.zero;
    //        Debug.Log("yer");
    //        transform.position = offset;
    //        rb.ResetInertiaTensor();
    //    }
    //}
}
