using UnityEngine;
using System.Collections;

public class Lifes : MonoBehaviour
{
    public int life;
    public float deathDelay;

    private Animator anim;
    Animator animator;
    private Rigidbody2D rb;
    private Collider2D coll;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (life <= 0)
        {
            anim.SetBool("Dead", true);
            rb.isKinematic = true;
            coll.enabled = false;
            Destroy(gameObject, deathDelay);
        }
    }

    public void addlife(int live)
    {
        life += live;
    }
}