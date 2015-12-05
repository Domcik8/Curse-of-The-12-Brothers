using System;
using UnityEngine;
using System.Collections;

public class FrogController : MonoBehaviour {

    // Use this for initialization

    public float jumpHeight = 20f;
    public float jumpLenght = 20f;
    public Animator anim;
    Boolean isGrounded = false;
    private Rigidbody2D rigid;

    CharacterController controller;

    void Awake ()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (isGrounded)
        {
            //rigid.AddForce(new Vector2(jumpLenght, jumpHeight));
        }
    }

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
}
