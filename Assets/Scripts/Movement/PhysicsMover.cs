using System;
using UnityEngine;
using System.Collections;

public class PhysicsMover : MonoBehaviour
{
    public float speed;

    private Boolean isGrounded = false;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }

    void Update()
    {
        if (isGrounded)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }

    public void StopMovement()
    {

        speed = 0;
    }
}
