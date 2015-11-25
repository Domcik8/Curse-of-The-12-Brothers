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
        coll = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (life <= 0)
        {
            if (this.gameObject.tag == "Enemy")
            {
                anim.SetBool("Dead", true);
                GetComponent<PhysicsMover>().enabled = false;
                DeactivateChildren(this.gameObject ,false);
            }
            Destroy(gameObject, deathDelay);
        }
    }

    public void addlife(int live)
    {
        life += live;
    }


    void DeactivateChildren(GameObject g, bool a)
    {

        Transform child = transform.FindChild("Trigger");

        if (child != null)
        {
            child.gameObject.SetActive(false);
        }
        else Debug.Log("Child not found");
    }
}