using UnityEngine;
using System.Collections;

public class JudejimasKalnas : MonoBehaviour
{
    public float speed;
    public float stop;
    public float slowStart1;
    public float slowStop1;
    public float slowSpeed;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
    }

    void FixedUpdate()
    {
     /*   if (GetComponent<Transform>().position.x < slowStart1)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * slowSpeed;
        }
        if (GetComponent<Transform>().position.x < slowStop1)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        }
        if (GetComponent<Transform>().position.x < stop)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * 0;
        }*/
    }

    public void StopMovement()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * 0;
    }
}